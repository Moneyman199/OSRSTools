namespace OSRSTools
{
    partial class MainForm
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
            this.pingTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pingTab
            // 
            this.pingTab.Controls.Add(this.tabPage1);
            this.pingTab.Location = new System.Drawing.Point(12, 99);
            this.pingTab.Name = "pingTab";
            this.pingTab.SelectedIndex = 0;
            this.pingTab.Size = new System.Drawing.Size(658, 520);
            this.pingTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World Ping";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 631);
            this.Controls.Add(this.pingTab);
            this.Name = "MainForm";
            this.Text = "OSRS Tools";
            this.pingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pingTab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

