using Solution;
using Solution.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleRed = new Solution.Rectangle() { Color = new Red() };
            Rectangle rectangleGreen = new Solution.Rectangle() { Color = new Green() };
            Rectangle rectangleBlue = new Solution.Rectangle() { Color = new Blue() };

            Triangle triangleRed = new Solution.Triangle() { Color = new Red() };
            Triangle triangleGreen = new Solution.Triangle() { Color = new Green() };
            Triangle triangleBlue = new Solution.Triangle() { Color = new Blue() };

            //Then when new colors be created will just create a implementation to these colors
            //rather than creating a new RectangeNEWCOLOR and TriangleNEWCOLOR
        }
    }
}
