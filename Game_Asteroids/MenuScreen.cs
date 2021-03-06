﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Asteroids
{
    class MenuScreen : Game
    {
        /// <summary>
        /// Создание фона для экрана - меню
        /// </summary>
        public override void LoadObject()
        {
            arrayObject = new BaseObject[300];

            for (int i = 0; i < 69; i++)
                arrayObject[i] = new Star(new Point(Resources.random.Next(0, 800), (i - 30) 
                    * Resources.random.Next(2, 30)), new Point(-i + 10, 0), 
                    new Size(5 + i / 7, 5 + i / 7));

            arrayObject[69] = new FonObject(new Point(600, 50), new Point(1, 0));

            for (int i = 70; i < arrayObject.Length; i++)
            {
                int a = Resources.random.Next(15, 30);
                arrayObject[i] = new BaseObject(new Point(Resources.random.Next(0, 800), i 
                    * Resources.random.Next(2, 20)), new Point(10 - i, 10 - i),
                    new Size(i % 2 == 0 ? a : 10, i % 2 == 0 ? a : 10));
            }
        }
    }
}
