namespace MainCalculateForm
{
    partial class MultipleNumbers
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
            this.lbl_MultipleResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MultipleResult
            // 
            this.lbl_MultipleResult.AutoSize = true;
            this.lbl_MultipleResult.Location = new System.Drawing.Point(52, 147);
            this.lbl_MultipleResult.Name = "lbl_MultipleResult";
            this.lbl_MultipleResult.Size = new System.Drawing.Size(0, 13);
            this.lbl_MultipleResult.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result : ";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(64, 110);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 17;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Formula : ";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(39, 84);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 15;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(39, 57);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 14;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(39, 31);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "c : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "b : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "a : ";
            // 
            // MultipleNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_MultipleResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MultipleNumbers";
            this.Size = new System.Drawing.Size(160, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MultipleResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
