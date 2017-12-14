using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Asteroids
{
    class FonObject : BaseObject
    {
        
        /// <summary>
        /// Объект для фона, звезда
        /// </summary>
        public FonObject (Point pos, Point dir) : base(pos, dir)
        {

        }


        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Resources.sun, pos.X, pos.Y);
        }

        public override void Update()
        {
            pos.X -= dir.X + 1;
            if (pos.X < -220)
            {
                pos.X = Game.Width;
            }
        }
    }
}
