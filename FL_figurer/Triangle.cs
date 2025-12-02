using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_figurer;

public class Triangle : Shape
{
    public double BaseLength { get; set; }

    public double Height { get; set; }

    public Triangle(int baseLength, int heigh)
    {
        BaseLength = BaseLength;
        Height = heigh;
    }
    public override double GetArea()
    {
        return BaseLength * Height * 0.5;
    }

    

}
