using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFunction
{
    //С самого начала был непонятен один момент "Вычисление площади фигуры без знания типа фигуры"
    //Я так подумал, что имеется ввиду площадь фигуры под кривой, т.е. вычисление с применением интегралов
    //Иначе непонятно как можно вывести формулу для вычисления площадь абстрактной фигуры
    public abstract class Figure
    {
        public abstract double Area();
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRight { get; } = false;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;           
            if ((sideA * sideA) == (sideB * sideB + sideC * sideC) || (sideC * sideC) == (sideB * sideB + sideA * sideA) || (sideB * sideB) == (sideA * sideA + sideC * sideC))
            {
                IsRight = true;
            }
        }
        public override double Area()
        {
            var p = ((SideA + SideB + SideC) / 2);
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
