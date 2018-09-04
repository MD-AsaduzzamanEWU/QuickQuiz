using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QickQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FormAddquestion addQuestion = new FormAddquestion();
            addQuestion.Show();

        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            FormAnsweerquestion answeerQuestion = new FormAnsweerquestion();
            answeerQuestion.Show();
        }

    }
}
