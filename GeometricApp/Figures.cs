using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricApp
{
    class Hight
    {
        double length;
        Point[] points;
        public Hight(Point p1, Point p2)
        {
            points[0] = p1;
            points[1] = p2;
            length = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }

    class Triangle
    {                
        Dictionary<int, double> sides;
        Dictionary<int, double> angles;
        delegate void Builder();

        /// <summary>
        /// Конструктор класса по трём сторонам
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        public Triangle(Dictionary<int, double> sides, Dictionary<int, double> angles)
        {
            this.sides = sides;
            this.angles = angles;
            if (!HasASolution())
                throw new Exception("Недостаточно данных");            
            Builder builder = WaysToSolve();            
            builder();
            

        }
        Builder WaysToSolve()
        {
            if (sides.Count == 3)
            {
                return BuildOn3Sides;
            }
            if (sides.Count == 2)
            {
                if (sides.Keys.ToArray()[0] + sides.Keys.ToArray()[1] + angles.Keys.ToArray()[0] == 3)
                    return TwoSidesAndIncludedAngle;
                else
                    return TwoSidesAndAngle;
            }
            return OneSideAndTwoAngles;
        }

        void BuildOn3Sides()
        {
            if (sides[0] >= sides[1] + sides[2] || sides[1] >= sides[0] + sides[2] || sides[2] >= sides[0] + sides[1])
                throw new Exception("Сумма двух сторон меньше третьей стороны");      
            angles[0] = AngleCalculator(sides[0], sides[1], sides[2]);
            angles[1] = AngleCalculator(sides[1], sides[0], sides[2]);
            angles[2] = Math.PI - angles[0] - angles[1];
            
        }
        void TwoSidesAndIncludedAngle()
        {
            int n = 3 - sides.Keys.ToArray()[0] - sides.Keys.ToArray()[1];
            angles[n] = ConvertToRadian(angles[n]);
            sides[n] = SideCalculatorAnIncAngle(sides.Values.ToArray()[0],sides.Values.ToArray()[1],angles[n]);
            angles[0] = AngleCalculator(sides[0], sides[1], sides[2]);
            angles[1] = AngleCalculator(sides[1], sides[0], sides[2]);
            angles[2] = Math.PI - angles[0] - angles[1];
        }
        void TwoSidesAndAngle()
        {
            int n = 3 - sides.Keys.ToArray()[0] - sides.Keys.ToArray()[1];
            int a = angles.Keys.ToArray()[0];
            int b = 3 - n - a;
            angles[a] = ConvertToRadian(angles[a]);
            angles[b] = SineTheoremForAngle(sides[b], sides[a], angles[a]);
            angles[n] = Math.PI - angles[a] - angles[b];
            sides[n] = SideCalculatorAnIncAngle(a, b, angles[n]);

            
        }
        void OneSideAndTwoAngles()
        {
            int n = 3 - angles.Keys.ToArray()[0] - angles.Keys.ToArray()[1];
            int a = GetSidesNumbers(n)[0];
            int b = GetSidesNumbers(n)[1];              
            angles[a] = ConvertToRadian(angles[a]);
            angles[b] = ConvertToRadian(angles[b]);
            angles[n] = Math.PI - angles[a] - angles[b];
            int sideKey = sides.Keys.ToArray()[0];
            a = GetSidesNumbers(sideKey)[0];
            b = GetSidesNumbers(sideKey)[1];
            sides[a] = SineTheoremForSide(angles[a], sides[sideKey],angles[sideKey]);
            sides[b] = SideCalculatorAnIncAngle(sides[a], sides[sideKey], angles[b]);

        }

        bool HasASolution()
        {
            return (sides.Count + angles.Count > 2)&&sides.Count!=0;
        }

        public double[] GetSides
        {
            get
            {
                double[] array=new double[3];
                array[0] = sides[0];
                array[1] = sides[1];
                array[2] = sides[2];
                return array;
            }
        }
        public double[] GetAngles {
            get
            {
                double[] array = new double[3];
                array[0] = angles[0];
                array[1] = angles[1];
                array[2] = angles[2];
                return ConvertToGradus(array);
            }
        }
        public double GetArea
        {
            get { return AreaCalc(); }
        }
        public double GetPerimetr
        {
            get { return PerimetrCalc(); }
        }
        public double GetIncircleRadius
        {
            get { return RadiusIncircle(); }
        }
        public double GetCircumCircleRadius
        {
            get { return CircumCircleRadius(); }
        }


        private double ConvertToRadian(double angle)
        {
            return (float)Math.PI * angle / 180;
        }
        private double ConvertToGradus(double angle)
        {
            return Math.Round(180 * angle / (float)Math.PI, 2);
        }
        private double[] ConvertToGradus(double[] angle)
        {
            for (int i = 0; i < angle.Length; i++)
            {
                angle[i] = ConvertToGradus(angle[i]);                
            }
            return angle;
        }
        private double AngleCalculator(double opposite,double second,double third)
        {            
            return Math.Acos((Math.Pow(second, 2) + Math.Pow(third, 2) - Math.Pow(opposite, 2)) / (2 * second * third));
        }
        private double SideCalculatorAnIncAngle(double first, double second, double angle)
        {
            return Math.Round(Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2) - 2 * first * second* Math.Cos(angle)),3);
        }
        private double SineTheoremForAngle(double oppositeSide, double sideX, double angleX)
        {           
            return Math.Asin((oppositeSide / sideX) * Math.Sin(angleX));
            
        }
        private double SineTheoremForSide(double oppositeAngle, double sideX, double angleX)
        {
            return Math.Round(sideX * Math.Sin(oppositeAngle)/Math.Sin(angleX),3);

        }

        private double AreaCalc()
        {
            double p = PerimetrCalc()/2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }       
        /// <summary>
        /// Вычисление периметра треугольника
        /// </summary>
        /// <returns></returns>
        private double PerimetrCalc()
        {
            return sides[0] + sides[1] + sides[2];
        }
        /// <summary>
        /// Вычисление радиуса вписанной окружности
        /// </summary>
        /// <returns></returns>
        private double RadiusIncircle()
        {
            return Math.Sqrt(((PerimetrCalc() / 2 - sides[0]) * (PerimetrCalc() / 2 - sides[1]) * (PerimetrCalc() / 2 - sides[2])) / (PerimetrCalc() / 2));
        }
        /// <summary>
        /// Вычисление радиуса описанной окружности
        /// </summary>
        /// <returns></returns>
        private double CircumCircleRadius()
        {
            return sides[0] * sides[1] * sides[2] /4 * GetArea;
        }
        /// <summary>
        /// Вычисление биссектриссы
        /// </summary>
        /// <param name="i">Ключ угла, из которого проведена биссектрисса</param>
        /// <returns></returns>
        private double Bisector(int i)
        {
            int a = GetSidesNumbers(i)[0];
            int b = GetSidesNumbers(i)[1];
            return (2 * Math.Cos(angles[i] / 2) * sides[a] * sides[b]) / (sides[a] + sides[b]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int[] GetSidesNumbers(int n)
        {
            int[] array = new int[2];
            int sum = 3 - n;
            if (sum == 3)
            {
                array[0] = 1;
                array[1] = 2;
            }
            else
            {
                array[0] = 0;
                array[1] = sum;
            }
            return array;
        }
    }
}
