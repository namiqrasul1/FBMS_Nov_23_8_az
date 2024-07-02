using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16RegexLog
{
    //class Circle
    //{
    //    public double Radius { get; set; }
    //}

    //class Rectangle
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }
    //}

    //class Triangle
    //{
    //    // some property
    //}

    //class Calc
    //{
    //    public double CalcArea(object figure)
    //    {
    //        if(figure is  Rectangle rect)
    //            return rect.Height * rect.Width;
    //        if (figure is Circle circle)
    //            return circle.Radius * circle.Radius * 3.14;
    //        if (figure is Triangle triangle) { }

    //        throw new ArgumentException("It is not figure");
    //    }
    //}

    abstract class Figure
    {
        public abstract double CalcArea();
    }

    class Circle : Figure
    {
        public double Radius { get; set; }

        public override double CalcArea()
        {
            return Radius * Radius * 3.14;
        }
    }

    class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double CalcArea()
        {
            return Height * Width;
        }
    }

    class Triangle : Figure
    {
        // some code

        public override double CalcArea()
        {
            throw new NotImplementedException();
        }
    }

    class Calc
    {
        public double CalcArea(Figure figure)
        {
            return figure.CalcArea();
        }
    }

    interface IMailService
    {
        void SendMail(string to, string subject, string body);
    }

    class GmailService : IMailService
    {
        public void SendMail(string to, string subject, string body)
        {
            // gmail uchun kodlar
        }
    }

    class YandexMailService : IMailService 
    {
        public void SendMail(string to, string subject, string body)
        {
            // yandex mail uchun kodlar
        }
    }

    internal class OpenClosedPrinciple
    {
        //static void Main(string[] args)
        //{

        //}
    }
}
