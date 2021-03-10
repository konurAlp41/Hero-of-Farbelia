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
    class Item
    {
        public static bool[] basildi = new bool[4];
        public static int C = 0;
        public static void Menu()
        {
            C++;
            if (C == 7)
                C = 0;
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.itemmenuy <= 21)
            {
                Game1.itemmenuy += 10;
            }
            else
            {
                if ((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.item[Game1.seciliItem] != 0 && Game1.seciliItem < 25)
                {
                    if (Game1.eldekiItemler[0] == Game1.seciliItem)
                        Game1.eldekiItemler[0] = 30;
                    else if (Game1.eldekiItemler[1] == Game1.seciliItem)
                        Game1.eldekiItemler[1] = 30;
                    else if (Game1.eldekiItemler[2] == Game1.seciliItem)
                        Game1.eldekiItemler[2] = 30;
                    if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[1] >= 8 && Game1.eldekiItemler[1] < 13)
                        Game1.eldekiItemler[1] = 30;
                    else if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[2] >= 8 && Game1.eldekiItemler[2] < 13)
                        Game1.eldekiItemler[2] = 30;
                    Game1.eldekiItemler[0] = Game1.seciliItem;
                }
                if ((klavye.IsKeyDown(Keys.H) || klavye.IsKeyDown(Keys.X)) && Game1.item[Game1.seciliItem] != 0 && Game1.seciliItem < 25)
                {
                    if (Game1.eldekiItemler[0] == Game1.seciliItem)
                        Game1.eldekiItemler[0] = 30;
                    else if (Game1.eldekiItemler[1] == Game1.seciliItem)
                        Game1.eldekiItemler[1] = 30;
                    else if (Game1.eldekiItemler[2] == Game1.seciliItem)
                        Game1.eldekiItemler[2] = 30;
                    if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[0] >= 8 && Game1.eldekiItemler[0] < 13)
                        Game1.eldekiItemler[0] = 30;
                    else if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[2] >= 8 && Game1.eldekiItemler[2] < 13)
                        Game1.eldekiItemler[2] = 30;
                    Game1.eldekiItemler[1] = Game1.seciliItem;
                }
                if ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.item[Game1.seciliItem] != 0 && Game1.seciliItem < 25)
                {
                    if (Game1.eldekiItemler[0] == Game1.seciliItem)
                        Game1.eldekiItemler[0] = 30;
                    else if (Game1.eldekiItemler[1] == Game1.seciliItem)
                        Game1.eldekiItemler[1] = 30;
                    else if (Game1.eldekiItemler[2] == Game1.seciliItem)
                        Game1.eldekiItemler[2] = 30;
                    if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[1] >= 8 && Game1.eldekiItemler[1] < 13)
                        Game1.eldekiItemler[1] = 30;
                    else if (Game1.seciliItem >= 8 && Game1.seciliItem < 13 && Game1.eldekiItemler[0] >= 8 && Game1.eldekiItemler[0] < 13)
                        Game1.eldekiItemler[0] = 30;
                    Game1.eldekiItemler[2] = Game1.seciliItem;
                }
                if (klavye.IsKeyDown(Keys.Enter))
                {
                    Game1.menu = 1;
                    Game1.itemmenuy = -421;
                    Game1.sakarsayac2 = 0;
                }
                if (klavye.IsKeyDown(Keys.Left) || klavye.IsKeyDown(Keys.A))
                {
                    if (basildi[1])
                    {
                        basildi[1] = false;
                        if (Game1.seciliItem == 0 || Game1.seciliItem == 5 || Game1.seciliItem == 10 || Game1.seciliItem == 15 || Game1.seciliItem == 20 || Game1.seciliItem == 25)
                            Game1.seciliItem += 4;
                        else
                            Game1.seciliItem--;
                    }
                }
                else
                    basildi[1] = true;
                if (klavye.IsKeyDown(Keys.Down) || klavye.IsKeyDown(Keys.S))
                {
                    if (basildi[2])
                    {
                        basildi[2] = false;
                        if (Game1.seciliItem == 25 || Game1.seciliItem == 26 || Game1.seciliItem == 27 || Game1.seciliItem == 28 || Game1.seciliItem == 29)
                            Game1.seciliItem -= 25;
                        else
                            Game1.seciliItem += 5;
                    }
                }
                else
                    basildi[2] = true;
                if (klavye.IsKeyDown(Keys.Up) || klavye.IsKeyDown(Keys.W))
                {
                    if (basildi[3])
                    {
                        basildi[3] = false;
                        if (Game1.seciliItem == 0 || Game1.seciliItem == 1 || Game1.seciliItem == 2 || Game1.seciliItem == 3 || Game1.seciliItem == 4)
                            Game1.seciliItem += 25;
                        else
                            Game1.seciliItem -= 5;
                    }
                }
                else
                    basildi[3] = true;
                if (klavye.IsKeyDown(Keys.Right) || klavye.IsKeyDown(Keys.D))
                {
                    if (basildi[0])
                    {
                        basildi[0] = false;
                        if (Game1.seciliItem == 4 || Game1.seciliItem == 9 || Game1.seciliItem == 14 || Game1.seciliItem == 19 || Game1.seciliItem == 24 || Game1.seciliItem == 29)
                            Game1.seciliItem -= 4;
                        else
                            Game1.seciliItem++;
                    }
                }
                else
                    basildi[0] = true;
            }
        }

        public static bool[] basildiz = new bool[15];

        public static void UseItem()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 0) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 0) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 0))
                Game1.BlockActivater[0] = true;
            else
                Game1.BlockActivater[0] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 1) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 1) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 1))
                Game1.BlockActivater[1] = true;
            else
                Game1.BlockActivater[1] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 2) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 2) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 2))
                Game1.BlockActivater[2] = true;
            else
                Game1.BlockActivater[2] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 3) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 3) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 3))
                Game1.BlockActivater[3] = true;
            else
                Game1.BlockActivater[3] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 4) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 4) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 4))
                Game1.BlockActivater[4] = true;
            else
                Game1.BlockActivater[4] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 5) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 5) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 5))
                Game1.BlockActivater[5] = true;
            else
                Game1.BlockActivater[5] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 6) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 6) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 6))
                Game1.BlockActivater[6] = true;
            else
                Game1.BlockActivater[6] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 7) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 7) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 7))
                Game1.BlockActivater[7] = true;
            else
                Game1.BlockActivater[7] = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 8) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 8) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 8))
            {
                if (basildiz[0])
                {
                    basildiz[0] = false;
                    if (Game1.heroanimation == 6)
                        Game1.heroanimation = 11;
                    else
                        Game1.heroanimation = 10;
                }
            }
            else
                basildiz[0] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 9) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 9) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 9))
            {
                if (basildiz[4])
                {
                    basildiz[4] = false;
                    if (Game1.heroanimation == 6)
                        Game1.heroanimation = 11;
                    else
                        Game1.heroanimation = 10;
                }
            }
            else
                basildiz[4] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 10) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 10) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 10))
            {
                if (basildiz[3])
                {
                    basildiz[3] = false;
                    if (Game1.heroanimation == 6)
                        Game1.heroanimation = 11;
                    else
                        Game1.heroanimation = 10;
                }
            }
            else
                basildiz[3] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 11) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 11) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 11))
            {
                if (basildiz[1])
                {
                    basildiz[1] = false;
                    if (Game1.heroanimation == 6)
                        Game1.heroanimation = 11;
                    else
                        Game1.heroanimation = 10;
                }
            }
            else
                basildiz[1] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 12) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 12) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 12))
            {
                if (basildiz[2])
                {
                    basildiz[2] = false;
                    if (Game1.heroanimation == 6)
                        Game1.heroanimation = 11;
                    else
                        Game1.heroanimation = 10;
                }
            }
            else
                basildiz[2] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 13) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 13) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 13))
            {
                if (basildiz[7])
                {
                    basildiz[7] = false;
                    Game1.heroanimation = 9;
                }
            }
            else
                basildiz[7] = true;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 14) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 14) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 14))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 15) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 15) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 15))
                Game1.maper = true;
            else
                Game1.maper = false;

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 16) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 16) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 16))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 17) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 17) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 17))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 18) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 18) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 18))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 19) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 19) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 19))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 20) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 20) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 20))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 21) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 21) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 21))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 22) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 22) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 22))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 23) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 23) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 23))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 24) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 24) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 24))
            {
                if (Game1.herocan < 6)
                {
                    Game1.item[24] = 0;
                    Game1.herocan = 6;
                    Game1.heroyarasayaci = 1;
                    for (int i = 0; i < 3; i++)
                        if (Game1.eldekiItemler[i] == 24)
                            Game1.eldekiItemler[i] = 30;
                }
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 25) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 25) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 25))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 26) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 26) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 26))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 27) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 27) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 27))
            {
            }
            else
            {
            }

            if (((klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)) && Game1.eldekiItemler[0] == 28) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 28) || ((klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C)) && Game1.eldekiItemler[2] == 28))
            {
            }
            else
            {
            }
        }

        public static bool basildik;

        public static void ItemGetter()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.sahne == 6 && Game1.kafamindengisin[0])
                Game1.item[15] = 1;
            else if (Game1.sahne == 6 && Game1.kafamindengisin[2])
                Game1.item[0] = 1;
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 6 && Game1.item[1] == 0 && Game1.koordinat.X > 885 && Game1.koordinat.X < 1007 && klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[1] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 24 && Game1.item[3] == 0 && Game1.koordinat.X > 1158 && Game1.koordinat.X < 1228 && klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[3] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 35 && Game1.koordinat.X > 636 && Game1.koordinat.X < 686 && klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[16] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 9 && Game1.item[17] == 0 && Game1.koordinat.X > 1048 && Game1.koordinat.X < 1426 && klavye.IsKeyDown(Keys.Space) && Game1.iksirmission < 2 && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[17] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 10 && Game1.item[18] == 0 && Game1.koordinat.X > 1037 && Game1.koordinat.X < 1148 && klavye.IsKeyDown(Keys.Space) && Game1.iksirmission < 3 && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[18] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 30 && Game1.item[19] == 0 && Game1.koordinat.X > 1389 && Game1.koordinat.X < 1481 && Game1.koordinat.Y > 1151 && klavye.IsKeyDown(Keys.Space) && Game1.iksirmission < 4 && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                Game1.kafamindengisin[4] = true;
                Game1.item[19] = 1;
            }
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 8 && Game1.koordinat.X < 192 + 48 && Game1.koordinat.X > 192 - 48 && klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
                Game1.kafamindengisin[4] = true;
            else if (Game1.sakarsayac >= 58 && Game1.sahne == 4 && Game1.koordinat.Y < 867 && Game1.koordinat.X > 1765 - 48 && klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4] && Game1.iksirmission < 5)
            {
                if (basildik)
                {
                    basildik = false;
                    Game1.kafamindengisin[4] = true;
                    if (Game1.iksirmission == 1 && Game1.item[17] == 1)
                    {
                        Game1.item[17] = 0;
                        Game1.iksirmission = 2;
                    }
                    else if (Game1.iksirmission == 2 && Game1.item[18] == 1)
                    {
                        Game1.item[18] = 0;
                        Game1.iksirmission = 3;
                    }
                    else if (Game1.iksirmission == 3 && Game1.item[19] == 1)
                    {
                        Game1.item[19] = 0;
                        Game1.iksirmission = 4;
                        Game1.item[13] = 1;
                    }
                }
            }
            else
                basildik = true;
            if (Game1.koordinat.X == 1728 && Game1.koordinat.Y == 1008 && Game1.sahne == 8)
            {
                if (Game1.item[20] == 0)
                {
                    Game1.kafamindengisin[3] = true;
                    Game1.secilitext = 46;
                    Game1.item[20] = 1;
                }
            }
            else if (Game1.koordinat.Y < 260 && Game1.sahne == 25)
            {
                if (Game1.item[21] == 0)
                {
                    Game1.kafamindengisin[4] = true;
                    Game1.secilitext = 46;
                    Game1.item[21] = 1;
                }
            }
            else if (Game1.koordinat.X == 1776 && Game1.koordinat.Y == 96 && Game1.sahne == 37)
            {
                if (Game1.item[22] == 0)
                {
                    Game1.kafamindengisin[4] = true;
                    Game1.secilitext = 46;
                    Game1.item[22] = 1;
                }
            }
        }
    }
}
