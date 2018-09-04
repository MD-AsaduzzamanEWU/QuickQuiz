namespace QickQuiz
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
            this.btnSet = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(111, 122);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(130, 59);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "SetQuestion";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(331, 122);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(125, 59);
            this.btnAns.TabIndex = 1;
            this.btnAns.Text = "AnsewwrQuestion";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(80, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(418, 31);
            this.Title.TabIndex = 2;
            this.Title.Text = "You Can Set Or Answer Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 406);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnSet);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Label Title;
    }
}

