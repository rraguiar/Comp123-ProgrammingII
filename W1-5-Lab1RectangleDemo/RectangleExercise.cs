using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1W01RectangleDemo
{
    class RectangleExercise
    {
        private int length;
        private int width;
        public RectangleExercise(int len, int wid)
        {
            this.length = len;
            this.width = wid;
        }
        public int GetArea()
        {
            return length * width;
        }
        /*
        public void SetArea(int len, int wid)
        {
            this.length = len;
            this.width = wid;
        }
        */
        public override string ToString()
        {
            return $"Lenght: {length}, width: {width}";
        }
    }
}
