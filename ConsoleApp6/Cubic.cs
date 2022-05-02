using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Cubic : Area
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Cubic(MyColorEnum col, string n, int len, int wid, int hei)
            {
            this.Color = col;
            this.setName(n);
            this.Length = len;
            this.Width = wid;
            this.Height = hei;
        }

        public Cubic() { }

        public override string ToString()
        {
            return string.Format (base.ToString() + " Height: {0, 4} ",  this.Height); 
        }
        public override int GetSize()
        {
            return Length * Width * Height;
        }
    }
}
