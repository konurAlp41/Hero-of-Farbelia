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
    class Canavarlar
    {
        public static int C = 0;
        public static int i = 0;
        public static Vector2 simdilikdepolama = new Vector2();

        public static void Bear()
        {
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 4)
                    Game1.Canavaranimasyon[i] = 0;
            }
            if (Game1.Canavarkoordinat[i].Y == Game1.koordinat.Y && Game1.heroyarasayaci == 0)
            {
                Color[] arkaplanRAR = new Color[1];
                Color renk, irenk;
                if (Game1.Canavarkoordinat[i].X > Game1.koordinat.X)
                {
                    Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                    Game1.Canavarkoordinat[i].X -= 12;
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 90, 1, 1), arkaplanRAR, 0, 1);
                    renk = arkaplanRAR[0];
                    if (renk == Color.Black)
                    {
                        Game1.Canavarkoordinat[i].X += 12;
                    }
                }
                else if (Game1.Canavarkoordinat[i].X < Game1.koordinat.X)
                {
                    Game1.Canavaryon[i] = SpriteEffects.None;
                    Game1.Canavarkoordinat[i].X += 12;
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 90, 1, 1), arkaplanRAR, 0, 1);
                    renk = arkaplanRAR[0];
                    if (renk == Color.Black)
                    {
                        Game1.Canavarkoordinat[i].X -= 12;
                    }
                }
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk != Color.Black || irenk != Color.Black)
                {
                    if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                        Game1.Canavarkoordinat[i].X += 12;
                    else
                        Game1.Canavarkoordinat[i].X -= 12;
                }
            }
            else
            {
                Color[] arkaplanRAR = new Color[1];
                Color renk, irenk;
                if (Game1.Canavaryon[i] == SpriteEffects.None)
                {
                    Game1.Canavarkoordinat[i].X += 6;
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 90, 1, 1), arkaplanRAR, 0, 1);
                    renk = arkaplanRAR[0];
                    if (renk == Color.Black)
                    {
                        Game1.Canavarkoordinat[i].X -= 6;
                        Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                    }
                }
                else if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                {
                    Game1.Canavarkoordinat[i].X -= 6;
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 90, 1, 1), arkaplanRAR, 0, 1);
                    renk = arkaplanRAR[0];
                    if (renk == Color.Black)
                    {
                        Game1.Canavarkoordinat[i].X += 6;
                        Game1.Canavaryon[i] = SpriteEffects.None;
                    }
                }
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk != Color.Black || irenk != Color.Black)
                {
                    if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                    {
                        Game1.Canavarkoordinat[i].X += 6;
                        Game1.Canavaryon[i] = SpriteEffects.None;
                    }
                    else
                    {
                        Game1.Canavarkoordinat[i].X -= 6;
                        Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                    }
                }
            }
            if (Game1.Canavarkoordinat[i].X < 20)
                Game1.Canavarkoordinat[i].X = 20;
            else if (Game1.Canavarkoordinat[i].X > 1819)
                Game1.Canavarkoordinat[i].X = 1819;
        }

        public static int[] ziplama = new int[20];
        public static void Wolf()
        {
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 4)
                    Game1.Canavaranimasyon[i] = 0;
            }
            Color[] arkaplanRAR = new Color[1];
            Color renk, irenk;
            if (Game1.Canavarkoordinat[i].X > Game1.koordinat.X)
            {
                Game1.Canavarkoordinat[i].X -= 5;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black)
                    Game1.Canavarkoordinat[i].X += 5;
            }
            else
            {
                Game1.Canavarkoordinat[i].X += 5;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black)
                    Game1.Canavarkoordinat[i].X -= 5;
            }
            if (ziplama[i] == 0)
            {
                Game1.Canavarkoordinat[i].Y += 8;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y + 98, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == Color.Red || irenk == Color.Red)
                {
                    Game1.Canavarkoordinat[i].Y -= 8;
                    ziplama[i] = 1;
                }
            }
            else
            {
                Game1.Canavarkoordinat[i].Y -= 8;
                ziplama[i]++;
                if (ziplama[i] >= 17)
                    ziplama[i] = 0;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 31, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black)
                {
                    Game1.Canavarkoordinat[i].Y += 8;
                    ziplama[i] = 0;
                }
            }
            if (Game1.Canavarkoordinat[i].X < 20)
                Game1.Canavarkoordinat[i].X = 20;
            else if (Game1.Canavarkoordinat[i].X > 1819)
                Game1.Canavarkoordinat[i].X = 1819;
        }

        public static void Plant()
        {
            Random rnd = new Random();
            if (Game1.Canavaranimasyon[i] > 1)
                Game1.Canavaranimasyon[i] = 0;
            beklemesuresi[i]--;
            if (snoweryon[i])
                snowballer[i].X += 12;
            else
                snowballer[i].X -= 12;
            if (Game1.Canavarkoordinat[i].X > Game1.koordinat.X)
                Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
            else
                Game1.Canavaryon[i] = SpriteEffects.None;
            if (beklemesuresi[i] <= 0)
            {
                if (Game1.Canavaranimasyon[i] == 0)
                {
                    Game1.Canavaranimasyon[i] = 1;
                    beklemesuresi[i] = 40;
                    snowballer[i] = new Vector2(Game1.Canavarkoordinat[i].X + 12, Game1.Canavarkoordinat[i].Y);
                    if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                        snoweryon[i] = false;
                    else
                        snoweryon[i] = true;
                }
                else
                {
                    Game1.Canavaranimasyon[i] = 0;
                    beklemesuresi[i] = rnd.Next(150, 310);
                }
            }
        }

        public static int[] beklemesuresi = new int[20];
        public static int[] hiz = new int[20];
        public static void Mummy()
        {
            Random rnd = new Random();
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 2)
                    Game1.Canavaranimasyon[i] = 0;
            }
            Color[] arkaplanRAR = new Color[1];
            Color renk, irenk;
            if (Game1.Canavaryon[i] == SpriteEffects.None)
            {
                Game1.Canavarkoordinat[i].X += hiz[i];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y + 84, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == new Color(0, 255, 0) || irenk == new Color(0, 255, 0))
                {
                    Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                    Game1.Canavarkoordinat[i].X -= hiz[i];
                }
            }
            if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
            {
                Game1.Canavarkoordinat[i].X -= hiz[i];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == new Color(0, 255, 0) || irenk == new Color(0, 255, 0))
                {
                    Game1.Canavaryon[i] = SpriteEffects.None;
                    Game1.Canavarkoordinat[i].X += hiz[i];
                }
            }
            beklemesuresi[i]--;
            if (beklemesuresi[i] <= 0)
            {
                if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                    Game1.Canavaryon[i] = SpriteEffects.None;
                else if (Game1.Canavaryon[i] == SpriteEffects.None)
                    Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                beklemesuresi[i] = rnd.Next(60, 240);
                hiz[i] = rnd.Next(5, 12);
            }
            int a = rnd.Next(0, 450);
            if (a == 129 && ziplama[i] == 0)
                ziplama[i] = 1;
            if (ziplama[i] == 0)
            {
                Game1.Canavarkoordinat[i].Y += 8;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == Color.Red || irenk == Color.Red)
                {
                    Game1.Canavarkoordinat[i].Y -= 8;
                }
            }
            else
            {
                Game1.Canavarkoordinat[i].Y -= 8;
                ziplama[i]++;
                if (ziplama[i] == 19)
                    ziplama[i] = 0;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black)
                {
                    ziplama[i] = 0;
                    Game1.Canavarkoordinat[i].Y += 8;
                }
            }
            if (Game1.Canavarkoordinat[i].X < 20)
                Game1.Canavarkoordinat[i].X = 20;
            else if (Game1.Canavarkoordinat[i].X > 1819)
                Game1.Canavarkoordinat[i].X = 1819;
        }

        public static void SnowMan()
        {
            Random rnd = new Random();
            if (snoweryon[i])
                snowballer[i].X += 10;
            else
                snowballer[i].X -= 10;
            if (C == 6)
            {
                if (Game1.Canavaranimasyon[i] > 0)
                {
                    Game1.Canavaranimasyon[i]++;
                    if (Game1.Canavaranimasyon[i] == 4 && (snowballer[i].X > 1920 || snowballer[i].X < 0))
                    {
                        snowballer[i] = new Vector2(Game1.Canavarkoordinat[i].X + 12, Game1.Canavarkoordinat[i].Y + 24);
                        if (Game1.Canavaryon[i] == SpriteEffects.None)
                            snoweryon[i] = true;
                        else
                            snoweryon[i] = false;
                    }
                    if (Game1.Canavaranimasyon[i] >= 8)
                        Game1.Canavaranimasyon[i] = 0;
                }
            }
            if (Game1.Canavarkoordinat[i].X > Game1.koordinat.X)
                Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
            else
                Game1.Canavaryon[i] = SpriteEffects.None;
            beklemesuresi[i]--;
            if (beklemesuresi[i] <= 0)
            {
                Game1.Canavaranimasyon[i] = 1;
                beklemesuresi[i] = rnd.Next(150, 310);
            }
        }

        public static int durum = 0;
        public static int bekleme = 0;
        public static void Bird()
        {
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 3)
                    Game1.Canavaranimasyon[i] = 0;
            }
            Random rnd = new Random();
            if (durum == 0)
            {
                if (Game1.Canavarkoordinat[i].X + 400 != Game1.koordinat.X)
                    Game1.Canavarkoordinat[i].X = Game1.koordinat.X - 400;
                Game1.Canavaryon[i] = SpriteEffects.None;
                Game1.Canavarkoordinat[i].Y += 6;
                if (Game1.Canavarkoordinat[i].Y >= Game1.koordinat.Y)
                {
                    Game1.Canavarkoordinat[i].Y = Game1.koordinat.Y;
                    bekleme--;
                    if (bekleme <= 0)
                    {
                        durum = 1;
                        bekleme = rnd.Next(30, 120);
                    }
                }
            }
            else if (durum == 1)
            {
                Game1.Canavarkoordinat[i].X += 12;
                if (Game1.Canavarkoordinat[i].X - 400 >= Game1.koordinat.X)
                    durum = 2;
                Game1.Canavarkoordinat[i].Y = Game1.koordinat.Y;
            }
            else if (durum == 2)
            {
                Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                if (Game1.Canavarkoordinat[i].X - 400 != Game1.koordinat.X)
                    Game1.Canavarkoordinat[i].X = Game1.koordinat.X + 400;
                Game1.Canavarkoordinat[i].Y -= 6;
                if (Game1.Canavarkoordinat[i].Y <= Game1.koordinat.Y - 200)
                    durum = 3;
            }
            else
            {
                Game1.Canavarkoordinat[i].Y = Game1.koordinat.Y - 200;
                Game1.Canavarkoordinat[i].X -= 12;
                if (Game1.Canavarkoordinat[i].X <= Game1.koordinat.X)
                {
                    bekleme--;
                    if (bekleme > 0)
                        Game1.Canavarkoordinat[i].X = Game1.koordinat.X;
                    else
                    {
                        Game1.Canavarkoordinat[i].X -= 12;
                        if (Game1.Canavarkoordinat[i].X + 400 <= Game1.koordinat.X)
                            durum = 0;
                    }
                }
            }
        }

        public static Vector2[] snowballer = new Vector2[20];
        public static bool[] snoweryon = new bool[20];
        public static void Fish()
        {
            if (snoweryon[i])
                snowballer[i].X += 10;
            else
                snowballer[i].X -= 10;
            if (snowballer[i].X < -300 || snowballer[i].X > 2200)
            {
                snowballer[i] = new Vector2(Game1.Canavarkoordinat[i].X + 12, Game1.Canavarkoordinat[i].Y + 12);
                if (Game1.Canavaryon[i] == SpriteEffects.None)
                    snoweryon[i] = true;
                else
                    snoweryon[i] = false;
            }
            Random rnd = new Random();
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 4)
                    Game1.Canavaranimasyon[i] = 0;
            }
            Color[] arkaplanRAR = new Color[1];
            Color renk, irenk;
            if (Game1.Canavaryon[i] == SpriteEffects.None)
            {
                Game1.Canavarkoordinat[i].X += hiz[i];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y + 84, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == new Color(0, 255, 0) || irenk == new Color(0, 255, 0))
                {
                    Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                    Game1.Canavarkoordinat[i].X -= hiz[i];
                }
            }
            if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
            {
                Game1.Canavarkoordinat[i].X -= hiz[i];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == new Color(0, 255, 0) || irenk == new Color(0, 255, 0))
                {
                    Game1.Canavaryon[i] = SpriteEffects.None;
                    Game1.Canavarkoordinat[i].X += hiz[i];
                }
            }
            beklemesuresi[i]--;
            if (beklemesuresi[i] <= 0)
            {
                if (Game1.Canavaryon[i] == SpriteEffects.FlipHorizontally)
                    Game1.Canavaryon[i] = SpriteEffects.None;
                else if (Game1.Canavaryon[i] == SpriteEffects.None)
                    Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                beklemesuresi[i] = rnd.Next(60, 240);
                hiz[i] = rnd.Next(4, 9);
            }
            int a = rnd.Next(0, 450);
            if (a == 129 && ziplama[i] == 0)
                ziplama[i] = 1;
            if (ziplama[i] == 0)
            {
                Game1.Canavarkoordinat[i].Y += 8;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y + 95, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || renk == Color.Red || irenk == Color.Red)
                {
                    Game1.Canavarkoordinat[i].Y -= 8;
                }
            }
            else
            {
                Game1.Canavarkoordinat[i].Y -= 8;
                ziplama[i]++;
                if (ziplama[i] == 19)
                    ziplama[i] = 0;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X + 47, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.Canavarkoordinat[i].X, (int)Game1.Canavarkoordinat[i].Y, 1, 1), arkaplanRAR, 0, 1);
                irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black)
                {
                    ziplama[i] = 0;
                    Game1.Canavarkoordinat[i].Y += 8;
                }
            }

            if (Game1.Canavarkoordinat[i].X < 20)
                Game1.Canavarkoordinat[i].X = 20;
            else if (Game1.Canavarkoordinat[i].X > 1819)
                Game1.Canavarkoordinat[i].X = 1819;
        }

        public static void Eye()
        {
            if (C == 6)
            {
                Game1.Canavaranimasyon[i]++;
                if (Game1.Canavaranimasyon[i] >= 3)
                    Game1.Canavaranimasyon[i] = 0;
            }
            if (Game1.Canavarkoordinat[i].X > Game1.koordinat.X)
            {
                Game1.Canavaryon[i] = SpriteEffects.FlipHorizontally;
                if (Game1.heroyon == SpriteEffects.FlipHorizontally)
                {
                    Game1.Canavarkoordinat[i].X -= 6;
                    if (Game1.Canavarkoordinat[i].Y > Game1.koordinat.Y)
                        Game1.Canavarkoordinat[i].Y -= 5;
                    else if (Game1.Canavarkoordinat[i].Y < Game1.koordinat.Y)
                        Game1.Canavarkoordinat[i].Y += 5;
                }
            }
            else if (Game1.Canavarkoordinat[i].X < Game1.koordinat.X)
            {
                Game1.Canavaryon[i] = SpriteEffects.None;
                if (Game1.heroyon == SpriteEffects.None)
                {
                    Game1.Canavarkoordinat[i].X += 6;
                    if (Game1.Canavarkoordinat[i].Y > Game1.koordinat.Y)
                        Game1.Canavarkoordinat[i].Y -= 5;
                    else if (Game1.Canavarkoordinat[i].Y < Game1.koordinat.Y)
                        Game1.Canavarkoordinat[i].Y += 5;
                }
            }
        }

        public static void HareketEtme()
        {
            if (Hareket.dungeon)
            {
                simdilikdepolama = Game1.koordinat;
                Game1.koordinat = Game1.dungeonkoordinat;
            }
            C++;
            if (C >= 7)
                C = 0;
            for (i = 0; i < Game1.Canavarsayisi; i++)
            {
                if (Game1.Canavaryarasayac[i] == 0 && Game1.Canavarkoordinat[i].X < 2000)
                {
                    if (Game1.Canavartipi[i] == 0)
                        Canavarlar.Bear();
                    else if (Game1.Canavartipi[i] == 1)
                        Canavarlar.Wolf();
                    else if (Game1.Canavartipi[i] == 2)
                        Canavarlar.Plant();
                    else if (Game1.Canavartipi[i] == 3 || Game1.Canavartipi[i] == 4)
                        Canavarlar.Mummy();
                    else if (Game1.Canavartipi[i] == 5)
                        Canavarlar.SnowMan();
                    else if (Game1.Canavartipi[i] == 6)
                        Canavarlar.Bird();
                    else if (Game1.Canavartipi[i] == 7)
                        Canavarlar.Fish();
                    else if (Game1.Canavartipi[i] == 8)
                        Canavarlar.Eye();
                }
                else if (Game1.Canavarkoordinat[i].X > 2000)
                    snowballer[i] = new Vector2(4000, 4000);
            }
        }

        public static void Carpisma()
        {
            for (i = 0; i < Game1.Canavarsayisi; i++)
            {
                if (Game1.heroyarasayaci == 0 && (Game1.Canavartipi[i] == 2 || Game1.Canavartipi[i] == 7 || Game1.Canavartipi[i] == 5))
                {
                    if (Game1.eldekiItemler[0] == 14 || Game1.eldekiItemler[1] == 14 || Game1.eldekiItemler[2] == 14)
                    {
                        if (Game1.heroyon == SpriteEffects.None)
                        {
                            if (Game1.heroanimation == 6)
                            {
                                if (Game1.koordinat.X + 48 >= snowballer[i].X && snowballer[i].X + 24 >= Game1.koordinat.X + 39 && Game1.koordinat.Y + 96 >= snowballer[i].Y && snowballer[i].Y + 24 >= Game1.koordinat.Y + 48)
                                {
                                    snowballer[i] = new Vector2(4000, 4000);
                                    Game1.kalkancan--;
                                }
                            }
                            else if (Game1.heroanimation <= 3)
                            {
                                if (Game1.koordinat.X + 48 >= snowballer[i].X && snowballer[i].X + 24 >= Game1.koordinat.X + 39 && Game1.koordinat.Y + 42 >= snowballer[i].Y && snowballer[i].Y + 24 >= Game1.koordinat.Y)
                                {
                                    snowballer[i] = new Vector2(4000, 4000);
                                    Game1.kalkancan--;
                                }
                            }
                        }
                        else
                        {
                            if (Game1.heroanimation == 6)
                            {
                                if (Game1.koordinat.X + 9 >= snowballer[i].X && snowballer[i].X + 24 >= Game1.koordinat.X && Game1.koordinat.Y + 96 >= snowballer[i].Y && snowballer[i].Y + 24 >= Game1.koordinat.Y + 48)
                                {
                                    snowballer[i] = new Vector2(4000, 4000);
                                    Game1.kalkancan--;
                                }
                            }
                            else if (Game1.heroanimation <= 3)
                            {
                                if (Game1.koordinat.X + 9 >= snowballer[i].X && snowballer[i].X + 24 >= Game1.koordinat.X && Game1.koordinat.Y + 42 >= snowballer[i].Y && snowballer[i].Y + 24 >= Game1.koordinat.Y)
                                {
                                    snowballer[i] = new Vector2(4000, 4000);
                                    Game1.kalkancan--;
                                }
                            }
                        }
                    }
                    if (Game1.heroanimation == 6 || Game1.heroanimation == 11)
                    {
                        if (Game1.koordinat.X + 33 > snowballer[i].X && snowballer[i].X + 24 > Game1.koordinat.X + 12 && Game1.koordinat.Y + 96 > snowballer[i].Y && snowballer[i].Y + 24 > Game1.koordinat.Y + 24)
                        {
                            Game1.herocan--;
                            Game1.heroyarasayaci = 1;
                        }
                    }
                    else
                    {
                        if (Game1.koordinat.X + 33 > snowballer[i].X && snowballer[i].X + 24 > Game1.koordinat.X + 12 && Game1.koordinat.Y + 96 > snowballer[i].Y && snowballer[i].Y + 24 > Game1.koordinat.Y)
                        {
                            Game1.herocan--;
                            Game1.heroyarasayaci = 1;
                        }
                    }
                }
                if (Game1.Canavartipi[i] == 5 && Game1.Canavaranimasyon[i] == 0)
                {
                }
                else if (Game1.Canavartipi[i] == 6 || Game1.Canavartipi[i] == 8 || Game1.Canavartipi[i] == 2)
                {
                    if (Game1.heroanimation == 6 && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 9 && Game1.koordinat.X + 39 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 39 > Game1.koordinat.Y && Game1.koordinat.Y + 96 > Game1.Canavarkoordinat[i].Y + 18 && Game1.Canavaryarasayac[i] == 0 && Game1.heroyarasayaci == 0 && Game1.Canavarcan[i] > 0)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                    else if (Game1.heroanimation != 6 && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 9 && Game1.koordinat.X + 39 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 39 > Game1.koordinat.Y && Game1.koordinat.Y + 96 > Game1.Canavarkoordinat[i].Y && Game1.Canavaryarasayac[i] == 0 && Game1.heroyarasayaci == 0 && Game1.Canavarcan[i] > 0)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                }
                else
                {
                    if (Game1.heroanimation == 6 && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 9 && Game1.koordinat.X + 39 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 96 > Game1.koordinat.Y + 18 && Game1.koordinat.Y + 96 > Game1.Canavarkoordinat[i].Y && Game1.Canavaryarasayac[i] == 0 && Game1.heroyarasayaci == 0 && Game1.Canavarcan[i] > 0)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                    else if (Game1.heroanimation != 6 && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 9 && Game1.koordinat.X + 39 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 96 > Game1.koordinat.Y && Game1.koordinat.Y + 96 > Game1.Canavarkoordinat[i].Y && Game1.Canavaryarasayac[i] == 0 && Game1.heroyarasayaci == 0 && Game1.Canavarcan[i] > 0)
                    {
                        Game1.herocan--;
                        Game1.heroyarasayaci = 1;
                    }
                }
                if (Game1.heroanimation >= 10 && Game1.Canavaryarasayac[i] == 0)
                {
                    if (Game1.Canavartipi[i] == 5 && Game1.Canavaranimasyon[i] == 0)
                    {
                    }
                    else if (Game1.Canavartipi[i] == 6 || Game1.Canavartipi[i] == 8 || Game1.Canavartipi[i] == 2)
                    {
                        if (Game1.heroyon == SpriteEffects.None && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 48 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > Game1.Canavarkoordinat[i].Y)
                            Game1.Canavaryarasayac[i] = 1;
                        else if (Game1.heroyon == SpriteEffects.FlipHorizontally && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X - 27 && Game1.koordinat.X > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 48 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > Game1.Canavarkoordinat[i].Y)
                            Game1.Canavaryarasayac[i] = 1;
                    }
                    else
                    {
                        if (Game1.heroyon == SpriteEffects.None && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X + 48 && Game1.koordinat.X + 75 > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > Game1.Canavarkoordinat[i].Y)
                            Game1.Canavaryarasayac[i] = 1;
                        else if (Game1.heroyon == SpriteEffects.FlipHorizontally && Game1.Canavarkoordinat[i].X + 48 > Game1.koordinat.X - 27 && Game1.koordinat.X > Game1.Canavarkoordinat[i].X && Game1.Canavarkoordinat[i].Y + 96 > Game1.koordinat.Y + 45 && Game1.koordinat.Y + 54 > Game1.Canavarkoordinat[i].Y)
                            Game1.Canavaryarasayac[i] = 1;
                    }
                }
            }
        }

        public static void YaraBere()
        {
            Random rnd = new Random();
            for (i = 0; i < Game1.Canavarsayisi; i++)
            {
                if (Game1.Canavaryarasayac[i] > 0)
                {
                    if (Game1.Canavaryarasayac[i] == 1)
                    {
                        if (Game1.eldekiItemler[0] == 8 || Game1.eldekiItemler[1] == 8 || Game1.eldekiItemler[2] == 8)
                            Game1.Canavarcan[i]--;
                        else if (Game1.eldekiItemler[0] == 9 || Game1.eldekiItemler[1] == 9 || Game1.eldekiItemler[2] == 9)
                            Game1.Canavarcan[i] -= 2;
                        else if (Game1.eldekiItemler[0] == 10 || Game1.eldekiItemler[1] == 10 || Game1.eldekiItemler[2] == 10)
                            Game1.Canavarcan[i] -= 3;
                        else if (Game1.eldekiItemler[0] == 11 || Game1.eldekiItemler[1] == 11 || Game1.eldekiItemler[2] == 11)
                            Game1.Canavarcan[i] -= 4;
                        else if (Game1.eldekiItemler[0] == 12 || Game1.eldekiItemler[1] == 12 || Game1.eldekiItemler[2] == 12)
                            Game1.Canavarcan[i] -= 5;
                    }
                    Game1.Canavaryarasayac[i]++;
                    if (Game1.Canavaryarasayac[i] >= 40)
                        Game1.Canavaryarasayac[i] = 0;
                }
                if (Game1.Canavarcan[i] <= 0)
                {
                    Game1.parcacikanimation = 0;
                    Game1.parcacikkoordinat = Game1.Canavarkoordinat[i];
                    Game1.Canavarkoordinat[i] = new Vector2(4000, 4000);
                    Game1.Canavarcan[i] = 10;
                    if (Game1.Canavartipi[i] == 0 || Game1.Canavartipi[i] == 1)
                    {
                        int a = rnd.Next(0, 10);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[27]++;
                            Game1.yaziolantext = "You gained a monster skin.";
                            Game1.textZ = 1;
                        }
                    }
                    else if (Game1.Canavartipi[i] == 6)
                    {
                        int a = rnd.Next(0, 8);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[28]++;
                            Game1.yaziolantext = "You gained a feather.";
                            Game1.textZ = 1;
                        }
                    }
                    else if (Game1.Canavartipi[i] == 7)
                    {
                        int a = rnd.Next(0, 14);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[26]++;
                            Game1.yaziolantext = "You gained a meat.";
                            Game1.textZ = 1;
                        }
                    }
                    else if (Game1.Canavartipi[i] == 4)
                    {
                        int a = rnd.Next(0, 14);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[25]++;
                            Game1.yaziolantext = "You gained a skeleton bone.";
                            Game1.textZ = 1;
                        }
                    }
                    else if (Game1.Canavartipi[i] == 3 && Game1.sahne < 7)
                    {
                        int a = rnd.Next(0, 4);
                        if ((a == 1 || a == 2) && Game1.item[2] == 0)
                        {
                            Game1.item[2] = 1;
                            Game1.yaziolantext = "You gained blue yakub.";
                            Game1.textZ = 1;
                        }
                    }
                    else if (Game1.Canavartipi[i] == 2 && Game1.item[24] == 0)
                    {
                        int a = rnd.Next(0, 12);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[24] = 1;
                            Game1.yaziolantext = "You gained a tomatoe";
                            Game1.textZ = 1;
                        }
                    }
                    if (Game1.Canavartipi[i] == 7 && Game1.item[7] == 0 && Game1.konustumulan && Game1.sahne == 15)
                    {
                        int a = rnd.Next(0, 4);
                        if (a == 1 || a == 2)
                        {
                            Game1.item[7] = 1;
                            Game1.yaziolantext = "You gained pink yakub.";
                            Game1.textZ = 1;
                        }
                    }
                }
            }
        }
    }
}
