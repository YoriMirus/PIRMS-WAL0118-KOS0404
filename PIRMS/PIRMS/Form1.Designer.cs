namespace PIRMS
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddPortButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.BaudRateTB = new System.Windows.Forms.TextBox();
            this.ComPortSelectCB = new System.Windows.Forms.ComboBox();
            this.RemovePortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddedPortsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.DataChart);
            this.splitContainer1.Panel1MinSize = 310;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.ExportButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClearButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddPortButton);
            this.splitContainer1.Panel2.Controls.Add(this.StopButton);
            this.splitContainer1.Panel2.Controls.Add(this.StartButton);
            this.splitContainer1.Panel2.Controls.Add(this.BaudRateTB);
            this.splitContainer1.Panel2.Controls.Add(this.ComPortSelectCB);
            this.splitContainer1.Panel2.Controls.Add(this.RemovePortButton);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.AddedPortsLB);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2MinSize = 125;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataChart
            // 
            this.DataChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea2.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DataChart.Legends.Add(legend2);
            this.DataChart.Location = new System.Drawing.Point(0, 0);
            this.DataChart.Name = "DataChart";
            this.DataChart.Size = new System.Drawing.Size(800, 326);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "chart1";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(542, 27);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(120, 40);
            this.ExportButton.TabIndex = 14;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(668, 27);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 40);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddPortButton
            // 
            this.AddPortButton.Location = new System.Drawing.Point(155, 36);
            this.AddPortButton.Name = "AddPortButton";
            this.AddPortButton.Size = new System.Drawing.Size(75, 23);
            this.AddPortButton.TabIndex = 10;
            this.AddPortButton.Text = "Přidat";
            this.AddPortButton.UseVisualStyleBackColor = true;
            this.AddPortButton.Click += new System.EventHandler(this.AddPortButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(668, 83);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(120, 40);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(542, 83);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 40);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BaudRateTB
            // 
            this.BaudRateTB.Location = new System.Drawing.Point(72, 68);
            this.BaudRateTB.Name = "BaudRateTB";
            this.BaudRateTB.Size = new System.Drawing.Size(74, 20);
            this.BaudRateTB.TabIndex = 2;
            this.BaudRateTB.Text = "9600";
            // 
            // ComPortSelectCB
            // 
            this.ComPortSelectCB.FormattingEnabled = true;
            this.ComPortSelectCB.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComPortSelectCB.Location = new System.Drawing.Point(72, 39);
            this.ComPortSelectCB.Name = "ComPortSelectCB";
            this.ComPortSelectCB.Size = new System.Drawing.Size(74, 21);
            this.ComPortSelectCB.TabIndex = 1;
            // 
            // RemovePortButton
            // 
            this.RemovePortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePortButton.Location = new System.Drawing.Point(456, 28);
            this.RemovePortButton.Name = "RemovePortButton";
            this.RemovePortButton.Size = new System.Drawing.Size(75, 23);
            this.RemovePortButton.TabIndex = 11;
            this.RemovePortButton.Text = "Smazat";
            this.RemovePortButton.UseVisualStyleBackColor = true;
            this.RemovePortButton.Click += new System.EventHandler(this.RemovePortButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bound-rate:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM:";
            // 
            // AddedPortsLB
            // 
            this.AddedPortsLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddedPortsLB.FormattingEnabled = true;
            this.AddedPortsLB.Location = new System.Drawing.Point(265, 28);
            this.AddedPortsLB.Name = "AddedPortsLB";
            this.AddedPortsLB.Size = new System.Drawing.Size(185, 56);
            this.AddedPortsLB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nastavení portu:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(262, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seznam portů:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(812, 478);
            this.Name = "Form1";
            this.Text = "PIRMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BaudRateTB;
        private System.Windows.Forms.ComboBox ComPortSelectCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AddedPortsLB;
        private System.Windows.Forms.Button AddPortButton;
        private System.Windows.Forms.Button RemovePortButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ExportButton;
    }
}

