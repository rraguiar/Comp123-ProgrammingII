using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Rectangle
    {
        //data members - more correctly if called fields
        int length;
        int width;
        /*
         * Constructor:
         * Same name as the class, has no return type
         * is invoked automatically on object creation - because it has the same name
         */ 
        public Rectangle (int len, int wid)
        //this is not a method, is a CONSTRUCTOR - method would have a return tag (void or data type)
        {
            length = len;
            width = wid;
        }
        //the ToString() method is called when the object has to be displayed
        public override string ToString()
        {
            return $"Length: {length}, width:{width}";
        }
    }
}
