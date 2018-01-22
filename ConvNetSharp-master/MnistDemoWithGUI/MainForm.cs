using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvNetSharp.Core;
using ConvNetSharp.Core.Layers.Double;
using ConvNetSharp.Core.Training;
using ConvNetSharp.Volume;
using ConvNetSharp.Volume.Double;
using System.Threading;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using System.Drawing;

namespace MnistDemoWithGUI
{
    public partial class MainForm : Form
    {
        private Net<double> _net;
        private SgdTrainer<double> _trainer;
        private CircularBuffer<double> _train_accuracy;
        private CircularBuffer<double> _test_accuracy = new CircularBuffer<double>(100);

        private Task _train_engine;
        private CancellationTokenSource _train_engine_ct = new CancellationTokenSource();

        private static System.Windows.Forms.Timer CountTimer = new System.Windows.Forms.Timer();
        private int _time = 0;
        private int _step = 0;

        // Paint
        private Image<Gray, Byte> _paint = new Image<Gray, Byte>(250, 250, new Gray(0));
        private int _mouse_X, _mouse_Y;
        private int _pre_mouse_X, _pre_mouse_Y;
        private bool isMouseDown = false;

        public MainForm()
        {
            InitializeComponent();
            
            CountTimer.Interval = 1000; // 每當 Timer 數到 Interval 的間格時間時會觸發 Tick 事件
            CountTimer.Tick += new EventHandler(TimerTick);
            CountTimer.Stop(); // 確保程式執行時 Timer 是停止狀態
            CreateMnistNet(); // 程式開始執行即創建網路

            _paint = _paint.Resize(250, 250, Inter.Linear, true);
            imgBox_Paint.Image = _paint;
        }

        private void ShowStatus(string str)
        {
            this.BeginInvoke(
                new MethodInvoker(() => txt_Status.Text = str)
            );
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this._time++;
            this.BeginInvoke(
                new MethodInvoker(() => txt_ExecutionTime.Text = this._time.ToString() + " s")
            );
            
        }

        private void CreateMnistNet()
        {
            this._net = new Net<double>();
            this._net.AddLayer(new InputLayer(28, 28, 1));
            this._net.AddLayer(new ConvLayer(5, 5, 8) { Stride = 1, Pad = 2 });
            this._net.AddLayer(new ReluLayer());
            this._net.AddLayer(new PoolLayer(2, 2) { Stride = 2 });
            this._net.AddLayer(new ConvLayer(5, 5, 16) { Stride = 1, Pad = 2 });
            this._net.AddLayer(new ReluLayer());
            this._net.AddLayer(new PoolLayer(3, 3) { Stride = 3 });
            this._net.AddLayer(new FullyConnLayer(10));
            this._net.AddLayer(new SoftmaxLayer(10));
        }

        private void SetTrainer()
        {
            this._trainer = new SgdTrainer<double>(this._net)
            {
                LearningRate = double.Parse(txt_LearingRate.Text),
                BatchSize = int.Parse(txt_BatchSize.Text),
                L2Decay = 0.001,
                Momentum = 0.9

            };

            this._train_accuracy = new CircularBuffer<double>(this._trainer.BatchSize);
        }

        private void Test(Volume<double> x, int[] labels, CircularBuffer<double> accuracy, bool Forward = true)
        {
            if (Forward)
            {
                this._net.Forward(x);
            }

            var prediction = this._net.GetPrediction();

            for(var i = 0; i < labels.Length; i++)
            {
                accuracy.Add(labels[i] == prediction[i] ? 1.0 : 0.0);
            }

        }

        private void Train(Volume<double> x, Volume<double> y, int[] labels)
        {
            this._trainer.Train(x, y);

            Test(x, labels, this._train_accuracy, false);

            this._step += labels.Length;
        }

        private void DoTrain()
        {
            var datasets = new DataSets();
            datasets.MessageHolder = ShowStatus;
            // use 5000 data for validation
            // use Task to avoid GUI freezing
            if (!datasets.Load(1000))
                return;

            ShowStatus(" Network training ...");

            while (!_train_engine_ct.IsCancellationRequested)
            {
                ShowStatus(" Network training ... [Training]");
                var trainSample = datasets.Train.NextBatch(this._trainer.BatchSize);
                Train(trainSample.Item1, trainSample.Item2, trainSample.Item3);

                ShowStatus(" Network training ... [Testing]");
                var testSample = datasets.Test.NextBatch(100); // use 100 test data to test
                Test(testSample.Item1, testSample.Item3, this._test_accuracy);

                var train_accuracy = Math.Round(this._train_accuracy.Items.Average() * 100.0, 3);
                var test_accuracy = Math.Round(this._test_accuracy.Items.Average() * 100.0, 3);

                this.BeginInvoke(
                    new MethodInvoker(() => {
                        lbl_TrainAccuracy.Text = train_accuracy.ToString() + " %"; // 精確度至小數點後一位
                                lbl_TestAccuracy.Text = test_accuracy.ToString() + " %";
                        pBar_TrainAccuracy.Value = (int)(train_accuracy * 10);
                        pBar_TestAccuracy.Value = (int)(test_accuracy * 10);
                        txt_Step.Text = this._step.ToString();
                        txt_Loss.Text = this._trainer.Loss.ToString();
                    }
                    )

                );
            }

            ShowStatus(" IDLE");
            CountTimer.Stop();
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            if (_train_engine_ct.IsCancellationRequested)
                _train_engine_ct = new CancellationTokenSource();
            try
            {
                SetTrainer();
                _train_engine = new Task(DoTrain);
                _train_engine.Start();
                CountTimer.Start();
            }
            catch
            {
                MessageBox.Show("Please check setting!", "Warning");
            }    
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ShowStatus(" Stopping ...");
            _train_engine_ct.Cancel();
        }

        // Painting Method
        private void imgBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.isMouseDown = true;
                _pre_mouse_X = _mouse_X = e.X;
                _pre_mouse_Y = _mouse_Y = e.Y;
                
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this._paint = new Image<Gray, byte>(250, 250, new Gray(0));
            imgBox_Paint.Image = this._paint;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int w = 28;
            int h = 28;
            // 創建 Volume 物件 (Forward需要)
            var dataShape = new Shape(w, h, 1, 1); // Shape(width, height, channel, batchSize)
            var data = new double[dataShape.TotalLength];
            var dataVolume = BuilderInstance.Volume.From(data, dataShape);

            _paint = this._paint.Resize(28, 28, Inter.Linear);

            // 創建 MnistEntry 物件, 用來設定 dataVolume
            var entry = new MnistEntry();
            entry.Image = _paint.Bytes;

            for(int y = 0;y< h; y++)
            {
                for(int x=0;x< w; x++)
                {
                    dataVolume.Set(x, y, 0, 0, entry.Image[y * w + x] / 255.0);
                }
            }

            this._net.Forward(dataVolume);
            var result = this._net.GetPrediction();

            txt_Prediction.Text = " " + result[0].ToString();
        }

        private void imgBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.isMouseDown = false;
        }

        private void imgBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                _mouse_X = e.X;
                _mouse_Y = e.Y;

                CvInvoke.Line(_paint,
                    new Point(_pre_mouse_X, _pre_mouse_Y),
                    new Point(_mouse_X, _mouse_Y),
                    new MCvScalar(255),
                    2, LineType.EightConnected, 0);

                _pre_mouse_X = _mouse_X;
                _pre_mouse_Y = _mouse_Y;
                imgBox_Paint.Image = this._paint;
            }
        }
    }
}
