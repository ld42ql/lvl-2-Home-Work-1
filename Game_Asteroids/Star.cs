using System;
using System.Drawing;
using System.Threading;


namespace Game_Asteroids
{
    class Star : BaseObject
    {

        
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Resources.astra, pos.X, pos.Y, size.Height, size.Width);
        }

        public override void Update()
        {
            pos.X += dir.X / 20;
            if (pos.X < 0)
            {
                pos.X = Game.Width;
            }
        }
    }
}
