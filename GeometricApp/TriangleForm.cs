using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricApp
{
    public partial class TriangleForm : Form
    {
        Graphics g;
        int sideCounter;
        string alphabet = "abcdefghigklmnopqrstuvwxyz";
        Dictionary<int, double> sides, angles;
        Dictionary<string, Point> points;
        Point[] letterPoints;
        Point[] hightPoints;
        Dictionary<string, Hight> hights;
        DrawingClass dc = new DrawingClass();
        List<TextBox> sidesList, anglesList;
        Triangle trig;
        public TriangleForm()
        {
            InitializeComponent();
            g = pictureBox.CreateGraphics();
            sideCounter = 3;
        }

        private string GetFirstLetterOfNewName(string sideName)
        {
            sideName = sideName.ToUpper();
            if (sideName == "AB" || sideName == "BA")
                return "C";
            else if (sideName == "AC" || sideName == "CA")
                return "B";
            else if (sideName == "BC" || sideName == "CB")
                return "A";
            else if (sideName == "")
                throw new Exception("Введите название стороны в верхнее поле.");
            else
                throw new Exception("Такой стороны у треугольника нет. Укажите название одной из сторон треугольника.");
        }

        public Point[] GetPointsInRightOrder(string sideName)
        {
            Point[] result = new Point[3];
            if (sideName == "AB")
            {
                result[0] = points["A"];
                result[1] = points["B"];
                result[2] = points["C"];
            }
            if (sideName == "AC")
            {
                result[0] = points["A"];
                result[1] = points["C"];
                result[2] = points["B"];
            }
            if (sideName == "BC")
            {
                result[0] = points["B"];
                result[1] = points["C"];
                result[2] = points["A"];
            }
            return result;
        }

        public void RedrawHight()
        {

        }

        private void AddHight_Button_Click(object sender, EventArgs e)
        {
            string newSideName = GetFirstLetterOfNewName(sideName_comboBox.Text) + alphabet[sideCounter].ToString().ToUpper();
            SideOrAnglePanel sidePanel = new SideOrAnglePanel(newSideName + "=", newSideName + "_Side_textBox");
            sideCounter++;
            sides_flowLayoutPanel.Controls.Add(sidePanel);
            
            hightPoints = dc.GetPointsForHight(GetPointsInRightOrder(sideName_comboBox.Text));
            dc.DrawHight(g, hightPoints[0], hightPoints[1]);
        }

        private void Redraw_Button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            points = dc.GetPoints(sides, angles);
            dc.DrawTriangle(g, points);
            letterPoints = dc.GetPointsForLetters(points);
            dc.DrawLettersForTriangle(g, letterPoints);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            sides = new Dictionary<int, double>();
            angles = new Dictionary<int, double>();
            sidesList = new List<TextBox>();
            sidesList.Add(AB_Side_textBox);
            sidesList.Add(AC_Side_textBox);
            sidesList.Add(BC_Side_textBox);
            anglesList = new List<TextBox>();
            anglesList.Add(ACB_Angle_textBox);
            anglesList.Add(ABC_Angle_textBox);
            anglesList.Add(BAC_Angle_textBox);
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if (sidesList[i].Text != "")
                    {
                        sides.Add(i, double.Parse(sidesList[i].Text));

                    }
                    if (anglesList[i].Text != "")
                    {
                        angles.Add(i, double.Parse(anglesList[i].Text));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка приведения типа. Неверный ввод параметров");
                    return;
                }
            }
            try
            {
                trig = new Triangle(sides, angles);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
            ReturnedInfo(sidesList,anglesList);

        }


        void ReturnedInfo(List<TextBox> sidesList, List<TextBox> anglesList)
        {
            for (int i = 0; i < 3; i++)
            {
                sidesList[i].Text = trig.GetSides[i].ToString();
                anglesList[i].Text = trig.GetAngles[i].ToString();
            }
            AreaTextbox.Text = trig.GetArea.ToString();
            PerimetrTextbox.Text = trig.GetPerimetr.ToString();           
        }
}
}
