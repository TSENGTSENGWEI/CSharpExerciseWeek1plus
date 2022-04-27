using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1And2
{
    internal class RectAngle
    {
        public float Height { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }

        public override string ToString()
        {
            return (Height * Length * Width).ToString();
        }
    }
}