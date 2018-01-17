namespace Drawing_Handwrite
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_shot = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.imBox_draw = new Emgu.CV.UI.ImageBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PenWidth = new System.Windows.Forms.Label();
            this.trBar_Pen = new System.Windows.Forms.TrackBar();
            this.txtBox_Pen = new System.Windows.Forms.TextBox();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.btn_Pen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imBox_draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_Pen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_shot
            // 
            this.btn_shot.Location = new System.Drawing.Point(389, 369);
            this.btn_shot.Name = "btn_shot";
            this.btn_shot.Size = new System.Drawing.Size(168, 54);
            this.btn_shot.TabIndex = 0;
            this.btn_shot.Text = "擷取手寫數字";
            this.btn_shot.UseVisualStyleBackColor = true;
            this.btn_shot.Click += new System.EventHandler(this.btn_shot_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(389, 298);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(168, 49);
            this.btn_CLR.TabIndex = 2;
            this.btn_CLR.Text = "清除畫面";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_emgu_Click);
            // 
            // imBox_draw
            // 
            this.imBox_draw.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.imBox_draw.InitialImage = ((System.Drawing.Image)(resources.GetObject("imBox_draw.InitialImage")));
            this.imBox_draw.Location = new System.Drawing.Point(40, 30);
            this.imBox_draw.Name = "imBox_draw";
            this.imBox_draw.Size = new System.Drawing.Size(320, 320);
            this.imBox_draw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imBox_draw.TabIndex = 2;
            this.imBox_draw.TabStop = false;
            this.imBox_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imBox_draw_MouseDown);
            this.imBox_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imBox_draw_MouseMove);
            this.imBox_draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imBox_draw_MouseUp);
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(185, 369);
            this.txt_Location.Multiline = true;
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Location.Size = new System.Drawing.Size(165, 54);
            this.txt_Location.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "座標";
            // 
            // lbl_PenWidth
            // 
            this.lbl_PenWidth.AutoSize = true;
            this.lbl_PenWidth.Location = new System.Drawing.Point(366, 79);
            this.lbl_PenWidth.Name = "lbl_PenWidth";
            this.lbl_PenWidth.Size = new System.Drawing.Size(72, 16);
            this.lbl_PenWidth.TabIndex = 5;
            this.lbl_PenWidth.Text = "筆刷大小";
            // 
            // trBar_Pen
            // 
            this.trBar_Pen.Location = new System.Drawing.Point(369, 109);
            this.trBar_Pen.Name = "trBar_Pen";
            this.trBar_Pen.Size = new System.Drawing.Size(188, 61);
            this.trBar_Pen.TabIndex = 6;
            this.trBar_Pen.Scroll += new System.EventHandler(this.trBar_Pen_Scroll);
            // 
            // txtBox_Pen
            // 
            this.txtBox_Pen.Location = new System.Drawing.Point(457, 76);
            this.txtBox_Pen.Name = "txtBox_Pen";
            this.txtBox_Pen.Size = new System.Drawing.Size(100, 27);
            this.txtBox_Pen.TabIndex = 7;
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.Location = new System.Drawing.Point(475, 21);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(82, 50);
            this.btn_Eraser.TabIndex = 8;
            this.btn_Eraser.Text = "橡皮擦";
            this.btn_Eraser.UseVisualStyleBackColor = true;
            // 
            // btn_Pen
            // 
            this.btn_Pen.Location = new System.Drawing.Point(375, 21);
            this.btn_Pen.Name = "btn_Pen";
            this.btn_Pen.Size = new System.Drawing.Size(82, 50);
            this.btn_Pen.TabIndex = 9;
            this.btn_Pen.Text = "筆刷";
            this.btn_Pen.UseVisualStyleBackColor = true;
            this.btn_Pen.Click += new System.EventHandler(this.btn_Pen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 448);
            this.Controls.Add(this.btn_Pen);
            this.Controls.Add(this.btn_Eraser);
            this.Controls.Add(this.txtBox_Pen);
            this.Controls.Add(this.trBar_Pen);
            this.Controls.Add(this.lbl_PenWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.imBox_draw);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_shot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imBox_draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_Pen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_shot;
        private System.Windows.Forms.Button btn_CLR;
        private Emgu.CV.UI.ImageBox imBox_draw;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PenWidth;
        private System.Windows.Forms.TrackBar trBar_Pen;
        private System.Windows.Forms.TextBox txtBox_Pen;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.Button btn_Pen;
    }
}

