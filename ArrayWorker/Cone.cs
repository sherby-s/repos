using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Cone
    {
        /*Создайте ClassLibrary с типом Cone. Конструктор типа принимает 2 параметра: радиус (r) и высоту (h). 
         * Так же в типе есть два метода, которые высчитывают площадь поверхности основания и полную площадь.*/

        private decimal _radius;
        private decimal _hight;

        public Cone(decimal radius, decimal hight)

        {
            _radius = radius;
            _hight = hight;

        }
        public decimal SquareBase()

        {
          return (decimal)Math.PI * _radius * _radius;
        }

        public decimal SquareCone()
        {
           return SquareBase() + (decimal)(Math.PI * (double)_radius * Math.Sqrt((double)(_radius * _radius + _hight * _hight)));  
              
                                 
        }

    }
}
