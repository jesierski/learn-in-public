using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form3 form3 = new Form3();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            form3.ShowDialog();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
