using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Hero_of_Farbelia
{
    class zaman
    {
        public static void SetTime()
        {
            Game1.saat += 0.03f;
            if (Game1.saat >= 6.18f * 60)
            {
                Game1.gun++;
                Game1.saat = 0;
            }

            if (Game1.sahne == 26 || Game1.sahne == 27 || Game1.sahne == 28 || Game1.sahne == 29)
            {
                if (Game1.item[5] == 1)
                    Game1.colsayaci = 10015;
                Game1.colsayaci++;
                if (Game1.colsayaci > 10000 && Game1.colsayaci < 10003)
                {
                    if (Game1.yakubkoordinat == new Vector2(4000, 4000))
                    {
                        Game1.colsayaci = 10004;
                        Game1.yakubkoordinat = new Vector2(Game1.koordinat.X, Game1.koordinat.X - 400);
                        Game1.kafamindengisin[4] = true;
                    }
                }
            }
            else
                Game1.colsayaci = 0;

            if (Game1.yakubkoordinat.X < 4000 && Game1.item[5] == 0)
            {
                Game1.yakubkoordinat.Y += 3;
                if (Game1.yakubkoordinat.Y > Game1.koordinat.Y)
                {
                    Game1.yaziolantext = "You gained gray yakub.";
                    Game1.textZ = 3;
                    Game1.item[5] = 1;
                    Game1.yakubkoordinat = new Vector2(4000, 4000);
                }
            }
        }

        public static void SetSkyColor()
        {
            if (Game1.saat > 1.57f * 60 && Game1.saat < 95.73f)
            {
                Game1.karartma.R += 2;
                Game1.background.R += 3;
                Game1.karartma.G += 2;
                Game1.background.G += 4;
                Game1.karartma.B += 2;
                Game1.background.B += 4;
            }
            else if (Game1.saat > 5.23f * 60 && Game1.saat < 315.33f)
            {
                Game1.karartma.R -= 2;
                Game1.background.R -= 3;
                Game1.karartma.G -= 2;
                Game1.background.G -= 4;
                Game1.karartma.B -= 2;
                Game1.background.B -= 4;
            }
        }
    }
}
