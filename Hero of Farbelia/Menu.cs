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
    class Menu
    {
        public static void EnteringTheMenu()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.bulunulanbina > -1)
                Game1.menu = 3;
            if (klavye.IsKeyDown(Keys.Space) && !Game1.kafamindengisin[0] && !Game1.kafamindengisin[1] && !Game1.kafamindengisin[2] && !Game1.kafamindengisin[3] && !Game1.kafamindengisin[4])
            {
                if (Game1.sahne == 1)
                {
                    if (Game1.koordinat.X > 726 && Game1.koordinat.X < 790 && Game1.benbuevesahibim[0])
                        Game1.bulunulanbina = 0;
                    else if (Game1.koordinat.X > 1008 && Game1.koordinat.X < 1122 && Game1.lanet == 0)
                    {
                        SahneDüzenleyici.firstday = true;
                        Game1.SAVEbackground = Game1.background;
                        Game1.SAVEgun = Game1.gun;
                        Game1.SAVEiksirmission = Game1.iksirmission;
                        Game1.SAVEkalkancan = Game1.kalkancan;
                        Game1.SAVEkarartma = Game1.karartma;
                        Game1.SAVEkonustumulan = Game1.konustumulan;
                        Game1.SAVEkoordinat = Game1.koordinat;
                        Game1.SAVElanet = Game1.lanet;
                        Game1.SAVEmap = Game1.map;
                        Game1.SAVEsaat = Game1.saat;
                        Game1.SAVEsahne = Game1.sahne;
                        for (int i = 0; i < 30; i++)
                        {
                            Game1.SAVEitem[i] = Game1.item[i];
                            if (i < 5)
                                Game1.SAVEbenbuevesahibim[i] = Game1.benbuevesahibim[i];
                        }
                        Game1.herocan = 6;
                        Game1.yaziolantext = "Your game is saved.";
                        Game1.textZ = 1;
                        Game1.herohak = 3;
                        Game1.bulunulanbina = 6;
                        Game1.dungeonsahne = 0;
                        Game1.dungeonkoordinat = new Vector2(16, 1248 - 96);
                        Database.Update();
                    }
                }
                else if (Game1.sahne == 6)
                {
                    if (Game1.koordinat.X > 281 && Game1.koordinat.X < 326)
                        Game1.bulunulanbina = 3;
                    else if (Game1.koordinat.X > 648 && Game1.koordinat.X < 718)
                        Game1.bulunulanbina = 1;
                }
                else if (Game1.sahne == 13)
                {
                    if (Game1.koordinat.X > 845 && Game1.koordinat.X < 910 && Game1.benbuevesahibim[1])
                        Game1.bulunulanbina = 0;
                    else if (Game1.koordinat.X > 845 - 48 && Game1.koordinat.X < 910 - 48 && !Game1.benbuevesahibim[1])
                        Game1.bulunulanbina = 8;
                    else if (Game1.koordinat.X > 362 && Game1.koordinat.X < 429)
                        Game1.bulunulanbina = 2;
                    else if (Game1.koordinat.X > 1322 && Game1.koordinat.X < 1390)
                        Game1.bulunulanbina = 1;
                }
                else if (Game1.sahne == 17)
                {
                    if (Game1.koordinat.X > 144 && Game1.koordinat.X < 214 && Game1.benbuevesahibim[2])
                        Game1.bulunulanbina = 0;
                    else if (Game1.koordinat.X > 144 - 48 && Game1.koordinat.X < 214 - 48 && !Game1.benbuevesahibim[2])
                        Game1.bulunulanbina = 8;
                    else if (Game1.koordinat.X < 66)
                        Game1.bulunulanbina = 3;
                }
                else if (Game1.sahne == 20)
                {
                    if (Game1.koordinat.X > 843 && Game1.koordinat.X < 903 && Game1.benbuevesahibim[3])
                        Game1.bulunulanbina = 0;
                    else if (Game1.koordinat.X > 843 - 48 && Game1.koordinat.X < 903 - 48 && !Game1.benbuevesahibim[3])
                        Game1.bulunulanbina = 8;
                    else if (Game1.koordinat.X > 362 && Game1.koordinat.X < 429)
                        Game1.bulunulanbina = 2;
                    else if (Game1.koordinat.X > 1658 && Game1.koordinat.X < 1726)
                        Game1.bulunulanbina = 5;
                }
                else if (Game1.sahne == 23)
                {
                    if (Game1.koordinat.X > 1058 && Game1.koordinat.X < 1168 && Game1.lanet == 1)
                    {
                        SahneDüzenleyici.firstday = true;
                        Game1.SAVEbackground = Game1.background;
                        Game1.SAVEgun = Game1.gun;
                        Game1.SAVEiksirmission = Game1.iksirmission;
                        Game1.SAVEkalkancan = Game1.kalkancan;
                        Game1.SAVEkarartma = Game1.karartma;
                        Game1.SAVEkonustumulan = Game1.konustumulan;
                        Game1.SAVEkoordinat = Game1.koordinat;
                        Game1.SAVElanet = Game1.lanet;
                        Game1.SAVEmap = Game1.map;
                        Game1.SAVEsaat = Game1.saat;
                        Game1.SAVEsahne = Game1.sahne;
                        for (int i = 0; i < 30; i++)
                        {
                            Game1.SAVEitem[i] = Game1.item[i];
                            if (i < 5)
                                Game1.SAVEbenbuevesahibim[i] = Game1.benbuevesahibim[i];
                        }
                        Game1.herocan = 6;
                        Game1.yaziolantext = "Your game is saved.";
                        Game1.textZ = 1;
                        Game1.herohak = 3;
                        Game1.bulunulanbina = 6;
                        Game1.dungeonsahne = 2;
                        Game1.dungeonkoordinat = new Vector2(16, 1248 - 96);
                        Database.Update();
                    }
                }
                else if (Game1.sahne == 35)
                {
                    if (Game1.koordinat.X > 435 && Game1.koordinat.X < 500 && Game1.benbuevesahibim[4])
                        Game1.bulunulanbina = 0;
                    else if (Game1.koordinat.X > 435 - 48 && Game1.koordinat.X < 500 - 48 && !Game1.benbuevesahibim[4])
                        Game1.bulunulanbina = 8;
                    else if (Game1.koordinat.X > 1010 && Game1.koordinat.X < 1076)
                        Game1.bulunulanbina = 4;
                    else if (Game1.koordinat.X > 1497 && Game1.koordinat.X < 1545)
                        Game1.bulunulanbina = 3;
                }
                else if (Game1.sahne == 31)
                {
                    if (Game1.koordinat.X > 1033 && Game1.koordinat.X < 1143 && Game1.lanet < 3)
                    {
                        Random rnd = new Random();
                        SahneDüzenleyici.r = rnd.Next(0, 8);
                        SahneDüzenleyici.firstday = true;
                        Game1.SAVEbackground = Game1.background;
                        Game1.SAVEgun = Game1.gun;
                        Game1.SAVEiksirmission = Game1.iksirmission;
                        Game1.SAVEkalkancan = Game1.kalkancan;
                        Game1.SAVEkarartma = Game1.karartma;
                        Game1.SAVEkonustumulan = Game1.konustumulan;
                        Game1.SAVEkoordinat = Game1.koordinat;
                        Game1.SAVElanet = Game1.lanet;
                        Game1.SAVEmap = Game1.map;
                        Game1.SAVEsaat = Game1.saat;
                        Game1.SAVEsahne = Game1.sahne;
                        for (int i = 0; i < 30; i++)
                        {
                            Game1.SAVEitem[i] = Game1.item[i];
                            if (i < 5)
                                Game1.SAVEbenbuevesahibim[i] = Game1.benbuevesahibim[i];
                        }
                        Game1.herocan = 6;
                        Game1.yaziolantext = "Your game is saved.";
                        Game1.textZ = 1;
                        Game1.herohak = 3;
                        Game1.bulunulanbina = 6;
                        Game1.dungeonsahne = 4;
                        Game1.dungeonkoordinat = new Vector2(16, 1248 - 96);
                        Database.Update();
                    }
                }
            }
        }

        public static void House()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                Game1.SAVEbackground = Game1.background;
                Game1.SAVEgun = Game1.gun;
                Game1.SAVEiksirmission = Game1.iksirmission;
                Game1.SAVEkalkancan = Game1.kalkancan;
                Game1.SAVEkarartma = Game1.karartma;
                Game1.SAVEkonustumulan = Game1.konustumulan;
                Game1.SAVEkoordinat = Game1.koordinat;
                Game1.SAVElanet = Game1.lanet;
                Game1.SAVEmap = Game1.map;
                Game1.SAVEsaat = Game1.saat;
                Game1.SAVEsahne = Game1.sahne;
                for (int i = 0; i < 30; i++)
                {
                    Game1.SAVEitem[i] = Game1.item[i];
                    if (i < 5)
                        Game1.SAVEbenbuevesahibim[i] = Game1.benbuevesahibim[i];
                }
                Game1.herocan = 6;
                Game1.yaziolantext = "Your game is saved.";
                Game1.textZ = 1;
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                Game1.herohak = 3;
                Database.Update();
            }
            else if (klavye.IsKeyDown(Keys.H) || klavye.IsKeyDown(Keys.X))
                Game1.exciter = true;
            else if (klavye.IsKeyDown(Keys.J) || klavye.IsKeyDown(Keys.C))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Blacksmith()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                if (Game1.item[25] >= 3)
                {
                    if (Game1.item[14] == 1 && Game1.kalkancan == 100)
                    {
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.textZ = 1;
                        Game1.yaziolantext = "You already have a shield.";
                    }
                    else
                    {
                        Game1.item[25] -= 3;
                        Game1.item[14] = 1;
                        Game1.kalkancan = 100;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.textZ = 1;
                        Game1.yaziolantext = "You gained a shield.";
                    }
                }
                else
                {
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                    Game1.textZ = 1;
                    Game1.yaziolantext = "You don't have enough bones.";
                }
            }
            else if (klavye.IsKeyDown(Keys.H) || klavye.IsKeyDown(Keys.X))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Note()
        {
            KeyboardState klavye = Keyboard.GetState();
            if ((Game1.noter < 40) && (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z)))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
            if (Game1.noter > 0)
                Game1.noter -= 10;
        }

        public static void Man()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                if (Game1.item[9] == 0)
                {
                    if (Game1.item[29] >= 25)
                    {
                        Game1.item[29] -= 25;
                        Game1.item[9] = 1;
                        Game1.yaziolantext = "You gained a stone dagger.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                    else
                    {
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                }
                else if (Game1.item[10] == 0)
                {
                    if (Game1.item[29] >= 50)
                    {
                        Game1.item[29] -= 50;
                        Game1.item[10] = 1;
                        Game1.yaziolantext = "You gained a silver dagger.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                    else
                    {
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                }
                else if (Game1.item[11] == 0 && Game1.sahne == 6)
                {
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                }
                else if (Game1.item[11] == 0)
                {
                    if (Game1.item[29] >= 100)
                    {
                        Game1.item[29] -= 100;
                        Game1.item[11] = 1;
                        Game1.yaziolantext = "You gained a silver sword.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                    else
                    {
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                }
                else if (Game1.item[12] == 0 && Game1.sahne < 20)
                {
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                }
                else if (Game1.item[12] == 0)
                {
                    if (Game1.item[29] >= 150)
                    {
                        Game1.item[29] -= 150;
                        Game1.item[12] = 1;
                        Game1.yaziolantext = "You gained a magical sword.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                    else
                    {
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                    }
                }
                else
                {
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                }
            }
            else if (klavye.IsKeyDown(Keys.H) || klavye.IsKeyDown(Keys.X))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Market()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                Game1.item[29] += (Game1.item[26] * 20) + (Game1.item[27] * 10) + (Game1.item[28] * 30);
                Game1.yaziolantext = "You gained " + ((Game1.item[26] * 20) + (Game1.item[27] * 10) + (Game1.item[28] * 30)) + " coins.";
                Game1.item[26] = 0;
                Game1.item[27] = 0;
                Game1.item[28] = 0;
                Game1.textZ = 1;
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
            else if (klavye.IsKeyDown(Keys.H) || klavye.IsKeyDown(Keys.X))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Arena()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Casino()
        {
            KeyboardState klavye = Keyboard.GetState();
            Random rnd = new Random();
            if (Game1.item[29] < 10)
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                Game1.yaziolantext = "You don't have enough money for gambling.";
                Game1.textZ = 1;
            }
            Game1.orospununaklindantuttugusayi = rnd.Next(1, 4);
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                if (Game1.orospununaklindantuttugusayi == 1)
                {
                    Game1.yaziolantext = "You won. Here is your 20 coins.";
                    Game1.textZ = 1;
                    Game1.item[29] += 20;
                }
                else
                {
                    Game1.yaziolantext = "I won. The number was " + Game1.orospununaklindantuttugusayi + ".";
                    Game1.textZ = 1;
                    Game1.item[29] -= 10;
                }
            }
            else if (klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                if (Game1.orospununaklindantuttugusayi == 2)
                {
                    Game1.yaziolantext = "You won. Here is your 20 coins.";
                    Game1.textZ = 1;
                    Game1.item[29] += 20;
                }
                else
                {
                    Game1.yaziolantext = "I won. The number was " + Game1.orospununaklindantuttugusayi + ".";
                    Game1.textZ = 1;
                    Game1.item[29] -= 10;
                }
            }
            else if (klavye.IsKeyDown(Keys.C) || klavye.IsKeyDown(Keys.J))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                if (Game1.orospununaklindantuttugusayi == 3)
                {
                    Game1.yaziolantext = "You won. Here is your 20 coins.";
                    Game1.textZ = 1;
                    Game1.item[29] += 20;
                }
                else
                {
                    Game1.yaziolantext = "I won. The number was " + Game1.orospununaklindantuttugusayi + ".";
                    Game1.textZ = 1;
                    Game1.item[29] -= 10;
                }
            }
            else if (klavye.IsKeyDown(Keys.V) || klavye.IsKeyDown(Keys.K))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }

        public static void Castle()
        {
            Hareket.Dungeon();
            Hareket.Carpisma();
            SahneDüzenleyici.Dungeon();
            Canavarlar.HareketEtme();
            Canavarlar.Carpisma();
            Canavarlar.YaraBere();
            CanDurumu.Yaralandim();
            Item.UseItem();
            Animation.SetHero();
            if (Game1.dungeonsahne == 1)
                Boss.JumpingGuy();
            else if (Game1.dungeonsahne == 3)
                Boss.RunningGuy();
            else if (Game1.dungeonsahne == 5)
                Boss.Unknown();
            CanDurumu.Yaralandim();
        }

        public static void Death()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
                MediaPlayer.IsRepeating = true;
            }
            else if (klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H))
                Game1.exciter = true;
        }

        public static void BuyingAHouse()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.G) || klavye.IsKeyDown(Keys.Z))
            {
                if (Game1.sahne > 18)
                {
                    if (Game1.item[29] >= 250)
                    {
                        Game1.item[29] -= 250;
                        if (Game1.sahne == 35)
                            Game1.benbuevesahibim[4] = true;
                        else
                            Game1.benbuevesahibim[3] = true;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.yaziolantext = "You bought this house.";
                        Game1.textZ = 2;
                    }
                    else
                    {
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 2;
                    }
                }
                else
                {
                    if (Game1.item[29] >= 150)
                    {
                        Game1.item[29] -= 150;
                        if (Game1.sahne == 13)
                            Game1.benbuevesahibim[1] = true;
                        else
                            Game1.benbuevesahibim[2] = true;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.yaziolantext = "You bought this house.";
                        Game1.textZ = 2;
                    }
                    else
                    {
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.yaziolantext = "You don't have enough money.";
                        Game1.textZ = 2;
                    }
                }
            }
            else if (klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H))
            {
                Game1.menu = 1;
                Game1.bulunulanbina = -1;
            }
        }
    }
}
