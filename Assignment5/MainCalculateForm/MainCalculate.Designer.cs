namespace MainCalculateForm
{
    partial class MainCalculate
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
            this.multipleNumbers1 = new MainCalculateForm.MultipleNumbers();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc2DevCalc1 = new System.Windows.Forms.Button();
            this.lbl_relCalc2DevCalc1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multipleNumbers1
            // 
            this.multipleNumbers1.Location = new System.Drawing.Point(190, 12);
            this.multipleNumbers1.Name = "multipleNumbers1";
            this.multipleNumbers1.Size = new System.Drawing.Size(160, 171);
            this.multipleNumbers1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A * B * C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calc2 / Calc1 : ";
            // 
            // btnCalc2DevCalc1
            // 
            this.btnCalc2DevCalc1.Location = new System.Drawing.Point(175, 192);
            this.btnCalc2DevCalc1.Name = "btnCalc2DevCalc1";
            this.btnCalc2DevCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc2DevCalc1.TabIndex = 5;
            this.btnCalc2DevCalc1.Text = "Calculate";
            this.btnCalc2DevCalc1.UseVisualStyleBackColor = true;
            this.btnCalc2DevCalc1.Click += new System.EventHandler(this.btnCalc2DevCalc1_Click);
            // 
            // lbl_relCalc2DevCalc1
            // 
            this.lbl_relCalc2DevCalc1.AutoSize = true;
            this.lbl_relCalc2DevCalc1.Location = new System.Drawing.Point(84, 197);
            this.lbl_relCalc2DevCalc1.Name = "lbl_relCalc2DevCalc1";
            this.lbl_relCalc2DevCalc1.Size = new System.Drawing.Size(0, 13);
            this.lbl_relCalc2DevCalc1.TabIndex = 6;
            // 
            // MainCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 315);
            this.Controls.Add(this.lbl_relCalc2DevCalc1);
            this.Controls.Add(this.btnCalc2DevCalc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multipleNumbers1);
            this.Name = "MainCalculate";
            this.Controls.SetChildIndex(this.multipleNumbers1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnCalc2DevCalc1, 0);
            this.Controls.SetChildIndex(this.lbl_relCalc2DevCalc1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MultipleNumbers multipleNumbers1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc2DevCalc1;
        private System.Windows.Forms.Label lbl_relCalc2DevCalc1;
    }
}
