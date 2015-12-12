using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricApp
{
    class DrawingClass
    {
        int scale = 30;
        string temp = "ABC";

        public void CentralizeTrianglePoints(Dictionary<string, Point> points)
        {
            int leftEdge = 0;
            int rightEdge = 0;
            int topEdge = 0;
            int bottomEdge = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[temp[i].ToString()].X > rightEdge)
                    rightEdge = points[temp[i].ToString()].X;
                if (points[temp[i].ToString()].X < leftEdge)
                    leftEdge = points[temp[i].ToString()].X;
                if (points[temp[i].ToString()].Y < bottomEdge)
                    bottomEdge = points[temp[i].ToString()].Y;
                if (points[temp[i].ToString()].Y > topEdge)
                    topEdge = points[temp[i].ToString()].Y;
            }
            int width = rightEdge + leftEdge;
            int hight = topEdge + bottomEdge;
            int xOffset = 175 - width / 2;
            int yOffset = 175 - hight / 2;
            Point a = points["A"];
            Point b = points["B"];
            Point c = points["C"];
            a.Offset(xOffset, yOffset);
            b.Offset(xOffset, yOffset);
            c.Offset(xOffset, yOffset);
            points["A"] = a;
            points["B"] = b;
            points["C"] = c;
        }

        public Dictionary<string, Point> GetPoints(Dictionary<int, double> sides, Dictionary<int, double> angles)
        {
            Dictionary<string, Point> points = new Dictionary<string, Point>();
            points.Add("C", new Point(0, 0));
            points.Add("A", new Point(Convert.ToInt32(Math.Cos(angles[0]) * scale * sides[1]), Convert.ToInt32(Math.Sin(angles[0])* scale * sides[1])));
            points.Add("B", new Point(Convert.ToInt32(sides[2] * scale), 0));
            CentralizeTrianglePoints(points);
            return points;
        }

        public Point Get2ndPointForHight(int A, int B, int C, int A1, int B1, int C1)
        {
            Point point;
            int y = -(C * B1 - C1 * B) / (A * B1 - A1 * B);
            int x = -(A * C1 - A1 * C) / (A * B1 - A1 * B);
            point = new Point(x, y);
            return point;
        }

        public Point[] GetPointsForHight(Point[] points)
        {
            Point[] hightPoints = new Point[2];
            int A = points[1].Y - points[0].Y;
            int B = points[1].X - points[0].X;
            int x01 = points[2].X;
            int y01 = points[2].Y;
            int C = B * (-x01) - A * (-y01);
            int A1 = -B;
            int B1 = A;
            int x02 = points[0].X;
            int y02 = points[0].Y;
            int C1 = B1 * (-x02) - A1 * (-y02);
            hightPoints[0] = points[2];
            hightPoints[1] = Get2ndPointForHight(A, B, C, A1, B1, C1);
            return hightPoints;
        }

        public void DrawHight(Graphics g, Point p1, Point p2)
        {
            g.DrawLine(Pens.Black, p1, p2);
        }

        public Point[] GetPointsForLetters(Dictionary<string, Point> points)
        {
            Point[] letterPoints = new Point[3];
            for (int i = 0; i < points.Count; i++)
            {
                letterPoints[i] = points[temp[i].ToString()];
            }
            for (int i = 0; i < letterPoints.Length; i++)
            {
                if (letterPoints[i].Y <= 175)
                    letterPoints[i].Offset(-10, -27);
                else
                    letterPoints[i].Offset(-10, 5);
            }
            return letterPoints;
        }

        public void DrawLettersForTriangle(Graphics g, Point[] points)
        {
            Font font = new Font("Arial", 14);
            for (int i = 0; i < 3; i++)
            {
                g.DrawString(temp[i].ToString(), font, Brushes.Black, points[i]);
            }
        }

        public void DrawTriangle(Graphics g, Dictionary<string, Point> points)
        {
            Pen pen = Pens.Black;
            g.DrawLine(pen, points["C"], points["B"]);
            g.DrawLine(pen, points["C"], points["A"]);
            g.DrawLine(pen, points["A"], points["B"]);
        }
    }
}
