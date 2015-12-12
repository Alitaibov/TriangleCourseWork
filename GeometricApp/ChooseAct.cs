using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeometricApp
{
    public partial class ChooseAct : Form
    {
        public ChooseAct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriangleForm TF = new TriangleForm();
            TF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskForm TaF = new TaskForm();
            TaF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
