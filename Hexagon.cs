using Interface_ShapeSolid;
using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Hexagon : IShape
    {
        readonly float width;
        readonly float height;
        public Hexagon(float width)
        {
            this.width = width;
        }
        public float Width
        {
            get { return width; }
        }
        public float Height
        {
            get { return height; }
        }
        public float Surface
        {
            get { return GetSurface(width); }
        }
        public float Circumference
        {
            get
            {
                return width * 6;
            }
        }

        static public float GetSurface(float width)
        {
            return width * width * 3 * MathF.Sqrt(3) / 2;
        }
    }
}