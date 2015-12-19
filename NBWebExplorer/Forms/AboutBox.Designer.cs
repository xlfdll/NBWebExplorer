namespace NBWebExplorer
{
    partial class AboutBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.nbImageList = new System.Windows.Forms.ImageList(this.components);
            this.nbTimer = new System.Windows.Forms.Timer(this.components);
            this.nbPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productVersionLabel = new System.Windows.Forms.Label();
            this.productCopyrightLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.nbTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ieVersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbPictureBox)).BeginInit();
            this.nbTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbImageList
            // 
            this.nbImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nbImageList.ImageStream")));
            this.nbImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.nbImageList.Images.SetKeyName(0, "NB-WE.png");
            this.nbImageList.Images.SetKeyName(1, "NB-vv.png");
            this.nbImageList.Images.SetKeyName(2, "NB-^^.png");
            this.nbImageList.Images.SetKeyName(3, "NB.png");
            this.nbImageList.Images.SetKeyName(4, "fkulc.jpg");
            // 
            // nbTimer
            // 
            this.nbTimer.Enabled = true;
            this.nbTimer.Interval = 1000;
            this.nbTimer.Tick += new System.EventHandler(this.nbTimer_Tick);
            // 
            // nbPictureBox
            // 
            resources.ApplyResources(this.nbPictureBox, "nbPictureBox");
            this.nbPictureBox.Name = "nbPictureBox";
            this.nbPictureBox.TabStop = false;
            this.nbPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nbPictureBox_MouseClick);
            this.nbPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nbPictureBox_MouseDoubleClick);
            // 
            // productNameLabel
            // 
            resources.ApplyResources(this.productNameLabel, "productNameLabel");
            this.productNameLabel.Name = "productNameLabel";
            // 
            // productVersionLabel
            // 
            resources.ApplyResources(this.productVersionLabel, "productVersionLabel");
            this.productVersionLabel.Name = "productVersionLabel";
            // 
            // productCopyrightLabel
            // 
            resources.ApplyResources(this.productCopyrightLabel, "productCopyrightLabel");
            this.productCopyrightLabel.Name = "productCopyrightLabel";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nbTableLayoutPanel
            // 
            resources.ApplyResources(this.nbTableLayoutPanel, "nbTableLayoutPanel");
            this.nbTableLayoutPanel.Controls.Add(this.ieVersionLabel, 0, 3);
            this.nbTableLayoutPanel.Controls.Add(this.productNameLabel, 0, 1);
            this.nbTableLayoutPanel.Controls.Add(this.productVersionLabel, 0, 2);
            this.nbTableLayoutPanel.Controls.Add(this.okButton, 0, 5);
            this.nbTableLayoutPanel.Controls.Add(this.nbPictureBox, 0, 0);
            this.nbTableLayoutPanel.Controls.Add(this.productCopyrightLabel, 0, 4);
            this.nbTableLayoutPanel.Name = "nbTableLayoutPanel";
            // 
            // ieVersionLabel
            // 
            resources.ApplyResources(this.ieVersionLabel, "ieVersionLabel");
            this.ieVersionLabel.Name = "ieVersionLabel";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nbTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbPictureBox)).EndInit();
            this.nbTableLayoutPanel.ResumeLayout(false);
            this.nbTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList nbImageList;
        private System.Windows.Forms.Timer nbTimer;
        private System.Windows.Forms.PictureBox nbPictureBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productVersionLabel;
        private System.Windows.Forms.Label productCopyrightLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel nbTableLayoutPanel;
        private System.Windows.Forms.Label ieVersionLabel;
    }
}