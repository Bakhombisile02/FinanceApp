namespace FinanceApp
{
    partial class Class3x_1
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
            this.Graph3x = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.txtBoxXvalue = new System.Windows.Forms.TextBox();
            this.richTxtBoxIterations = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit3x = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Graph3x
            // 
            this.Graph3x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph3x.Location = new System.Drawing.Point(8, 10);
            this.Graph3x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Graph3x.Name = "Graph3x";
            this.Graph3x.Size = new System.Drawing.Size(828, 309);
            this.Graph3x.TabIndex = 0;
            this.Graph3x.Text = "elementHost1";
            this.Graph3x.Child = this.cartesianChart1;
            // 
            // txtBoxXvalue
            // 
            this.txtBoxXvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxXvalue.Location = new System.Drawing.Point(595, 383);
            this.txtBoxXvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxXvalue.Name = "txtBoxXvalue";
            this.txtBoxXvalue.Size = new System.Drawing.Size(152, 20);
            this.txtBoxXvalue.TabIndex = 1;
            this.txtBoxXvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber);
            // 
            // richTxtBoxIterations
            // 
            this.richTxtBoxIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTxtBoxIterations.Location = new System.Drawing.Point(8, 333);
            this.richTxtBoxIterations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtBoxIterations.Name = "richTxtBoxIterations";
            this.richTxtBoxIterations.Size = new System.Drawing.Size(347, 141);
            this.richTxtBoxIterations.TabIndex = 2;
            this.richTxtBoxIterations.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X=";
            // 
            // btnSubmit3x
            // 
            this.btnSubmit3x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit3x.Location = new System.Drawing.Point(671, 430);
            this.btnSubmit3x.Name = "btnSubmit3x";
            this.btnSubmit3x.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit3x.TabIndex = 4;
            this.btnSubmit3x.Text = "Submit";
            this.btnSubmit3x.UseVisualStyleBackColor = true;
            this.btnSubmit3x.Click += new System.EventHandler(this.btnSubmitClicked);
            // 
            // Class3x_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit3x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtBoxIterations);
            this.Controls.Add(this.txtBoxXvalue);
            this.Controls.Add(this.Graph3x);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Class3x_1";
            this.Size = new System.Drawing.Size(842, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost Graph3x;
        private System.Windows.Forms.TextBox txtBoxXvalue;
        private System.Windows.Forms.RichTextBox richTxtBoxIterations;
        private System.Windows.Forms.Label label1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnSubmit3x;
    }
}
