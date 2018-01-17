using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Features2D;
using Emgu.CV.ML;
using Emgu.CV.Util;
using Emgu.Util;
using Emgu.CV.Face;
using Emgu.CV.VideoSurveillance;
using Emgu.CV.Stitching;

namespace Drawing_Handwrite
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Pen pen;
        int pre_x = 0, pre_y = 0;
        int x = 0, y = 0;

        //default setting
        int scroll = 2;//default筆刷粗細
        MCvScalar penColor;//筆刷顏色

        Image<Bgr, byte> paint;
        bool isMouseDown = false;
        List<Point> points = new List<Point>();
        string strSourcePath = "C:\\Users\\Lynn\\Desktop";
        public Form1()
        {
            InitializeComponent();
            
            //graph = Graphics.FromImage(bmp);
            graph = this.CreateGraphics();
            pen = new Pen(Color.Blue, 3);
            //private string FilePath = @"C:\Users\Lynn\Desktop\索引.jpg";
            //this.BackgroundImage = new Bitmap(FilePath);
            paint = new Image<Bgr, byte>(320, 320, new Bgr(0, 0, 0));
            paint = paint.Resize(200, 200, Emgu.CV.CvEnum.Inter.Linear, true);
            for (int i = 0; i < paint.Width; i++)
            {

                    for (int j = 0; j < paint.Height; j++)
                    {
                        paint.Data[j, i, 0] = 0;
                        paint.Data[j, i, 1] = 0;
                        paint.Data[j, i, 2] = 0;
                    }
            }

            //imBox_draw.InitialImage = new Bitmap(@"C:\Users\Lynn\Desktop\索引.jpg");
            imBox_draw.Image = paint;
            trBar_Pen.Value = 2;
            txtBox_Pen.Text = trBar_Pen.Value.ToString();
        }
        //Form1 啟動
        private void Form1_Load(object sender, EventArgs e)
        {
            //paint = new Image<Bgr, byte>(320, 320);
            imBox_draw.Image = paint;
        }

        private void btn_shot_Click(object sender, EventArgs e)
        {
            Size screenSize = new Size(this.Width + 200, this.Height + 200);

            try
            {
                paint.Save(@strSourcePath + "\\screenShot5.jpg");
                MessageBox.Show("File saved.");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void imBox_draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                //points.Add(e.Location);
                x = e.X;
                y = e.Y;
                penColor = new MCvScalar(255, 255, 255);
                CvInvoke.Line(paint, new Point(pre_x, pre_y), new Point(x, y), penColor, scroll, LineType.EightConnected, 0);
                pre_x = x;
                pre_y = y;
                imBox_draw.Image = paint;
            }
        }

        private void imBox_draw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void imBox_draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                //points.Add(e.Location);
                pre_x = e.X;
                pre_y = e.Y;
                txt_Location.AppendText("X:" + e.Location.X.ToString() + "\tY:" + e.Location.Y.ToString());
                txt_Location.AppendText("\n");
            }
        }

        private void btn_Pen_Click(object sender, EventArgs e)
        {

        }

        private void trBar_Pen_Scroll(object sender, EventArgs e)
        {
            scroll = trBar_Pen.Value;
            txtBox_Pen.Text = scroll.ToString();
        }

        private void btn_emgu_Click(object sender, EventArgs e)
        {

        }
    }
}
