using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Area : IComparable
    {
        // de fields der bliver GET SET i de forskellige metoder og properties
        private string name;
        private int length;
        private int width;
        private MyColorEnum color;


        

        //SET name med metode + krav til name ved hjælp af if else loop
        public void setName(string n)
        {
            if (n.Length > 2 && n.Length < 50)
            {
                name = n;
            }
            else
            {
                name = "N/A";
            }
        }
        //public void setlength(int l)
        //{
        //    length = l;
        //}
        //public void setwidth(int w)
        //{
        //    width = w;
        //}

        //GET name med metode
        public string GetName()
        {
            return name;
        }
        //public int GetLength()
        //{
        //    return length;
        //}
        //public int GetWidth()
        //{
        //    return width;
        //}

        //GET SET properties
        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    this.length = 0;
                }
            }

        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public MyColorEnum Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Area(MyColorEnum col, string name, int len, int wid)
        {
            this.Color = col;
            setName(name);
            Length = len;
            Width = wid;
        }
        public Area() { }
        public virtual int GetSize()
        {
            return this.width * this.length;
        }
        public override string ToString()
        {
            //return $"Name: {GetName()} Length: {Length} Width: {Width} Size: {GetSize()}";
            return String.Format(" Color: {0, -8} {1, -8} Size: {2, 6} Len: {3, 3} Wid: {4, 3}", this.Color, this.GetName(), this.GetSize(), Length, Width);
        }

        public int CompareTo(object obj)
        {
           return this.GetSize() - ((Area)obj).GetSize();
        }
    }
}
