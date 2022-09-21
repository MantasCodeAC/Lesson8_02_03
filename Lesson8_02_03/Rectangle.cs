using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_02_03
{
    internal class Rectangle
    {
        public Point TopLeft;
        public Point BottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool IsPointInRectangle(Point taskas)
        {
            if (taskas.X >= TopLeft.X && taskas.X <= BottomRight.X &&
                taskas.Y >= TopLeft.Y && taskas.Y <= BottomRight.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
