namespace MoneyConvertToCheck
{
    partial class Result
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.labelReciveDecimal = new Sunny.UI.UILabel();
            this.labelReciveDate = new Sunny.UI.UILabel();
            this.labelReciveName = new Sunny.UI.UILabel();
            this.labelReciveAmount = new Sunny.UI.UILabel();
            this.menuStrip1.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.BackgroundImage = global::MoneyConvertToCheck.Properties.Resources.Scan_20230416;
            this.uiTitlePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiTitlePanel1.Controls.Add(this.labelReciveDecimal);
            this.uiTitlePanel1.Controls.Add(this.labelReciveDate);
            this.uiTitlePanel1.Controls.Add(this.labelReciveName);
            this.uiTitlePanel1.Controls.Add(this.labelReciveAmount);
            this.uiTitlePanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTitlePanel1.Location = new System.Drawing.Point(20, 65);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 54, 0, 0);
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(1328, 526);
            this.uiTitlePanel1.TabIndex = 3;
            this.uiTitlePanel1.Text = "uiTitlePanel1";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelReciveDecimal
            // 
            this.labelReciveDecimal.BackColor = System.Drawing.Color.Transparent;
            this.labelReciveDecimal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.labelReciveDecimal.Location = new System.Drawing.Point(645, 78);
            this.labelReciveDecimal.Name = "labelReciveDecimal";
            this.labelReciveDecimal.Size = new System.Drawing.Size(184, 33);
            this.labelReciveDecimal.TabIndex = 3;
            this.labelReciveDecimal.Text = "ReciveDecimal";
            this.labelReciveDecimal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelReciveDecimal.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelReciveDate
            // 
            this.labelReciveDate.BackColor = System.Drawing.Color.Transparent;
            this.labelReciveDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.labelReciveDate.Location = new System.Drawing.Point(641, 47);
            this.labelReciveDate.Name = "labelReciveDate";
            this.labelReciveDate.Size = new System.Drawing.Size(184, 33);
            this.labelReciveDate.TabIndex = 2;
            this.labelReciveDate.Text = "ReciveDate";
            this.labelReciveDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelReciveDate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelReciveName
            // 
            this.labelReciveName.BackColor = System.Drawing.Color.Transparent;
            this.labelReciveName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.labelReciveName.Location = new System.Drawing.Point(135, 78);
            this.labelReciveName.Name = "labelReciveName";
            this.labelReciveName.Size = new System.Drawing.Size(377, 36);
            this.labelReciveName.TabIndex = 0;
            this.labelReciveName.Text = "ReciveName";
            this.labelReciveName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelReciveName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelReciveAmount
            // 
            this.labelReciveAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelReciveAmount.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.labelReciveAmount.Location = new System.Drawing.Point(100, 126);
            this.labelReciveAmount.Name = "labelReciveAmount";
            this.labelReciveAmount.Size = new System.Drawing.Size(960, 24);
            this.labelReciveAmount.TabIndex = 1;
            this.labelReciveAmount.Text = "ReciveAmount";
            this.labelReciveAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelReciveAmount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 628);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uiTitlePanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Result";
            this.Text = "Check writing instrument - By Duke Hsu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel labelReciveName;
        private Sunny.UI.UILabel labelReciveAmount;
        private Sunny.UI.UILabel labelReciveDate;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Sunny.UI.UILabel labelReciveDecimal;
    }
}