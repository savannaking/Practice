namespace RPRactice
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_eval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(49, 12);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(207, 20);
            this.tb_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Comma-delimited list of numbers)";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(49, 104);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(207, 20);
            this.tb_output.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P-value";
            // 
            // b_eval
            // 
            this.b_eval.Location = new System.Drawing.Point(104, 158);
            this.b_eval.Name = "b_eval";
            this.b_eval.Size = new System.Drawing.Size(75, 23);
            this.b_eval.TabIndex = 5;
            this.b_eval.Text = "Evaluate";
            this.b_eval.UseVisualStyleBackColor = true;
            this.b_eval.Click += new System.EventHandler(this.b_eval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 203);
            this.Controls.Add(this.b_eval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_input);
            this.Name = "Form1";
            this.Text = "RPractice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_eval;
    }
}

