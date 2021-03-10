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
    class CanDurumu
    {
        public static int sayac = 0;

        public static void Oldum()
        {
            sayac++;
            Game1.koordinat.Y += 3;
            if (sayac == 32)
            {
                sayac = 0;
                Game1.menu = 1;
                Game1.koordinat.Y -= 248;
            }
        }

        public static int C = 0;

        public static void Yaralandim()
        {
            if (Game1.herocan <= 0)
            {
                Game1.heroyarasayaci = 0;
                C++;
                if (C >= 7 && C <= 13)
                    Game1.heroanimation = 6;
                else if (C >= 14 && C < 60)
                    Game1.heroanimation = 7;
                else if (C == 60)
                {
                    if (Game1.bulunulanbina == -1)
                    {
                        for (int i = 0; i < 20; i++)
                            Game1.Canavarkoordinat[i] = new Vector2(4000, 4000);
                    }
                    if (Hareket.dungeon)
                    {
                        if (Game1.dungeonsahne == 1 && Game1.dungeonkoordinat.Y >= 1500)
                            Game1.dungeonkoordinat = new Vector2(384 + 48, 1152 - 96);
                        else if (Game1.dungeonsahne == 3 && Game1.dungeonkoordinat.Y > 340 && Game1.dungeonkoordinat.Y < 600 && Game1.dungeonkoordinat.X > 1090 && Game1.dungeonkoordinat.X < 1700)
                            Game1.dungeonkoordinat = new Vector2(1728, 432 - 96);
                        else if (Game1.dungeonsahne == 5 && Game1.dungeonkoordinat.X > 1170 && Game1.dungeonkoordinat.Y > 1600)
                            Game1.dungeonkoordinat = new Vector2(1104, 1584 - 96);
                        else
                            Game1.dungeonkoordinat = Hareket.uygunkoordinat;
                    }
                    C = 0;
                    Game1.heroyarasayaci = 1;
                    Game1.herohak--;
                    if (Game1.sahne == 3)
                        Game1.koordinat = new Vector2(1824, 1440 - 96);
                    if (Game1.herohak <= 0)
                    {
                        Game1.Canavarsayisi = 0;
                        Game1.koordinat = Canavarlar.simdilikdepolama;
                        Game1.anahtaralindi = false;
                        Game1.menu = 3;
                        Game1.bulunulanbina = 7;
                        Game1.background = Game1.SAVEbackground;
                        Game1.gun = Game1.SAVEgun;
                        Game1.iksirmission = Game1.SAVEiksirmission;
                        Game1.kalkancan = Game1.SAVEkalkancan;
                        Game1.karartma = Game1.SAVEkarartma;
                        Game1.konustumulan = Game1.SAVEkonustumulan;
                        Game1.koordinat = Game1.SAVEkoordinat;
                        Game1.lanet = Game1.SAVElanet;
                        Game1.map = Game1.SAVEmap;
                        Game1.saat = Game1.SAVEsaat;
                        Game1.sahne = Game1.SAVEsahne;
                        for (int i = 0; i < 30; i++)
                        {
                            Game1.item[i] = Game1.SAVEitem[i];
                            if (i < 5)
                                Game1.benbuevesahibim[i] = Game1.SAVEbenbuevesahibim[i];
                        }
                        Game1.herohak = 3;
                        try
                        {
                            if (Game1.item[Game1.eldekiItemler[0]] == 0)
                                Game1.eldekiItemler[0] = 30;
                        }
                        catch
                        {
                            Game1.eldekiItemler[0] = 30;
                        }
                        try
                        {
                            if (Game1.item[Game1.eldekiItemler[1]] == 0)
                                Game1.eldekiItemler[1] = 30;
                        }
                        catch
                        {
                            Game1.eldekiItemler[1] = 30;
                        }
                        try
                        {
                            if (Game1.item[Game1.eldekiItemler[2]] == 0)
                                Game1.eldekiItemler[2] = 30;
                        }
                        catch
                        {
                            Game1.eldekiItemler[2] = 30;
                        }
                    }
                    Game1.herocan = 6;
                }
            }
            else if (Game1.heroyarasayaci > 0)
            {
                Game1.heroyarasayaci++;
                if (Game1.heroyarasayaci >= 60)
                    Game1.heroyarasayaci = 0;
            }
        }
    }
}
