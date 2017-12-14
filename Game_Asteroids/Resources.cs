using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_Asteroids
{

    class Resources
    {

        public static Image asteroid = OpenImage("asteroid");
        public static Image astra = OpenImage("astra");
        public static Image background = OpenImage("background");
        public static Image sun = OpenImage("sun");
        public static Image starShip = OpenImage("starShip");



        static Image OpenImage(string nameImg)
        {
            try
            {
               return Image.FromFile($@"img\{nameImg}.png");
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}", "Ошибка # 1", MessageBoxButtons.OK);
                return null;
            }
        }

        public static Random random = new Random();
    }
}
