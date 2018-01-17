using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvNetSharp.Core;
using ConvNetSharp.Core.Layers.Double;
using ConvNetSharp.Core.Training;
using ConvNetSharp.Volume;

namespace MnistDemoWithGUI
{
    public partial class MainForm : Form
    {
        private Net<double> _net;
        private SgdTrainer<double> _trainer;
        private bool isStop = false;
        private int _step;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowStatus(string str)
        {
            txt_Status.Text = str;
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
                LearningRate = double.Parse(txt_LearingRate.ToString()),
                BatchSize = int.Parse(txt_BatchSize.ToString()),
                L2Decay = 0.001,
                Momentum = 0.9

            };
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
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            var datasets = new DataSets();
            datasets.MessageHolder = ShowStatus;
            // use 5000 data for validation
            if (!datasets.Load(5000))
            {
                return;
            }

            CreateMnistNet();
            SetTrainer();

            do
            {
                var trainSample = datasets.Train.NextBatch(this._trainer.BatchSize); 
            } while (!isStop);

            ShowStatus(" Network Training ...  [ Press Stop button to Stop ]");
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            isStop = true;
        }
    }
}
