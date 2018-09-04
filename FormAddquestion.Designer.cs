namespace QickQuiz
{
    partial class FormAddquestion
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxop1 = new System.Windows.Forms.TextBox();
            this.textBoxop2 = new System.Windows.Forms.TextBox();
            this.textBoxop4 = new System.Windows.Forms.TextBox();
            this.textBoxop3 = new System.Windows.Forms.TextBox();
            this.textBoxanswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxQuestion.Location = new System.Drawing.Point(118, 42);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(489, 27);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Enter Question :";
            this.textBoxQuestion.Enter += new System.EventHandler(this.Question);
            this.textBoxQuestion.Leave += new System.EventHandler(this.QuetionEnter);
            // 
            // textBoxop1
            // 
            this.textBoxop1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxop1.Location = new System.Drawing.Point(118, 106);
            this.textBoxop1.Name = "textBoxop1";
            this.textBoxop1.Size = new System.Drawing.Size(222, 20);
            this.textBoxop1.TabIndex = 1;
            this.textBoxop1.Text = "Option 1";
            this.textBoxop1.Enter += new System.EventHandler(this.op1);
            this.textBoxop1.Leave += new System.EventHandler(this.op1ans);
            // 
            // textBoxop2
            // 
            this.textBoxop2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxop2.Location = new System.Drawing.Point(379, 106);
            this.textBoxop2.Name = "textBoxop2";
            this.textBoxop2.Size = new System.Drawing.Size(228, 20);
            this.textBoxop2.TabIndex = 2;
            this.textBoxop2.Text = "Option 2";
            this.textBoxop2.Enter += new System.EventHandler(this.op2);
            this.textBoxop2.Leave += new System.EventHandler(this.op2ans);
            // 
            // textBoxop4
            // 
            this.textBoxop4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxop4.Location = new System.Drawing.Point(379, 182);
            this.textBoxop4.Name = "textBoxop4";
            this.textBoxop4.Size = new System.Drawing.Size(228, 20);
            this.textBoxop4.TabIndex = 3;
            this.textBoxop4.Text = "Option 4";
            this.textBoxop4.Enter += new System.EventHandler(this.op4);
            this.textBoxop4.Leave += new System.EventHandler(this.op4ans);
            // 
            // textBoxop3
            // 
            this.textBoxop3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxop3.Location = new System.Drawing.Point(118, 182);
            this.textBoxop3.Name = "textBoxop3";
            this.textBoxop3.Size = new System.Drawing.Size(222, 20);
            this.textBoxop3.TabIndex = 4;
            this.textBoxop3.Tag = "";
            this.textBoxop3.Text = "Option 3";
            this.textBoxop3.Enter += new System.EventHandler(this.op3);
            this.textBoxop3.Leave += new System.EventHandler(this.op3ans);
            // 
            // textBoxanswer
            // 
            this.textBoxanswer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxanswer.Location = new System.Drawing.Point(258, 236);
            this.textBoxanswer.Name = "textBoxanswer";
            this.textBoxanswer.Size = new System.Drawing.Size(207, 20);
            this.textBoxanswer.TabIndex = 5;
            this.textBoxanswer.Text = "Currect Answer";
            this.textBoxanswer.Enter += new System.EventHandler(this.curand);
            this.textBoxanswer.Leave += new System.EventHandler(this.curandans);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(305, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddquestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxanswer);
            this.Controls.Add(this.textBoxop3);
            this.Controls.Add(this.textBoxop4);
            this.Controls.Add(this.textBoxop2);
            this.Controls.Add(this.textBoxop1);
            this.Controls.Add(this.textBoxQuestion);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "FormAddquestion";
            this.Text = "FormAddquestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxop1;
        private System.Windows.Forms.TextBox textBoxop2;
        private System.Windows.Forms.TextBox textBoxop4;
        private System.Windows.Forms.TextBox textBoxop3;
        private System.Windows.Forms.TextBox textBoxanswer;
        private System.Windows.Forms.Button button1;
    }
}