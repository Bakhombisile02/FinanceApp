namespace FinanceApp
{
    partial class FinanceUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stockGraph = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChartStock = new LiveCharts.Wpf.CartesianChart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxValues = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnYahoo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxMovingAverage = new System.Windows.Forms.CheckBox();
            this.numericMA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExchage = new System.Windows.Forms.TextBox();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericMA)).BeginInit();
            this.SuspendLayout();
            // 
            // stockGraph
            // 
            this.stockGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGraph.Location = new System.Drawing.Point(2, 9);
            this.stockGraph.Margin = new System.Windows.Forms.Padding(2);
            this.stockGraph.Name = "stockGraph";
            this.stockGraph.Size = new System.Drawing.Size(1035, 292);
            this.stockGraph.TabIndex = 0;
            this.stockGraph.Text = "stockGraph";
            this.stockGraph.Child = this.cartesianChartStock;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(518, 205);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // checkBoxValues
            // 
            this.checkBoxValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxValues.AutoSize = true;
            this.checkBoxValues.Location = new System.Drawing.Point(527, 306);
            this.checkBoxValues.Name = "checkBoxValues";
            this.checkBoxValues.Size = new System.Drawing.Size(157, 27);
            this.checkBoxValues.TabIndex = 2;
            this.checkBoxValues.Text = "Show Values in Text Box";
            this.checkBoxValues.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(939, 458);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 52);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnYahoo
            // 
            this.btnYahoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYahoo.Location = new System.Drawing.Point(837, 457);
            this.btnYahoo.Name = "btnYahoo";
            this.btnYahoo.Size = new System.Drawing.Size(96, 53);
            this.btnYahoo.TabIndex = 4;
            this.btnYahoo.Text = "Yahoo";
            this.btnYahoo.UseVisualStyleBackColor = true;
            this.btnYahoo.Click += new System.EventHandler(this.btnYahoo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(527, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 53);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovingAverage
            // 
            this.checkBoxMovingAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMovingAverage.AutoSize = true;
            this.checkBoxMovingAverage.Location = new System.Drawing.Point(690, 306);
            this.checkBoxMovingAverage.Name = "checkBoxMovingAverage";
            this.checkBoxMovingAverage.Size = new System.Drawing.Size(117, 27);
            this.checkBoxMovingAverage.TabIndex = 6;
            this.checkBoxMovingAverage.Text = "Moving Average";
            this.checkBoxMovingAverage.UseVisualStyleBackColor = true;
            // 
            // numericMA
            // 
            this.numericMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericMA.Location = new System.Drawing.Point(527, 431);
            this.numericMA.Name = "numericMA";
            this.numericMA.Size = new System.Drawing.Size(120, 20);
            this.numericMA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Moving Average Value";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSymbol.Location = new System.Drawing.Point(571, 339);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtSymbol.TabIndex = 9;
            // 
            // lblSymbol
            // 
            this.lblSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(527, 342);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(44, 13);
            this.lblSymbol.TabIndex = 10;
            this.lblSymbol.Text = "Symbol:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exchange:";
            // 
            // txtExchage
            // 
            this.txtExchage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExchage.Location = new System.Drawing.Point(584, 366);
            this.txtExchage.Name = "txtExchage";
            this.txtExchage.Size = new System.Drawing.Size(87, 20);
            this.txtExchage.TabIndex = 12;
            // 
            // startPicker
            // 
            this.startPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startPicker.Location = new System.Drawing.Point(753, 339);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(200, 20);
            this.startPicker.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "End Date:";
            // 
            // EndPicker
            // 
            this.EndPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndPicker.Location = new System.Drawing.Point(753, 369);
            this.EndPicker.Name = "EndPicker";
            this.EndPicker.Size = new System.Drawing.Size(200, 20);
            this.EndPicker.TabIndex = 16;
            // 
            // FinanceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.txtExchage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericMA);
            this.Controls.Add(this.checkBoxMovingAverage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnYahoo);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.checkBoxValues);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stockGraph);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FinanceUI";
            this.Size = new System.Drawing.Size(1038, 524);
            ((System.ComponentModel.ISupportInitialize)(this.numericMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost stockGraph;
        private LiveCharts.Wpf.CartesianChart cartesianChartStock;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxValues;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnYahoo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBoxMovingAverage;
        private System.Windows.Forms.NumericUpDown numericMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExchage;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndPicker;
    }
}
