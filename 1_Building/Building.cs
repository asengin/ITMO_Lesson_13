using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Building
{
    class Building
    {
        string adressBuilding;
        double lenghtBuilding;
        double widthBuilding;
        double heightBuilding;

        private string AdressBuilding
        {
            set
            {
                adressBuilding = (String.IsNullOrWhiteSpace(value)) ? "Без адреса" : value;
            }
            get { return adressBuilding; }
        }

        private double LenghtBuilding
        {
            set
            {
                if (value <= 0)
                {
                    lenghtBuilding = 1;
                    Console.WriteLine($"Длина дома не может быть отрицательной или равной 0.\nПрисвоено значение {lenghtBuilding}");
                }
                else
                    lenghtBuilding = value;
            }
            get { return lenghtBuilding; }
        }
        private double WidthBuilding
        {
            set
            {
                if (value <= 0)
                {
                    widthBuilding = 1;
                    Console.WriteLine($"Ширина дома не может быть отрицательной или равной 0.\nПрисвоено значение {widthBuilding}");
                }
                else
                    widthBuilding = value;
            }
            get { return widthBuilding; }
        }
        private double HeightBuilding
        {
            set
            {
                if (value <= 0)
                {
                    heightBuilding = 1;
                    Console.WriteLine($"Высота дома не может быть отрицательной или равной 0.\nПрисвоено значение {lenghtBuilding}");
                }
                else
                    heightBuilding = value;
            }
            get { return heightBuilding; }
        }

        public Building(string adress, double lenght, double width, double height)
        {
            AdressBuilding = adress;
            LenghtBuilding = lenght;
            WidthBuilding = width;
            HeightBuilding = height;
        }

        public string Print()
        {
            return $"Адрес дома: {AdressBuilding}\n" +
                $"Длина дома: {LenghtBuilding}\n" +
                $"Ширина дома: {WidthBuilding}\n" +
                $"Высота дома: {HeightBuilding}";
        }
    }
}
