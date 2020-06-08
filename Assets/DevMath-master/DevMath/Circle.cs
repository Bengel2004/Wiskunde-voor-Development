using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            Vector2 _temp = Position - circle.Position;
            _temp.x = Math.Abs(_temp.x);
            _temp.y = Math.Abs(_temp.y);

            return _temp.Magnitude < Radius + circle.Radius;
        }
    }
}
