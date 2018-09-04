using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QickQuiz
{
    public partial class FormAddquestion : Form
    {
        public FormAddquestion()
        {
            InitializeComponent();
        }

        private void Question(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "Enter Question :")
            {
                textBoxQuestion.Text = "";
                textBoxQuestion.ForeColor = Color.Black;
            }
        }

        private void QuetionEnter(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "")
            {
                textBoxQuestion.Text = "Enter Question :";
                textBoxQuestion.ForeColor = Color.Silver;
            }
        }

        private void op1(object sender, EventArgs e)
        {
            if (textBoxop1.Text == "Option 1")
            {
                textBoxop1.Text = "";
                textBoxop1.ForeColor = Color.Black;
            }
        }

        private void op1ans(object sender, EventArgs e)
        {
            if (textBoxop1.Text == "")
            {
                textBoxop1.Text = "Option 1";
                textBoxop1.ForeColor = Color.Silver;
            }
        }

        private void op2(object sender, EventArgs e)
        {
            if (textBoxop2.Text == "Option 2")
            {
                textBoxop2.Text = "";
                textBoxop2.ForeColor = Color.Black;
            }
        }

        private void op2ans(object sender, EventArgs e)
        {
            if (textBoxop2.Text == "")
            {
                textBoxop2.Text = "Option 2";
                textBoxop2.ForeColor = Color.Silver;
            }
        }

        private void op3(object sender, EventArgs e)
        {
            if (textBoxop3.Text == "Option 3")
            {
                textBoxop3.Text = "";
                textBoxop3.ForeColor = Color.Black;
            }
        }

        private void op3ans(object sender, EventArgs e)
        {
            if (textBoxop3.Text == "")
            {
                textBoxop3.Text = "Option 3";
                textBoxop3.ForeColor = Color.Silver;
            }
        }

        private void op4(object sender, EventArgs e)
        {
            if (textBoxop4.Text == "Option 4")
            {
                textBoxop4.Text = "";
                textBoxop4.ForeColor = Color.Black;
            }
        }

        private void op4ans(object sender, EventArgs e)
        {
            if (textBoxop4.Text == "")
            {
                textBoxop4.Text = "Option 4";
                textBoxop4.ForeColor = Color.Silver;
            }
        }

        private void curand(object sender, EventArgs e)
        {
            if (textBoxanswer.Text == "Currect Answer")
            {
                textBoxanswer.Text = "";
                textBoxanswer.ForeColor = Color.Black;
            }
        }

        private void curandans(object sender, EventArgs e)
        {
            if (textBoxanswer.Text == "")
            {
                textBoxanswer.Text = "Currect Answer";
                textBoxanswer.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Desktop\VSProject\QickQuiz\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sda = new SqlCommand("INSERT INTO Question(Quest,Answer,op1,op2,op3,op4) VALUES ('" + this.textBoxQuestion.Text + "','" + this.textBoxanswer.Text + "','" + this.textBoxop1.Text + "','" + this.textBoxop2.Text + "','" + this.textBoxop3.Text + "','" + this.textBoxop4.Text + "')", con);
            object ob = sda.ExecuteNonQuery();
            MessageBox.Show(ob+"Record has been inserted");
            con.Close();
        }

   
    }
}
