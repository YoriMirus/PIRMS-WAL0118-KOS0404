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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddPortButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.BaudRateTB = new System.Windows.Forms.TextBox();
            this.ComPortSelectCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddedPortsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
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
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.StartButton);
            this.splitContainer1.Panel2.Controls.Add(this.StopButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddPortButton);
            this.splitContainer1.Panel2.Controls.Add(this.BaudRateTB);
            this.splitContainer1.Panel2.Controls.Add(this.ComPortSelectCB);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.AddedPortsLB);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1915, 1072);
            this.splitContainer1.SplitterDistance = 970;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataChart
            // 
            chartArea1.AxisX.Maximum = 20000D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 1500000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea1);
            this.DataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(0, 0);
            this.DataChart.Margin = new System.Windows.Forms.Padding(6);
            this.DataChart.MinimumSize = new System.Drawing.Size(2300, 0);
            this.DataChart.Name = "DataChart";
            this.DataChart.Size = new System.Drawing.Size(2300, 970);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "chart1";
            // 
            // AddPortButton
            // 
            this.AddPortButton.Location = new System.Drawing.Point(310, 69);
            this.AddPortButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddPortButton.Name = "AddPortButton";
            this.AddPortButton.Size = new System.Drawing.Size(150, 44);
            this.AddPortButton.TabIndex = 10;
            this.AddPortButton.Text = "Přidat";
            this.AddPortButton.UseVisualStyleBackColor = true;
            this.AddPortButton.Click += new System.EventHandler(this.AddPortButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(1408, 42);
            this.StopButton.Margin = new System.Windows.Forms.Padding(6);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(240, 77);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(1156, 42);
            this.StartButton.Margin = new System.Windows.Forms.Padding(6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(240, 77);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BaudRateTB
            // 
            this.BaudRateTB.Location = new System.Drawing.Point(144, 131);
            this.BaudRateTB.Margin = new System.Windows.Forms.Padding(6);
            this.BaudRateTB.Name = "BaudRateTB";
            this.BaudRateTB.Size = new System.Drawing.Size(144, 31);
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
            this.ComPortSelectCB.Location = new System.Drawing.Point(144, 75);
            this.ComPortSelectCB.Margin = new System.Windows.Forms.Padding(6);
            this.ComPortSelectCB.Name = "ComPortSelectCB";
            this.ComPortSelectCB.Size = new System.Drawing.Size(144, 33);
            this.ComPortSelectCB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bound-rate:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM:";
            // 
            // AddedPortsLB
            // 
            this.AddedPortsLB.FormattingEnabled = true;
            this.AddedPortsLB.ItemHeight = 25;
            this.AddedPortsLB.Location = new System.Drawing.Point(530, 54);
            this.AddedPortsLB.Margin = new System.Windows.Forms.Padding(6);
            this.AddedPortsLB.Name = "AddedPortsLB";
            this.AddedPortsLB.Size = new System.Drawing.Size(366, 79);
            this.AddedPortsLB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nastavení portu:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(524, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seznam portů:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1660, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 77);
            this.button2.TabIndex = 15;
            this.button2.Text = "Smazat port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemovePortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1915, 1072);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1598, 854);
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
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AddedPortsLB;
        private System.Windows.Forms.Button AddPortButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

