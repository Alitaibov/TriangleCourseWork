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
    public partial class TaskForm : Form
    {
        StreamReader sr;
        string answer;
        string hint;
        string fileName;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void GetTask_Click(object sender, EventArgs e)
        {
            fileName = comboBox1.Text + ".txt";
            sr = new StreamReader(fileName, Encoding.GetEncoding(1251));
            textBox1.Text = sr.ReadLine();
            answer = sr.ReadLine();
            hint = sr.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == answer)
            {
                label5.Text = "Задача решена правильно";
                label2.Text = "";
                label3.Text = "";
            }
            else
            {
                label5.Text = "Ответ неправильный";
                label2.Text = "Подсказка:";
                label3.Text = hint;
            }
        }
    }
}
