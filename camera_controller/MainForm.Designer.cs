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
            this.PortNameTextBox = new System.Windows.Forms.TextBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.EnableServerBtn = new System.Windows.Forms.Button();
            this.CameraUpButton = new System.Windows.Forms.Button();
            this.CameraDownButton = new System.Windows.Forms.Button();
            this.CameraLeftButton = new System.Windows.Forms.Button();
            this.CameraRightButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.EnableKeyPadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCamButton
            // 
            this.OpenCamButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenCamButton.FlatAppearance.BorderSize = 0;
            this.OpenCamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCamButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenCamButton.Location = new System.Drawing.Point(12, 288);
            this.OpenCamButton.Name = "OpenCamButton";
            this.OpenCamButton.Size = new System.Drawing.Size(84, 30);
            this.OpenCamButton.TabIndex = 0;
            this.OpenCamButton.Text = "Open Cam";
            this.OpenCamButton.UseVisualStyleBackColor = false;
            this.OpenCamButton.Click += new System.EventHandler(this.OpenCamButton_Click);
            // 
            // PortNameTextBox
            // 
            this.PortNameTextBox.Location = new System.Drawing.Point(102, 294);
            this.PortNameTextBox.Name = "PortNameTextBox";
            this.PortNameTextBox.Size = new System.Drawing.Size(46, 21);
            this.PortNameTextBox.TabIndex = 3;
            this.PortNameTextBox.Text = "COM";
            // 
            // openPortButton
            // 
            this.openPortButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.openPortButton.FlatAppearance.BorderSize = 0;
            this.openPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPortButton.ForeColor = System.Drawing.SystemColors.Control;
            this.openPortButton.Location = new System.Drawing.Point(154, 288);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(85, 30);
            this.openPortButton.TabIndex = 4;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = false;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(9, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Initialised";
            // 
            // EnableServerBtn
            // 
            this.EnableServerBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnableServerBtn.Enabled = false;
            this.EnableServerBtn.FlatAppearance.BorderSize = 0;
            this.EnableServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableServerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EnableServerBtn.Location = new System.Drawing.Point(12, 325);
            this.EnableServerBtn.Name = "EnableServerBtn";
            this.EnableServerBtn.Size = new System.Drawing.Size(135, 27);
            this.EnableServerBtn.TabIndex = 6;
            this.EnableServerBtn.Text = "EnableServer";
            this.EnableServerBtn.UseVisualStyleBackColor = false;
            this.EnableServerBtn.Click += new System.EventHandler(this.SendSthButton_Click);
            // 
            // CameraUpButton
            // 
            this.CameraUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CameraUpButton.Enabled = false;
            this.CameraUpButton.FlatAppearance.BorderSize = 0;
            this.CameraUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraUpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CameraUpButton.Location = new System.Drawing.Point(225, 325);
            this.CameraUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.CameraUpButton.Name = "CameraUpButton";
            this.CameraUpButton.Size = new System.Drawing.Size(86, 27);
            this.CameraUpButton.TabIndex = 7;
            this.CameraUpButton.Text = "Up";
            this.CameraUpButton.UseVisualStyleBackColor = false;
            this.CameraUpButton.Click += new System.EventHandler(this.CameraUpButton_Click);
            // 
            // CameraDownButton
            // 
            this.CameraDownButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CameraDownButton.Enabled = false;
            this.CameraDownButton.FlatAppearance.BorderSize = 0;
            this.CameraDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraDownButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CameraDownButton.Location = new System.Drawing.Point(245, 356);
            this.CameraDownButton.Margin = new System.Windows.Forms.Padding(2);
            this.CameraDownButton.Name = "CameraDownButton";
            this.CameraDownButton.Size = new System.Drawing.Size(47, 27);
            this.CameraDownButton.TabIndex = 8;
            this.CameraDownButton.Text = "Down";
            this.CameraDownButton.UseVisualStyleBackColor = false;
            this.CameraDownButton.Click += new System.EventHandler(this.CameraDownButton_Click);
            // 
            // CameraLeftButton
            // 
            this.CameraLeftButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CameraLeftButton.Enabled = false;
            this.CameraLeftButton.FlatAppearance.BorderSize = 0;
            this.CameraLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraLeftButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CameraLeftButton.Location = new System.Drawing.Point(195, 356);
            this.CameraLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.CameraLeftButton.Name = "CameraLeftButton";
            this.CameraLeftButton.Size = new System.Drawing.Size(46, 27);
            this.CameraLeftButton.TabIndex = 9;
            this.CameraLeftButton.Text = "Left";
            this.CameraLeftButton.UseVisualStyleBackColor = false;
            this.CameraLeftButton.Click += new System.EventHandler(this.CameraLeftButton_Click);
            // 
            // CameraRightButton
            // 
            this.CameraRightButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CameraRightButton.Enabled = false;
            this.CameraRightButton.FlatAppearance.BorderSize = 0;
            this.CameraRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraRightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CameraRightButton.Location = new System.Drawing.Point(296, 356);
            this.CameraRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.CameraRightButton.Name = "CameraRightButton";
            this.CameraRightButton.Size = new System.Drawing.Size(45, 27);
            this.CameraRightButton.TabIndex = 10;
            this.CameraRightButton.Text = "Right";
            this.CameraRightButton.UseVisualStyleBackColor = false;
            this.CameraRightButton.Click += new System.EventHandler(this.CameraRightButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeBtn.BackgroundImage = global::camera_controller.Properties.Resources.minimize;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeBtn.Location = new System.Drawing.Point(286, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 22);
            this.MinimizeBtn.TabIndex = 12;
            this.MinimizeBtn.Text = " ";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseBtn.BackgroundImage = global::camera_controller.Properties.Resources.close_btn;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseBtn.Location = new System.Drawing.Point(317, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 22);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = " ";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CamImageBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CamImageBox.Location = new System.Drawing.Point(12, 25);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(330, 257);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // EnableKeyPadBtn
            // 
            this.EnableKeyPadBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnableKeyPadBtn.Enabled = false;
            this.EnableKeyPadBtn.FlatAppearance.BorderSize = 0;
            this.EnableKeyPadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableKeyPadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EnableKeyPadBtn.Location = new System.Drawing.Point(12, 358);
            this.EnableKeyPadBtn.Name = "EnableKeyPadBtn";
            this.EnableKeyPadBtn.Size = new System.Drawing.Size(135, 27);
            this.EnableKeyPadBtn.TabIndex = 13;
            this.EnableKeyPadBtn.Text = "EnableKeyPad";
            this.EnableKeyPadBtn.UseVisualStyleBackColor = false;
            this.EnableKeyPadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 393);
            this.Controls.Add(this.EnableKeyPadBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
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
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button EnableKeyPadBtn;
    }
}

