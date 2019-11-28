namespace RokuRemote
{
    partial class RokuRemote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbApps = new System.Windows.Forms.ListBox();
            this.btnLaunchApp = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 20);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(123, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 20);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(11, 85);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<---";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(123, 85);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "--->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(67, 29);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(67, 141);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(179, 29);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(50, 20);
            this.btnVolumeUp.TabIndex = 6;
            this.btnVolumeUp.Text = "Vol +";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(179, 59);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(50, 20);
            this.btnVolumeDown.TabIndex = 7;
            this.btnVolumeDown.Text = "Vol -";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(67, 85);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "OK";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbApps
            // 
            this.lbApps.FormattingEnabled = true;
            this.lbApps.Location = new System.Drawing.Point(5, 259);
            this.lbApps.Name = "lbApps";
            this.lbApps.Size = new System.Drawing.Size(224, 251);
            this.lbApps.TabIndex = 9;
            // 
            // btnLaunchApp
            // 
            this.btnLaunchApp.Location = new System.Drawing.Point(149, 233);
            this.btnLaunchApp.Name = "btnLaunchApp";
            this.btnLaunchApp.Size = new System.Drawing.Size(80, 20);
            this.btnLaunchApp.TabIndex = 10;
            this.btnLaunchApp.Text = "Launch App!";
            this.btnLaunchApp.UseVisualStyleBackColor = true;
            this.btnLaunchApp.Click += new System.EventHandler(this.btnLaunchApp_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Location = new System.Drawing.Point(11, 205);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(50, 20);
            this.btnRewind.TabIndex = 11;
            this.btnRewind.Text = "<|<|";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(67, 205);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(50, 20);
            this.btnPlayPause.TabIndex = 12;
            this.btnPlayPause.Text = "|> ||";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnFastForward
            // 
            this.btnFastForward.Location = new System.Drawing.Point(123, 205);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(50, 20);
            this.btnFastForward.TabIndex = 13;
            this.btnFastForward.Text = "|>|>";
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // RokuRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 521);
            this.Controls.Add(this.btnFastForward);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.btnLaunchApp);
            this.Controls.Add(this.lbApps);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Name = "RokuRemote";
            this.Text = "RokuRemote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lbApps;
        private System.Windows.Forms.Button btnLaunchApp;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnFastForward;
    }
}

