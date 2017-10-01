namespace PrimeNumbers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calculationPanel = new System.Windows.Forms.Panel();
            this.graphPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphButton = new System.Windows.Forms.Button();
            this.calculationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(12, 12);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(608, 415);
            this.TextOutput.TabIndex = 0;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 434);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(608, 20);
            this.TextInput.TabIndex = 1;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            this.TextInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextInputEnter);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(527, 460);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 51);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Prime Me Up Daddy";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Made by: Ali Bingol";
            // 
            // calculationPanel
            // 
            this.calculationPanel.Controls.Add(this.chart1);
            this.calculationPanel.Controls.Add(this.graphPanel);
            this.calculationPanel.Controls.Add(this.TextOutput);
            this.calculationPanel.Controls.Add(this.SendButton);
            this.calculationPanel.Controls.Add(this.graphButton);
            this.calculationPanel.Controls.Add(this.TextInput);
            this.calculationPanel.Location = new System.Drawing.Point(0, 0);
            this.calculationPanel.Name = "calculationPanel";
            this.calculationPanel.Size = new System.Drawing.Size(627, 530);
            this.calculationPanel.TabIndex = 4;
            // 
            // graphPanel
            // 
            this.graphPanel.Location = new System.Drawing.Point(111, 12);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(608, 442);
            this.graphPanel.TabIndex = 3;
            this.graphPanel.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(608, 443);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // graphButton
            // 
            this.graphButton.AllowDrop = true;
            this.graphButton.Location = new System.Drawing.Point(428, 461);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(93, 50);
            this.graphButton.TabIndex = 0;
            this.graphButton.Text = "button1";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prime Number Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calculationPanel.ResumeLayout(false);
            this.calculationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel calculationPanel;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.FlowLayoutPanel graphPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

