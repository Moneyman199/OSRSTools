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
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.orderRadioButton = new System.Windows.Forms.RadioButton();
            this.topWorldsRadioButton = new System.Windows.Forms.RadioButton();
            this.specificRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.specificWorldTextbox = new System.Windows.Forms.TextBox();
            this.resultsView = new System.Windows.Forms.ListView();
            this.worldHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pingTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.resultsView);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.specificWorldTextbox);
            this.tabPage1.Controls.Add(this.allRadioButton);
            this.tabPage1.Controls.Add(this.orderRadioButton);
            this.tabPage1.Controls.Add(this.topWorldsRadioButton);
            this.tabPage1.Controls.Add(this.specificRadioButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World Ping";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(47, 19);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(120, 17);
            this.allRadioButton.TabIndex = 1;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All Worlds (no order)";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderRadioButton
            // 
            this.orderRadioButton.AutoSize = true;
            this.orderRadioButton.Location = new System.Drawing.Point(47, 56);
            this.orderRadioButton.Name = "orderRadioButton";
            this.orderRadioButton.Size = new System.Drawing.Size(117, 17);
            this.orderRadioButton.TabIndex = 2;
            this.orderRadioButton.Text = "All Worlds (ordered)";
            this.orderRadioButton.UseVisualStyleBackColor = true;
            // 
            // topWorldsRadioButton
            // 
            this.topWorldsRadioButton.AutoSize = true;
            this.topWorldsRadioButton.Location = new System.Drawing.Point(47, 92);
            this.topWorldsRadioButton.Name = "topWorldsRadioButton";
            this.topWorldsRadioButton.Size = new System.Drawing.Size(95, 17);
            this.topWorldsRadioButton.TabIndex = 3;
            this.topWorldsRadioButton.Text = "Top 10 Worlds";
            this.topWorldsRadioButton.UseVisualStyleBackColor = true;
            // 
            // specificRadioButton
            // 
            this.specificRadioButton.AutoSize = true;
            this.specificRadioButton.Location = new System.Drawing.Point(47, 127);
            this.specificRadioButton.Name = "specificRadioButton";
            this.specificRadioButton.Size = new System.Drawing.Size(94, 17);
            this.specificRadioButton.TabIndex = 4;
            this.specificRadioButton.Text = "Specific World";
            this.specificRadioButton.UseVisualStyleBackColor = true;
            this.specificRadioButton.CheckedChanged += new System.EventHandler(this.specificRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(76, 192);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 46);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(76, 300);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 46);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // specificWorldTextbox
            // 
            this.specificWorldTextbox.Enabled = false;
            this.specificWorldTextbox.Location = new System.Drawing.Point(147, 127);
            this.specificWorldTextbox.Name = "specificWorldTextbox";
            this.specificWorldTextbox.Size = new System.Drawing.Size(100, 20);
            this.specificWorldTextbox.TabIndex = 5;
            // 
            // resultsView
            // 
            this.resultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.worldHeader,
            this.pingHeader});
            this.resultsView.Location = new System.Drawing.Point(312, 6);
            this.resultsView.MultiSelect = false;
            this.resultsView.Name = "resultsView";
            this.resultsView.Size = new System.Drawing.Size(314, 471);
            this.resultsView.TabIndex = 6;
            this.resultsView.UseCompatibleStateImageBehavior = false;
            this.resultsView.View = System.Windows.Forms.View.Details;
            // 
            // worldHeader
            // 
            this.worldHeader.Text = "World";
            this.worldHeader.Width = 200;
            // 
            // pingHeader
            // 
            this.pingHeader.Text = "Ping (ms)";
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pingTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton orderRadioButton;
        private System.Windows.Forms.RadioButton topWorldsRadioButton;
        private System.Windows.Forms.RadioButton specificRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox specificWorldTextbox;
        private System.Windows.Forms.ListView resultsView;
        private System.Windows.Forms.ColumnHeader worldHeader;
        private System.Windows.Forms.ColumnHeader pingHeader;
    }
}

