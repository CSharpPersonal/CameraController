namespace camera_controller
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenCamButton = new System.Windows.Forms.Button();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.PortNameTextBox = new System.Windows.Forms.TextBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.EnableServerBtn = new System.Windows.Forms.Button();
            this.CameraUpButton = new System.Windows.Forms.Button();
            this.CameraDownButton = new System.Windows.Forms.Button();
            this.CameraLeftButton = new System.Windows.Forms.Button();
            this.CameraRightButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCamButton
            // 
            this.OpenCamButton.Location = new System.Drawing.Point(12, 288);
            this.OpenCamButton.Name = "OpenCamButton";
            this.OpenCamButton.Size = new System.Drawing.Size(84, 30);
            this.OpenCamButton.TabIndex = 0;
            this.OpenCamButton.Text = "Open Cam";
            this.OpenCamButton.UseVisualStyleBackColor = true;
            this.OpenCamButton.Click += new System.EventHandler(this.OpenCamButton_Click);
            // 
            // CamImageBox
            // 
            this.CamImageBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CamImageBox.Location = new System.Drawing.Point(12, 25);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(330, 257);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // PortNameTextBox
            // 
            this.PortNameTextBox.Location = new System.Drawing.Point(102, 294);
            this.PortNameTextBox.Name = "PortNameTextBox";
            this.PortNameTextBox.Size = new System.Drawing.Size(46, 20);
            this.PortNameTextBox.TabIndex = 3;
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(154, 288);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(85, 30);
            this.openPortButton.TabIndex = 4;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(9, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(50, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Initialised";
            // 
            // EnableServerBtn
            // 
            this.EnableServerBtn.Location = new System.Drawing.Point(13, 325);
            this.EnableServerBtn.Name = "EnableServerBtn";
            this.EnableServerBtn.Size = new System.Drawing.Size(135, 27);
            this.EnableServerBtn.TabIndex = 6;
            this.EnableServerBtn.Text = "EnableServer";
            this.EnableServerBtn.UseVisualStyleBackColor = true;
            this.EnableServerBtn.Click += new System.EventHandler(this.SendSthButton_Click);
            // 
            // CameraUpButton
            // 
            this.CameraUpButton.Location = new System.Drawing.Point(195, 325);
            this.CameraUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CameraUpButton.Name = "CameraUpButton";
            this.CameraUpButton.Size = new System.Drawing.Size(76, 27);
            this.CameraUpButton.TabIndex = 7;
            this.CameraUpButton.Text = "Up";
            this.CameraUpButton.UseVisualStyleBackColor = true;
            this.CameraUpButton.Click += new System.EventHandler(this.CameraUpButton_Click);
            // 
            // CameraDownButton
            // 
            this.CameraDownButton.Location = new System.Drawing.Point(195, 356);
            this.CameraDownButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CameraDownButton.Name = "CameraDownButton";
            this.CameraDownButton.Size = new System.Drawing.Size(76, 27);
            this.CameraDownButton.TabIndex = 8;
            this.CameraDownButton.Text = "Down";
            this.CameraDownButton.UseVisualStyleBackColor = true;
            this.CameraDownButton.Click += new System.EventHandler(this.CameraDownButton_Click);
            // 
            // CameraLeftButton
            // 
            this.CameraLeftButton.Location = new System.Drawing.Point(112, 356);
            this.CameraLeftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CameraLeftButton.Name = "CameraLeftButton";
            this.CameraLeftButton.Size = new System.Drawing.Size(80, 27);
            this.CameraLeftButton.TabIndex = 9;
            this.CameraLeftButton.Text = "Left";
            this.CameraLeftButton.UseVisualStyleBackColor = true;
            this.CameraLeftButton.Click += new System.EventHandler(this.CameraLeftButton_Click);
            // 
            // CameraRightButton
            // 
            this.CameraRightButton.Location = new System.Drawing.Point(275, 356);
            this.CameraRightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CameraRightButton.Name = "CameraRightButton";
            this.CameraRightButton.Size = new System.Drawing.Size(67, 27);
            this.CameraRightButton.TabIndex = 10;
            this.CameraRightButton.Text = "Right";
            this.CameraRightButton.UseVisualStyleBackColor = true;
            this.CameraRightButton.Click += new System.EventHandler(this.CameraRightButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 393);
            this.Controls.Add(this.CameraRightButton);
            this.Controls.Add(this.CameraLeftButton);
            this.Controls.Add(this.CameraDownButton);
            this.Controls.Add(this.CameraUpButton);
            this.Controls.Add(this.EnableServerBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.PortNameTextBox);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.OpenCamButton);
            this.Name = "MainForm";
            this.Text = "Camera Controller";
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenCamButton;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.TextBox PortNameTextBox;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Button EnableServerBtn;
        private System.Windows.Forms.Button CameraUpButton;
        private System.Windows.Forms.Button CameraDownButton;
        private System.Windows.Forms.Button CameraLeftButton;
        private System.Windows.Forms.Button CameraRightButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label StatusLabel;
    }
}

