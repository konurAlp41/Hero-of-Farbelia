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
    class Boss
    {
        public static Vector2 bosskoordinat = new Vector2();
        public static int bosscan = 6;
        public static SpriteEffects bossyon = SpriteEffects.None;
        public static int bossanimation = 0;
        public static int bossyarasayaci = 0;
        public static int bekletme = 0;
        public static byte bosser = 0;

        public static float Jumperhiz = 0;
        public static int Jumperjumptime = 0;
        public static int Jumperwaiter = 0;
        public static void JumpingGuy()
        {
            if (Game1.koordinat.Y < 1500)
            {
                bosskoordinat = new Vector2(816 - 96, 1824 - 96);
                bosscan = 10;
                Jumperjumptime = 0;
                Jumperwaiter = 0;
                Jumperhiz = 0;
                bosser = 0;
            }
            else
            {
                bosser = 2;
                if (bosscan > 0)
                {
                    bosser = 1;
                    if (Game1.koordinat.X > bosskoordinat.X)
                        bossyon = SpriteEffects.None;
                    else
                        bossyon = SpriteEffects.FlipHorizontally;
                    if (Jumperjumptime >= 80)
                        Jumperjumptime = 0;
                    if (Jumperjumptime == 0)
                    {
                        Jumperwaiter++;
                        if (Jumperwaiter < 8)
                            bossanimation = 1;
                        else if (Jumperwaiter < 53)
                            bossanimation = 2;
                        else
                            bossanimation = 3;
                        if (Jumperwaiter >= 60)
                        {
                            Jumperwaiter = 0;
                            bosskoordinat.Y -= 8;
                            Jumperjumptime = 1;
                            Jumperhiz = (Game1.koordinat.X - bosskoordinat.X + 24) / 80;
                            bosskoordinat.X += Jumperhiz;
                        }
                    }
                    else if (Jumperjumptime > 0)
                    {
                        bossanimation = 0;
                        Jumperjumptime++;
                        if (Jumperjumptime <= 10)
                            bosskoordinat.Y -= 8;
                        else if (Jumperjumptime <= 20)
                            bosskoordinat.Y -= 4;
                        else if (Jumperjumptime <= 30)
                            bosskoordinat.Y -= 2;
                        else if (Jumperjumptime <= 40)
                            bosskoordinat.Y -= 1;
                        else if (Jumperjumptime <= 50)
                            bosskoordinat.Y += 1;
                        else if (Jumperjumptime <= 60)
                            bosskoordinat.Y += 2;
                        else if (Jumperjumptime <= 70)
                            bosskoordinat.Y += 4;
                        else
                            bosskoordinat.Y += 8;
                        bosskoordinat.X += Jumperhiz;
                    }
                }
            }
            if (Game1.heroyarasayaci == 0 && Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 96 > Game1.koordinat.X && Game1.koordinat.Y + 96 > bosskoordinat.Y && bosskoordinat.Y + 96 > Game1.koordinat.Y)
            {
                Game1.herocan--;
                Game1.heroyarasayaci = 1;
            }
            if (Game1.heroanimation >= 10 && bossyarasayaci == 0 && bosskoordinat.X < 2000)
            {
                if (Game1.heroyon == SpriteEffects.None && bosskoordinat.X + 96 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                {
                    bossyarasayaci = 1;
                    bosscan--;
                }
                else if (Game1.heroyon == SpriteEffects.FlipHorizontally && bosskoordinat.X + 96 > Game1.koordinat.X - 27 && Game1.koordinat.X > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                {
                    bossyarasayaci = 1;
                    bosscan--;
                }
                if (bosscan <= 0)
                {
                    Game1.parcacikanimation = 0;
                    Game1.parcacikkoordinat = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y + 24);
                    bosskoordinat = new Vector2(4000, 4000);
                    bekletme = 0;
                }
            }
            if (bossyarasayaci > 0)
            {
                bossyarasayaci++;
                if (bossyarasayaci >= 120)
                    bossyarasayaci = 0;
            }
            if (bosscan <= 0)
            {
                bekletme++;
                if (bekletme > 300)
                {
                    Game1.lanet = 1;
                    Game1.koordinat = new Vector2(1032, 1776 - 96);
                    Game1.dungeonkoordinat = new Vector2(1032, 1776 - 96);
                    Canavarlar.simdilikdepolama = new Vector2(1032, 1776 - 96);
                    Game1.SAVEkoordinat = new Vector2(1032, 1776 - 96);
                    bekletme = 0;
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
                    Game1.herohak = 3;
                    Game1.yaziolantext = "Your game is saved.";
                    Game1.textZ = 1;
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                    Game1.koordinat = Canavarlar.simdilikdepolama;
                    for (int i = 0; i < 4; i++)
                        Game1.kasabalix[i] = 400 + (400 * i);
                    Game1.anahtaralindi = false;
                    Database.Update();
                }
            }
        }

        public static int C = 0;
        public static void RunningGuy()
        {
            C++;
            if (C == 5)
            {
                C = 0;
                bossanimation++;
                if (bossanimation >= 4)
                    bossanimation = 0;
            }
            if (Game1.dungeonkoordinat.Y > 340 && Game1.dungeonkoordinat.Y < 600 && Game1.dungeonkoordinat.X > 1090 && Game1.dungeonkoordinat.X < 1700)
            {
                bosser = 2;
                if (bosscan > 0)
                    bosser = 1;
                if (bossyon == SpriteEffects.None)
                {
                    bosskoordinat.X += 10;
                    if (bosskoordinat.X >= 1584)
                        bossyon = SpriteEffects.FlipHorizontally;
                }
                else
                {
                    bosskoordinat.X -= 10;
                    if (bosskoordinat.X <= 1104)
                        bossyon = SpriteEffects.None;
                }
                if (Game1.heroyarasayaci == 0 && Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 96 > Game1.koordinat.X && Game1.koordinat.Y + 48 > bosskoordinat.Y && bosskoordinat.Y + 96 > Game1.koordinat.Y)
                {
                    Game1.herocan--;
                    Game1.heroyarasayaci = 1;
                }
                if (Game1.heroanimation >= 10 && bossyarasayaci == 0 && bosskoordinat.X < 2000)
                {
                    if (Game1.heroyon == SpriteEffects.None && bosskoordinat.X + 96 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                    }
                    else if (Game1.heroyon == SpriteEffects.FlipHorizontally && bosskoordinat.X + 96 > Game1.koordinat.X - 27 && Game1.koordinat.X > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                    }
                    if (bosscan <= 0)
                    {
                        Game1.parcacikanimation = 0;
                        Game1.parcacikkoordinat = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y + 24);
                        bosskoordinat = new Vector2(4000, 4000);
                        bekletme = 0;
                    }
                }
                if (bossyarasayaci > 0)
                {
                    bossyarasayaci++;
                    if (bossyarasayaci >= 120)
                        bossyarasayaci = 0;
                }
                if (bosscan <= 0)
                {
                    bekletme++;
                    if (bekletme > 300)
                    {
                        Game1.lanet = 2;
                        Game1.koordinat = new Vector2(1080, 1776 - 96);
                        Game1.dungeonkoordinat = new Vector2(1080, 1776 - 96);
                        Canavarlar.simdilikdepolama = new Vector2(1080, 1776 - 96);
                        Game1.SAVEkoordinat = new Vector2(1080, 1776 - 96);
                        bekletme = 0;
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
                        Game1.herohak = 3;
                        Game1.yaziolantext = "Your game is saved.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.koordinat = Canavarlar.simdilikdepolama;
                        for (int i = 0; i < 4; i++)
                            Game1.kasabalix[i] = 400 + (400 * i);
                        Database.Update();
                    }
                }
            }
            else
            {
                bosskoordinat = new Vector2(1104, 576 - 96);
                bosscan = 10;
                bossyon = SpriteEffects.None;
            }
        }

        public static int saldirmayakalansure = 0;
        public static int saldirininbitisinekalansure = 0;
        public static void Unknown()
        {
            C++;
            if (C == 7)
            {
                C = 0;
                bossanimation++;
                if (bossanimation >= 4)
                    bossanimation = 0;
                bosser = 0;
            }
            Random rnd = new Random();
            if (Game1.dungeonkoordinat.X > 1170 && Game1.dungeonkoordinat.Y > 1600)
            {
                bosser = 2;
                if (bosscan > 0)
                    bosser = 1;
                if (saldirmayakalansure == 0)
                {
                    saldirininbitisinekalansure++;
                    if (saldirininbitisinekalansure <= 21)
                    {
                        bosskoordinat.Y += 8;
                        bosskoordinat.X += Jumperhiz;
                    }
                    else if (saldirininbitisinekalansure <= 63)
                    {
                        bosskoordinat.Y -= 4;
                    }
                    else
                    {
                        saldirininbitisinekalansure = 0;
                        saldirmayakalansure = rnd.Next(180, 360);
                    }
                }
                else
                {
                    saldirmayakalansure--;
                    if (saldirmayakalansure == 0)
                    {
                        saldirininbitisinekalansure = 0;
                        Jumperhiz = (Game1.dungeonkoordinat.X - bosskoordinat.X) / 21;
                    }
                    if (bossyon == SpriteEffects.None)
                    {
                        bosskoordinat.X += 8;
                        if (bosskoordinat.X >= 1802)
                            bossyon = SpriteEffects.FlipHorizontally;
                    }
                    else
                    {
                        bosskoordinat.X -= 8;
                        if (bosskoordinat.X <= 1224)
                            bossyon = SpriteEffects.None;
                    }
                }
                if (Game1.heroyarasayaci == 0 && Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 72 > Game1.koordinat.X && Game1.koordinat.Y + 48 > bosskoordinat.Y && bosskoordinat.Y + 72 > Game1.koordinat.Y)
                {
                    Game1.herocan--;
                    Game1.heroyarasayaci = 1;
                }
                if (Game1.heroanimation >= 10 && bossyarasayaci == 0 && bosskoordinat.X < 2000)
                {
                    if (Game1.heroyon == SpriteEffects.None && bosskoordinat.X + 72 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > bosskoordinat.X && bosskoordinat.Y + 72 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                    }
                    else if (Game1.heroyon == SpriteEffects.FlipHorizontally && bosskoordinat.X + 72 > Game1.koordinat.X - 27 && Game1.koordinat.X > bosskoordinat.X && bosskoordinat.Y + 72 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                    }
                    if (bosscan <= 0)
                    {
                        Game1.parcacikanimation = 0;
                        Game1.parcacikkoordinat = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y + 24);
                        bosskoordinat = new Vector2(4000, 4000);
                        bekletme = 0;
                    }
                }
                if (bossyarasayaci > 0)
                {
                    bossyarasayaci++;
                    if (bossyarasayaci >= 120)
                        bossyarasayaci = 0;
                }
                if (bosscan <= 0)
                {
                    bekletme++;
                    if (bekletme > 300)
                    {
                        Game1.koordinat = new Vector2(1056, 1776 - 96 - 48);
                        Game1.dungeonkoordinat = new Vector2(1056, 1776 - 96 - 48);
                        Canavarlar.simdilikdepolama = new Vector2(1056, 1776 - 96 - 48);
                        Game1.SAVEkoordinat = new Vector2(1056, 1776 - 96 - 48);
                        bekletme = 0;
                        Game1.lanet = 3;
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
                        Game1.herohak = 3;
                        Game1.yaziolantext = "Your game is saved.";
                        Game1.textZ = 1;
                        Game1.menu = 1;
                        Game1.bulunulanbina = -1;
                        Game1.koordinat = Canavarlar.simdilikdepolama;
                        for (int i = 0; i < 4; i++)
                            Game1.kasabalix[i] = 400 + (400 * i);
                        Database.Update();
                    }
                }
            }
            else
            {
                bossyon = SpriteEffects.None;
                bosskoordinat = new Vector2(1802, 1632);
                bosscan = 10;
                saldirmayakalansure = 0;
                saldirininbitisinekalansure = 0;
            }
        }

        public static int reader = 0;
        public static Vector2[] ballkoordinat = new Vector2[24];
        public static int ist = 0;
        public static int saygin = 0;
        public static bool form = false;
        public static void LordOfDarknessGuy()
        {
            if (Game1.sahne != 3 || Game1.koordinat.X >= 1024)
            {
                bosscan = 8;
                bosskoordinat = new Vector2(296, 1160);
                bossyon = SpriteEffects.None;
                form = false;
                reader = 0;
                ist = 0;
                saygin = 0;
                bossanimation = 0;
                for (int i = 0; i < 24; i++)
                    ballkoordinat[i] = new Vector2(4000, 4000);
                bosser = 0;
            }
            else if (!form)
            {
                bosser = 1;
                if (bosskoordinat.Y < 1160)
                    bosskoordinat.Y = 1160;
                C++;
                if (bosscan > 0)
                {
                    if (C == 7)
                    {
                        C = 0;
                        if (bossanimation == 0)
                            bossanimation = 1;
                        else if (bossanimation == 1)
                            bossanimation = 0;
                    }
                    if (bossyon == SpriteEffects.None)
                    {
                        bosskoordinat.X += 8;
                        if (bosskoordinat.X == 936)
                        {
                            bossyon = SpriteEffects.FlipHorizontally;
                            if (bossanimation == 2)
                                bossanimation = 0;
                            if (saygin == 0)
                            {
                                saygin = 1;
                                bosskoordinat.Y += 8;
                            }
                        }
                        if (bosskoordinat.X == 96 + 48 && saygin == 0)
                            bossanimation = 2;
                    }
                    else
                    {
                        bosskoordinat.X -= 8;
                        if (bosskoordinat.X == 96)
                        {
                            bossyon = SpriteEffects.None;
                            if (bossanimation == 2)
                                bossanimation = 0;
                            if (saygin == 0)
                            {
                                saygin = 1;
                                bosskoordinat.Y += 8;
                            }
                        }
                        if (bosskoordinat.X == 936 - 96 && saygin == 0)
                            bossanimation = 2;
                    }
                    if (saygin > 0)
                    {
                        saygin++;
                        if (saygin < 10)
                            bosskoordinat.Y += 8;
                        else if (saygin < 20)
                            bosskoordinat.Y += 4;
                        else if (saygin < 30)
                            bosskoordinat.Y += 2;
                        else if (saygin < 40)
                            bosskoordinat.Y += 1;
                        else if (saygin < 65)
                            bosskoordinat.Y += 0;
                        else if (saygin < 75)
                            bosskoordinat.Y -= 1;
                        else if (saygin < 85)
                            bosskoordinat.Y -= 2;
                        else if (saygin < 95)
                            bosskoordinat.Y -= 4;
                        else if (saygin < 105)
                            bosskoordinat.Y -= 8;
                        else if (saygin < 115)
                            bosskoordinat.Y += 16;
                        else if (saygin < 125)
                            bosskoordinat.Y += 4;
                        else if (saygin < 135)
                            bosskoordinat.Y += 2;
                        else if (saygin < 145)
                            bosskoordinat.Y += 1;
                        else if (saygin < 170)
                            bosskoordinat.Y += 0;
                        else if (saygin < 180)
                            bosskoordinat.Y -= 1;
                        else if (saygin < 190)
                            bosskoordinat.Y -= 2;
                        else if (saygin < 200)
                            bosskoordinat.Y -= 4;
                        else if (saygin < 210)
                            bosskoordinat.Y -= 16;
                        else if (saygin >= 213)
                            saygin = 0;
                    }
                    if (Game1.heroyarasayaci == 0 && Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 96 > Game1.koordinat.X && Game1.koordinat.Y + 96 > bosskoordinat.Y && bosskoordinat.Y + 48 > Game1.koordinat.Y)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                    if (Game1.heroyarasayaci == 0 && bossanimation == 2 && Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 96 > Game1.koordinat.X)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                }
                if (Game1.heroanimation >= 10 && bossyarasayaci == 0 && bosskoordinat.X < 2000)
                {
                    if (Game1.heroyon == SpriteEffects.None && bosskoordinat.X + 96 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                        ist = 0;
                        if (bosscan == 0)
                        {
                            Game1.parcacikanimation = 0;
                            Game1.parcacikkoordinat = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y);
                        }
                    }
                    else if (Game1.heroyon == SpriteEffects.FlipHorizontally && bosskoordinat.X + 96 > Game1.koordinat.X - 27 && Game1.koordinat.X > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                    {
                        bossyarasayaci = 1;
                        bosscan--;
                        ist = 0;
                        if (bosscan == 0)
                        {
                            Game1.parcacikanimation = 0;
                            Game1.parcacikkoordinat = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y);
                        }
                    }
                }
                if (bosscan <= 0)
                {
                    ist++;
                    if (ist < 7)
                        bossanimation = 2;
                    else if (ist < 14)
                        bossanimation = 3;
                    else if (ist < 21)
                        bossanimation = 4;
                    else if (ist < 28)
                        bossanimation = 5;
                    else if (ist < 35)
                    {
                        form = true;
                        bosscan = 8;
                        bosskoordinat = new Vector2(192, 1488 - 96);
                        bossyon = SpriteEffects.None;
                        bossyarasayaci = 0;
                        ist = 29;
                    }
                }
                if (bossyarasayaci > 0)
                {
                    bossyarasayaci++;
                    if (bossyarasayaci >= 120)
                        bossyarasayaci = 0;
                }
            }
            else
            {
                bosser = 1;
                if (bosscan >= 0)
                {
                    if (ist > 0)
                    {
                        ist++;
                        if (ist < 7)
                            bossanimation = 2;
                        else if (ist < 14)
                            bossanimation = 3;
                        else if (ist < 21)
                            bossanimation = 4;
                        else if (ist < 28)
                            bossanimation = 5;
                        else if (ist == 28)
                        {
                            if (bosskoordinat == new Vector2(960, 1536 - 96))
                            {
                                bosskoordinat = new Vector2(192, 1488 - 96);
                                bossyon = SpriteEffects.None;
                            }
                            else
                            {
                                bosskoordinat = new Vector2(960, 1536 - 96);
                                bossyon = SpriteEffects.FlipHorizontally;
                            }
                        }
                        else if (ist < 35)
                            bossanimation = 5;
                        else if (ist < 42)
                            bossanimation = 4;
                        else if (ist < 49)
                            bossanimation = 3;
                        else if (ist < 56)
                            bossanimation = 2;
                        else if (ist == 56)
                        {
                            bossyarasayaci = 0;
                            bossanimation = 0;
                            ist = 0;
                        }
                    }
                    for (int i = 0; i < 24; i++)
                    {
                        if (bossyon == SpriteEffects.None)
                        {
                            ballkoordinat[i].X += 4;
                        }
                        else if (bossyon == SpriteEffects.FlipHorizontally)
                        {
                            ballkoordinat[i].X -= 4;
                        }
                    }
                    if (bossyarasayaci > 0)
                    {
                        for (int i = 0; i < 24; i++)
                            ballkoordinat[i] = new Vector2(4000, 4000);
                        bossyarasayaci++;
                        if (bossyarasayaci == 10)
                        {
                            bossyarasayaci = 0;
                            ist = 1;
                        }
                    }
                    if (ist == 0 && bossyarasayaci == 0)
                    {
                        reader++;
                        for (int i = 0; i < 24; i++)
                        {
                            Random rnd = new Random();
                            int a = rnd.Next(0, 2);
                            if (reader == i * 28)
                                ballkoordinat[i] = new Vector2(bosskoordinat.X + 24, bosskoordinat.Y + a * 48);
                        }
                        if (reader == 24 * 28 + 1)
                            reader = 0;
                        if (reader % 14 < 7)
                            bossanimation = 0;
                        else
                            bossanimation = 1;
                        if (Game1.heroanimation >= 10 && bosskoordinat.X < 2000)
                        {
                            if (Game1.heroyon == SpriteEffects.None && bosskoordinat.X + 48 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                            {
                                bossyarasayaci = 1;
                                bosscan--;
                            }
                            else if (Game1.heroyon == SpriteEffects.FlipHorizontally && bosskoordinat.X + 72 > Game1.koordinat.X - 27 && Game1.koordinat.X > bosskoordinat.X && bosskoordinat.Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > bosskoordinat.Y)
                            {
                                bossyarasayaci = 1;
                                bosscan--;
                            }
                        }
                    }
                    if (Game1.heroyarasayaci == 0)
                    {
                        for (int i = 0; i < 24; i++)
                        {
                            if (Game1.eldekiItemler[0] == 14 || Game1.eldekiItemler[1] == 14 || Game1.eldekiItemler[2] == 14)
                            {
                                if (Game1.heroyon == SpriteEffects.None)
                                {
                                    if (Game1.heroanimation == 6 || Game1.heroanimation == 11)
                                    {
                                        if (Game1.koordinat.X + 48 >= ballkoordinat[i].X && ballkoordinat[i].X + 24 >= Game1.koordinat.X + 39 && Game1.koordinat.Y + 96 >= ballkoordinat[i].Y && ballkoordinat[i].Y + 24 >= Game1.koordinat.Y + 48)
                                        {
                                            ballkoordinat[i] = new Vector2(4000, 4000);
                                            Game1.kalkancan--;
                                        }
                                    }
                                    else if (Game1.heroanimation <= 3 || Game1.heroanimation == 10)
                                    {
                                        if (Game1.koordinat.X + 48 >= ballkoordinat[i].X && ballkoordinat[i].X + 24 >= Game1.koordinat.X + 39 && Game1.koordinat.Y + 42 >= ballkoordinat[i].Y && ballkoordinat[i].Y + 24 >= Game1.koordinat.Y)
                                        {
                                            ballkoordinat[i] = new Vector2(4000, 4000);
                                            Game1.kalkancan--;
                                        }
                                    }
                                }
                                else
                                {
                                    if (Game1.heroanimation == 6 || Game1.heroanimation == 11)
                                    {
                                        if (Game1.koordinat.X + 9 >= ballkoordinat[i].X && ballkoordinat[i].X + 24 >= Game1.koordinat.X && Game1.koordinat.Y + 96 >= ballkoordinat[i].Y && ballkoordinat[i].Y + 24 >= Game1.koordinat.Y + 48)
                                        {
                                            ballkoordinat[i] = new Vector2(4000, 4000);
                                            Game1.kalkancan--;
                                        }
                                    }
                                    else if (Game1.heroanimation <= 3 || Game1.heroanimation == 10)
                                    {
                                        if (Game1.koordinat.X + 9 >= ballkoordinat[i].X && ballkoordinat[i].X + 24 >= Game1.koordinat.X && Game1.koordinat.Y + 42 >= ballkoordinat[i].Y && ballkoordinat[i].Y + 24 >= Game1.koordinat.Y)
                                        {
                                            ballkoordinat[i] = new Vector2(4000, 4000);
                                            Game1.kalkancan--;
                                        }
                                    }
                                }
                            }
                            if (Game1.heroanimation == 6 || Game1.heroanimation == 11)
                            {
                                if (Game1.koordinat.X + 33 > ballkoordinat[i].X && ballkoordinat[i].X + 24 > Game1.koordinat.X + 12 && Game1.koordinat.Y + 96 > ballkoordinat[i].Y && ballkoordinat[i].Y + 24 > Game1.koordinat.Y + 24)
                                {
                                    Game1.herocan--;
                                    Game1.heroyarasayaci = 1;
                                }
                            }
                            else
                            {
                                if (Game1.koordinat.X + 33 > ballkoordinat[i].X && ballkoordinat[i].X + 24 > Game1.koordinat.X + 12 && Game1.koordinat.Y + 96 > ballkoordinat[i].Y && ballkoordinat[i].Y + 24 > Game1.koordinat.Y)
                                {
                                    Game1.herocan--;
                                    Game1.heroyarasayaci = 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 24; i++)
                        ballkoordinat[i] = new Vector2(4000, 4000);
                    KeyboardState klavye = Keyboard.GetState();
                    if (ist == 0)
                        bossanimation = 6;
                    if (((klavye.IsKeyDown(Keys.Z) || klavye.IsKeyDown(Keys.G)) && Game1.eldekiItemler[0] == 13) || ((klavye.IsKeyDown(Keys.X) || klavye.IsKeyDown(Keys.H)) && Game1.eldekiItemler[1] == 13) || ((klavye.IsKeyDown(Keys.C) || klavye.IsKeyDown(Keys.J)) && Game1.eldekiItemler[2] == 13))
                    {
                        if (Game1.koordinat.X + 48 > bosskoordinat.X && bosskoordinat.X + 48 > Game1.koordinat.X)
                        {
                            Game1.parcacikanimation = 0;
                            Game1.parcacikkoordinat = bosskoordinat;
                            ist = 1;
                        }
                    }
                    if (ist > 0)
                    {
                        ist++;
                        if (ist < 7)
                            bossanimation = 7;
                        else if (ist < 14)
                            bossanimation = 8;
                        else if (ist < 300)
                            bossanimation = 9;
                        else if (ist == 300)
                            Game1.menu = 6;
                        if (Game1.koordinat.X > 990)
                            Game1.koordinat.X = 990;
                    }
                }
            }
        }
    }
}
