namespace MnistDemoWithGUI
{
    partial class MainForm
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
            this.TrainingSetting = new System.Windows.Forms.GroupBox();
            this.lbl_LearingRate = new System.Windows.Forms.Label();
            this.txt_LearingRate = new System.Windows.Forms.TextBox();
            this.lbl_BatchSize = new System.Windows.Forms.Label();
            this.txt_BatchSize = new System.Windows.Forms.TextBox();
            this.lbl_Trainer = new System.Windows.Forms.Label();
            this.cbox_Trainer = new System.Windows.Forms.ComboBox();
            this.btn_Train = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.gbox_Message = new System.Windows.Forms.GroupBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Step = new System.Windows.Forms.Label();
            this.txt_Step = new System.Windows.Forms.TextBox();
            this.TrainingSetting.SuspendLayout();
            this.gbox_Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainingSetting
            // 
            this.TrainingSetting.Controls.Add(this.btn_Stop);
            this.TrainingSetting.Controls.Add(this.btn_Train);
            this.TrainingSetting.Controls.Add(this.cbox_Trainer);
            this.TrainingSetting.Controls.Add(this.lbl_Trainer);
            this.TrainingSetting.Controls.Add(this.txt_BatchSize);
            this.TrainingSetting.Controls.Add(this.lbl_BatchSize);
            this.TrainingSetting.Controls.Add(this.txt_LearingRate);
            this.TrainingSetting.Controls.Add(this.lbl_LearingRate);
            this.TrainingSetting.Location = new System.Drawing.Point(12, 12);
            this.TrainingSetting.Name = "TrainingSetting";
            this.TrainingSetting.Size = new System.Drawing.Size(238, 169);
            this.TrainingSetting.TabIndex = 0;
            this.TrainingSetting.TabStop = false;
            this.TrainingSetting.Text = "Training Setting";
            // 
            // lbl_LearingRate
            // 
            this.lbl_LearingRate.AutoSize = true;
            this.lbl_LearingRate.Location = new System.Drawing.Point(16, 28);
            this.lbl_LearingRate.Name = "lbl_LearingRate";
            this.lbl_LearingRate.Size = new System.Drawing.Size(80, 15);
            this.lbl_LearingRate.TabIndex = 0;
            this.lbl_LearingRate.Text = "Learing Rate";
            // 
            // txt_LearingRate
            // 
            this.txt_LearingRate.Location = new System.Drawing.Point(102, 25);
            this.txt_LearingRate.Name = "txt_LearingRate";
            this.txt_LearingRate.Size = new System.Drawing.Size(113, 25);
            this.txt_LearingRate.TabIndex = 1;
            // 
            // lbl_BatchSize
            // 
            this.lbl_BatchSize.AutoSize = true;
            this.lbl_BatchSize.Location = new System.Drawing.Point(29, 60);
            this.lbl_BatchSize.Name = "lbl_BatchSize";
            this.lbl_BatchSize.Size = new System.Drawing.Size(67, 15);
            this.lbl_BatchSize.TabIndex = 2;
            this.lbl_BatchSize.Text = "Batch Size";
            // 
            // txt_BatchSize
            // 
            this.txt_BatchSize.Location = new System.Drawing.Point(102, 56);
            this.txt_BatchSize.Name = "txt_BatchSize";
            this.txt_BatchSize.Size = new System.Drawing.Size(113, 25);
            this.txt_BatchSize.TabIndex = 3;
            // 
            // lbl_Trainer
            // 
            this.lbl_Trainer.AutoSize = true;
            this.lbl_Trainer.Location = new System.Drawing.Point(47, 91);
            this.lbl_Trainer.Name = "lbl_Trainer";
            this.lbl_Trainer.Size = new System.Drawing.Size(49, 15);
            this.lbl_Trainer.TabIndex = 4;
            this.lbl_Trainer.Text = "Trainer";
            // 
            // cbox_Trainer
            // 
            this.cbox_Trainer.FormattingEnabled = true;
            this.cbox_Trainer.Items.AddRange(new object[] {
            "Sgd",
            "Adam"});
            this.cbox_Trainer.Location = new System.Drawing.Point(102, 88);
            this.cbox_Trainer.Name = "cbox_Trainer";
            this.cbox_Trainer.Size = new System.Drawing.Size(113, 23);
            this.cbox_Trainer.TabIndex = 5;
            // 
            // btn_Train
            // 
            this.btn_Train.Location = new System.Drawing.Point(19, 122);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(120, 33);
            this.btn_Train.TabIndex = 6;
            this.btn_Train.Text = "Start Training";
            this.btn_Train.UseVisualStyleBackColor = true;
            this.btn_Train.Click += new System.EventHandler(this.btn_Train_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(145, 122);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(70, 33);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // gbox_Message
            // 
            this.gbox_Message.Controls.Add(this.txt_Step);
            this.gbox_Message.Controls.Add(this.lbl_Step);
            this.gbox_Message.Controls.Add(this.lbl_Status);
            this.gbox_Message.Controls.Add(this.txt_Status);
            this.gbox_Message.Location = new System.Drawing.Point(256, 12);
            this.gbox_Message.Name = "gbox_Message";
            this.gbox_Message.Size = new System.Drawing.Size(514, 169);
            this.gbox_Message.TabIndex = 1;
            this.gbox_Message.TabStop = false;
            this.gbox_Message.Text = "Message";
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(67, 25);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(429, 25);
            this.txt_Status.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(18, 28);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 15);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Step
            // 
            this.lbl_Step.AutoSize = true;
            this.lbl_Step.Location = new System.Drawing.Point(27, 60);
            this.lbl_Step.Name = "lbl_Step";
            this.lbl_Step.Size = new System.Drawing.Size(32, 15);
            this.lbl_Step.TabIndex = 2;
            this.lbl_Step.Text = "Step";
            // 
            // txt_Step
            // 
            this.txt_Step.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Step.Location = new System.Drawing.Point(67, 56);
            this.txt_Step.Name = "txt_Step";
            this.txt_Step.ReadOnly = true;
            this.txt_Step.Size = new System.Drawing.Size(83, 25);
            this.txt_Step.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbox_Message);
            this.Controls.Add(this.TrainingSetting);
            this.Name = "MainForm";
            this.Text = "MnistDemoWithGUI";
            this.TrainingSetting.ResumeLayout(false);
            this.TrainingSetting.PerformLayout();
            this.gbox_Message.ResumeLayout(false);
            this.gbox_Message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TrainingSetting;
        private System.Windows.Forms.TextBox txt_BatchSize;
        private System.Windows.Forms.Label lbl_BatchSize;
        private System.Windows.Forms.TextBox txt_LearingRate;
        private System.Windows.Forms.Label lbl_LearingRate;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.ComboBox cbox_Trainer;
        private System.Windows.Forms.Label lbl_Trainer;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.GroupBox gbox_Message;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_Step;
        private System.Windows.Forms.Label lbl_Step;
    }
}

