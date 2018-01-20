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
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Train = new System.Windows.Forms.Button();
            this.cbox_Trainer = new System.Windows.Forms.ComboBox();
            this.lbl_Trainer = new System.Windows.Forms.Label();
            this.txt_BatchSize = new System.Windows.Forms.TextBox();
            this.lbl_BatchSize = new System.Windows.Forms.Label();
            this.txt_LearingRate = new System.Windows.Forms.TextBox();
            this.lbl_LearingRate = new System.Windows.Forms.Label();
            this.gbox_Message = new System.Windows.Forms.GroupBox();
            this.txt_ExecutionTime = new System.Windows.Forms.TextBox();
            this.lbl_OperationTime = new System.Windows.Forms.Label();
            this.txt_Loss = new System.Windows.Forms.TextBox();
            this.lbl_loss = new System.Windows.Forms.Label();
            this.txt_Step = new System.Windows.Forms.TextBox();
            this.lbl_Step = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.gbox_accuracy = new System.Windows.Forms.GroupBox();
            this.lbl_TestAccuracy = new System.Windows.Forms.Label();
            this.lbl_TrainAccuracy = new System.Windows.Forms.Label();
            this.pBar_TestAccuracy = new System.Windows.Forms.ProgressBar();
            this.pBar_TrainAccuracy = new System.Windows.Forms.ProgressBar();
            this.lbl_Test = new System.Windows.Forms.Label();
            this.lbl_Train = new System.Windows.Forms.Label();
            this.TrainingSetting.SuspendLayout();
            this.gbox_Message.SuspendLayout();
            this.gbox_accuracy.SuspendLayout();
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
            this.TrainingSetting.Size = new System.Drawing.Size(238, 212);
            this.TrainingSetting.TabIndex = 0;
            this.TrainingSetting.TabStop = false;
            this.TrainingSetting.Text = "Training Setting";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(19, 169);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(196, 33);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Train
            // 
            this.btn_Train.Location = new System.Drawing.Point(19, 130);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(196, 33);
            this.btn_Train.TabIndex = 6;
            this.btn_Train.Text = "Start Training";
            this.btn_Train.UseVisualStyleBackColor = true;
            this.btn_Train.Click += new System.EventHandler(this.btn_Train_Click);
            // 
            // cbox_Trainer
            // 
            this.cbox_Trainer.FormattingEnabled = true;
            this.cbox_Trainer.Items.AddRange(new object[] {
            "Sgd",
            "Adam"});
            this.cbox_Trainer.Location = new System.Drawing.Point(102, 96);
            this.cbox_Trainer.Name = "cbox_Trainer";
            this.cbox_Trainer.Size = new System.Drawing.Size(113, 23);
            this.cbox_Trainer.TabIndex = 5;
            // 
            // lbl_Trainer
            // 
            this.lbl_Trainer.AutoSize = true;
            this.lbl_Trainer.Location = new System.Drawing.Point(47, 99);
            this.lbl_Trainer.Name = "lbl_Trainer";
            this.lbl_Trainer.Size = new System.Drawing.Size(49, 15);
            this.lbl_Trainer.TabIndex = 4;
            this.lbl_Trainer.Text = "Trainer";
            // 
            // txt_BatchSize
            // 
            this.txt_BatchSize.Location = new System.Drawing.Point(102, 60);
            this.txt_BatchSize.Name = "txt_BatchSize";
            this.txt_BatchSize.Size = new System.Drawing.Size(113, 25);
            this.txt_BatchSize.TabIndex = 3;
            // 
            // lbl_BatchSize
            // 
            this.lbl_BatchSize.AutoSize = true;
            this.lbl_BatchSize.Location = new System.Drawing.Point(29, 64);
            this.lbl_BatchSize.Name = "lbl_BatchSize";
            this.lbl_BatchSize.Size = new System.Drawing.Size(67, 15);
            this.lbl_BatchSize.TabIndex = 2;
            this.lbl_BatchSize.Text = "Batch Size";
            // 
            // txt_LearingRate
            // 
            this.txt_LearingRate.Location = new System.Drawing.Point(102, 25);
            this.txt_LearingRate.Name = "txt_LearingRate";
            this.txt_LearingRate.Size = new System.Drawing.Size(113, 25);
            this.txt_LearingRate.TabIndex = 1;
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
            // gbox_Message
            // 
            this.gbox_Message.Controls.Add(this.txt_ExecutionTime);
            this.gbox_Message.Controls.Add(this.lbl_OperationTime);
            this.gbox_Message.Controls.Add(this.txt_Loss);
            this.gbox_Message.Controls.Add(this.lbl_loss);
            this.gbox_Message.Controls.Add(this.txt_Step);
            this.gbox_Message.Controls.Add(this.lbl_Step);
            this.gbox_Message.Controls.Add(this.lbl_Status);
            this.gbox_Message.Controls.Add(this.txt_Status);
            this.gbox_Message.Location = new System.Drawing.Point(256, 12);
            this.gbox_Message.Name = "gbox_Message";
            this.gbox_Message.Size = new System.Drawing.Size(514, 101);
            this.gbox_Message.TabIndex = 1;
            this.gbox_Message.TabStop = false;
            this.gbox_Message.Text = "Message";
            // 
            // txt_ExecutionTime
            // 
            this.txt_ExecutionTime.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExecutionTime.Location = new System.Drawing.Point(396, 60);
            this.txt_ExecutionTime.Name = "txt_ExecutionTime";
            this.txt_ExecutionTime.ReadOnly = true;
            this.txt_ExecutionTime.Size = new System.Drawing.Size(100, 25);
            this.txt_ExecutionTime.TabIndex = 7;
            this.txt_ExecutionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_OperationTime
            // 
            this.lbl_OperationTime.AutoSize = true;
            this.lbl_OperationTime.Location = new System.Drawing.Point(292, 64);
            this.lbl_OperationTime.Name = "lbl_OperationTime";
            this.lbl_OperationTime.Size = new System.Drawing.Size(98, 15);
            this.lbl_OperationTime.TabIndex = 6;
            this.lbl_OperationTime.Text = "Execution Time";
            // 
            // txt_Loss
            // 
            this.txt_Loss.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loss.Location = new System.Drawing.Point(200, 60);
            this.txt_Loss.Name = "txt_Loss";
            this.txt_Loss.ReadOnly = true;
            this.txt_Loss.Size = new System.Drawing.Size(83, 25);
            this.txt_Loss.TabIndex = 5;
            this.txt_Loss.Text = "0";
            this.txt_Loss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_loss
            // 
            this.lbl_loss.AutoSize = true;
            this.lbl_loss.Location = new System.Drawing.Point(161, 63);
            this.lbl_loss.Name = "lbl_loss";
            this.lbl_loss.Size = new System.Drawing.Size(33, 15);
            this.lbl_loss.TabIndex = 4;
            this.lbl_loss.Text = "Loss";
            // 
            // txt_Step
            // 
            this.txt_Step.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Step.Location = new System.Drawing.Point(67, 60);
            this.txt_Step.Name = "txt_Step";
            this.txt_Step.ReadOnly = true;
            this.txt_Step.Size = new System.Drawing.Size(83, 25);
            this.txt_Step.TabIndex = 3;
            this.txt_Step.Text = "0";
            this.txt_Step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Step
            // 
            this.lbl_Step.AutoSize = true;
            this.lbl_Step.Location = new System.Drawing.Point(27, 64);
            this.lbl_Step.Name = "lbl_Step";
            this.lbl_Step.Size = new System.Drawing.Size(32, 15);
            this.lbl_Step.TabIndex = 2;
            this.lbl_Step.Text = "Step";
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
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(67, 25);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(429, 25);
            this.txt_Status.TabIndex = 0;
            // 
            // gbox_accuracy
            // 
            this.gbox_accuracy.Controls.Add(this.lbl_TestAccuracy);
            this.gbox_accuracy.Controls.Add(this.lbl_TrainAccuracy);
            this.gbox_accuracy.Controls.Add(this.pBar_TestAccuracy);
            this.gbox_accuracy.Controls.Add(this.pBar_TrainAccuracy);
            this.gbox_accuracy.Controls.Add(this.lbl_Test);
            this.gbox_accuracy.Controls.Add(this.lbl_Train);
            this.gbox_accuracy.Location = new System.Drawing.Point(256, 120);
            this.gbox_accuracy.Name = "gbox_accuracy";
            this.gbox_accuracy.Size = new System.Drawing.Size(514, 104);
            this.gbox_accuracy.TabIndex = 2;
            this.gbox_accuracy.TabStop = false;
            this.gbox_accuracy.Text = "Accuracy";
            // 
            // lbl_TestAccuracy
            // 
            this.lbl_TestAccuracy.AutoSize = true;
            this.lbl_TestAccuracy.Location = new System.Drawing.Point(461, 66);
            this.lbl_TestAccuracy.Name = "lbl_TestAccuracy";
            this.lbl_TestAccuracy.Size = new System.Drawing.Size(30, 15);
            this.lbl_TestAccuracy.TabIndex = 11;
            this.lbl_TestAccuracy.Text = "0 %";
            this.lbl_TestAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TrainAccuracy
            // 
            this.lbl_TrainAccuracy.AutoSize = true;
            this.lbl_TrainAccuracy.Location = new System.Drawing.Point(461, 31);
            this.lbl_TrainAccuracy.Name = "lbl_TrainAccuracy";
            this.lbl_TrainAccuracy.Size = new System.Drawing.Size(30, 15);
            this.lbl_TrainAccuracy.TabIndex = 10;
            this.lbl_TrainAccuracy.Text = "0 %";
            this.lbl_TrainAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBar_TestAccuracy
            // 
            this.pBar_TestAccuracy.Location = new System.Drawing.Point(67, 63);
            this.pBar_TestAccuracy.Maximum = 1000;
            this.pBar_TestAccuracy.Name = "pBar_TestAccuracy";
            this.pBar_TestAccuracy.Size = new System.Drawing.Size(378, 23);
            this.pBar_TestAccuracy.TabIndex = 9;
            // 
            // pBar_TrainAccuracy
            // 
            this.pBar_TrainAccuracy.Location = new System.Drawing.Point(67, 29);
            this.pBar_TrainAccuracy.Maximum = 1000;
            this.pBar_TrainAccuracy.Name = "pBar_TrainAccuracy";
            this.pBar_TrainAccuracy.Size = new System.Drawing.Size(378, 23);
            this.pBar_TrainAccuracy.TabIndex = 8;
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.Location = new System.Drawing.Point(26, 66);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(31, 15);
            this.lbl_Test.TabIndex = 7;
            this.lbl_Test.Text = "Test";
            // 
            // lbl_Train
            // 
            this.lbl_Train.AutoSize = true;
            this.lbl_Train.Location = new System.Drawing.Point(21, 31);
            this.lbl_Train.Name = "lbl_Train";
            this.lbl_Train.Size = new System.Drawing.Size(38, 15);
            this.lbl_Train.TabIndex = 6;
            this.lbl_Train.Text = "Train";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbox_accuracy);
            this.Controls.Add(this.gbox_Message);
            this.Controls.Add(this.TrainingSetting);
            this.Name = "MainForm";
            this.Text = "MnistDemoWithGUI";
            this.TrainingSetting.ResumeLayout(false);
            this.TrainingSetting.PerformLayout();
            this.gbox_Message.ResumeLayout(false);
            this.gbox_Message.PerformLayout();
            this.gbox_accuracy.ResumeLayout(false);
            this.gbox_accuracy.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_Loss;
        private System.Windows.Forms.Label lbl_loss;
        private System.Windows.Forms.GroupBox gbox_accuracy;
        private System.Windows.Forms.ProgressBar pBar_TestAccuracy;
        private System.Windows.Forms.ProgressBar pBar_TrainAccuracy;
        private System.Windows.Forms.Label lbl_Test;
        private System.Windows.Forms.Label lbl_Train;
        private System.Windows.Forms.TextBox txt_ExecutionTime;
        private System.Windows.Forms.Label lbl_OperationTime;
        private System.Windows.Forms.Label lbl_TestAccuracy;
        private System.Windows.Forms.Label lbl_TrainAccuracy;
    }
}

