using Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProblem
{
    class Program
    {
        Rectangle rectangleRed = new RectangleRed();
        Rectangle rectangleGreen = new RectangleGreen();
        Rectangle rectangleBlue = new RectangleBlue();

        Triangle triangleRed = new TriangleRed();
        Triangle triangleGreen = new TriangleGreen();
        Triangle triangleBlue = new TriangleBlue();

        //This way for each new color I would have to create two new Classes 
        //e.g.:
        //TrangleYellow and RectangleYellow            
        //TrangleSilver and RectangleSilver
        //TrangleBlack and RectangleBlack
    }
}
