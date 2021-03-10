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
    class Vatandaşlar
    {
        public static void Dolasma()
        {
            if (Game1.sakarsayac <= 60)
                Game1.sakarsayac++;
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.sahne == 1 || Game1.sahne == 6 || Game1.sahne == 13 || Game1.sahne == 17 || Game1.sahne == 20 || Game1.sahne == 23 || Game1.sahne == 31 || Game1.sahne == 35)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (!Game1.kafamindengisin[i])
                    {
                        if (Game1.kasabaliyon[i] == SpriteEffects.None)
                        {
                            if (i < 2)
                                Game1.kasabalix[i] += 5;
                            else
                                Game1.kasabalix[i] += 3;
                            if (Game1.kasabalix[i] >= 1885)
                                Game1.kasabaliyon[i] = SpriteEffects.FlipHorizontally;
                        }
                        else
                        {
                            if (i < 2)
                                Game1.kasabalix[i] -= 5;
                            else
                                Game1.kasabalix[i] -= 3;
                            if (Game1.kasabalix[i] <= 10)
                                Game1.kasabaliyon[i] = SpriteEffects.None;
                        }
                    }
                    if (Game1.sakarsayac >= 60 && klavye.IsKeyDown(Keys.Space) && Game1.kasabalix[i] + 48 > Game1.koordinat.X && Game1.koordinat.X + 48 > Game1.kasabalix[i] && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
                    {
                        Game1.kafamindengisin[i] = true;
                        if ((int)Game1.koordinat.X > Game1.kasabalix[i])
                            Game1.kasabaliyon[i] = SpriteEffects.None;
                        else
                            Game1.kasabaliyon[i] = SpriteEffects.FlipHorizontally;
                    }
                }
            }
            else
                for (int i = 0; i < 4; i++)
                    Game1.kasabalix[i] = -10;
        }

        public static void Konusma()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.tableuzunluk < 240)
                Game1.tableuzunluk += 8;
            if (klavye.IsKeyDown(Keys.Space) && Game1.tableuzunluk == 240)
            {
                Game1.sakarsayac = 0;
                Game1.tableuzunluk = 0;
                if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 0)
                    Game1.iksirmission = 1;
                else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 4)
                    Game1.iksirmission = 5;
                for (int i = 0; i < 5; i++)
                    Game1.kafamindengisin[i] = false;
            }
            if (Game1.sahne == 1 && Game1.kafamindengisin[0])
                Game1.secilitext = 0;
            else if (Game1.sahne == 1 && Game1.kafamindengisin[1])
                Game1.secilitext = 1;
            else if (Game1.sahne == 1 && Game1.kafamindengisin[2])
                Game1.secilitext = 2;
            else if (Game1.sahne == 1 && Game1.kafamindengisin[3])
                Game1.secilitext = 3;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[0])
                Game1.secilitext = 4;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[1])
                Game1.secilitext = 5;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[2])
                Game1.secilitext = 6;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[3])
                Game1.secilitext = 7;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[4])
                Game1.secilitext = 33;
            else if (Game1.sahne == 13 && Game1.kafamindengisin[0])
                Game1.secilitext = 8;
            else if (Game1.sahne == 13 && Game1.kafamindengisin[1])
                Game1.secilitext = 9;
            else if (Game1.sahne == 13 && Game1.kafamindengisin[2])
                Game1.secilitext = 10;
            else if (Game1.sahne == 13 && Game1.kafamindengisin[3])
                Game1.secilitext = 11;
            else if (Game1.sahne == 17 && Game1.kafamindengisin[0])
                Game1.secilitext = 12;
            else if (Game1.sahne == 17 && Game1.kafamindengisin[1])
                Game1.secilitext = 13;
            else if (Game1.sahne == 17 && Game1.kafamindengisin[2])
                Game1.secilitext = 14;
            else if (Game1.sahne == 17 && Game1.kafamindengisin[3])
                Game1.secilitext = 15;
            else if (Game1.sahne == 20 && Game1.kafamindengisin[0])
                Game1.secilitext = 16;
            else if (Game1.sahne == 20 && Game1.kafamindengisin[1])
                Game1.secilitext = 17;
            else if (Game1.sahne == 20 && Game1.kafamindengisin[2])
                Game1.secilitext = 18;
            else if (Game1.sahne == 20 && Game1.kafamindengisin[3])
                Game1.secilitext = 19;
            else if (Game1.sahne == 23 && Game1.kafamindengisin[0])
                Game1.secilitext = 20;
            else if (Game1.sahne == 23 && Game1.kafamindengisin[1])
                Game1.secilitext = 21;
            else if (Game1.sahne == 23 && Game1.kafamindengisin[2])
                Game1.secilitext = 22;
            else if (Game1.sahne == 23 && Game1.kafamindengisin[3])
                Game1.secilitext = 23;
            else if (Game1.sahne == 31 && Game1.kafamindengisin[0])
                Game1.secilitext = 24;
            else if (Game1.sahne == 31 && Game1.kafamindengisin[1])
                Game1.secilitext = 25;
            else if (Game1.sahne == 31 && Game1.kafamindengisin[2])
                Game1.secilitext = 26;
            else if (Game1.sahne == 31 && Game1.kafamindengisin[3])
                Game1.secilitext = 27;
            else if (Game1.sahne == 24 && Game1.kafamindengisin[4])
                Game1.secilitext = 34;
            else if (Game1.sahne == 35 && Game1.kafamindengisin[0])
            {
                Game1.konustumulan = true;
                Game1.secilitext = 28;
            }
            else if (Game1.sahne == 35 && Game1.kafamindengisin[1])
                Game1.secilitext = 29;
            else if (Game1.sahne == 35 && Game1.kafamindengisin[2])
                Game1.secilitext = 30;
            else if (Game1.sahne == 35 && Game1.kafamindengisin[3])
                Game1.secilitext = 31;
            else if (Game1.sahne == 35 && Game1.kafamindengisin[4])
                Game1.secilitext = 43;
            else if (Game1.sahne == 8 && Game1.kafamindengisin[4])
                Game1.secilitext = 32;
            else if (Game1.sahne == 8 && Game1.kafamindengisin[3])
                Game1.secilitext = 46;
            else if (Game1.sahne == 25 && Game1.kafamindengisin[4])
                Game1.secilitext = 46;
            else if (Game1.sahne == 37 && Game1.kafamindengisin[4])
                Game1.secilitext = 46;
            else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 0)
                Game1.secilitext = 35;
            else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 1)
                Game1.secilitext = 36;
            else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 2)
                Game1.secilitext = 38;
            else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 3)
                Game1.secilitext = 40;
            else if (Game1.sahne == 4 && Game1.kafamindengisin[4] && Game1.iksirmission == 4)
                Game1.secilitext = 42;
            else if (Game1.sahne == 9 && Game1.kafamindengisin[4])
                Game1.secilitext = 37;
            else if (Game1.sahne == 10 && Game1.kafamindengisin[4])
                Game1.secilitext = 39;
            else if (Game1.sahne == 30 && Game1.kafamindengisin[4])
                Game1.secilitext = 41;
            else if (Game1.yakubkoordinat.X < 4000 && Game1.kafamindengisin[4])
                Game1.secilitext = 44;
        }
    }
}
