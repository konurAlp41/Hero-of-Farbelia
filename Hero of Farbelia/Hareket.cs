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
    class Hareket
    {

        public static void HareketEtme()
        {
            KeyboardState klavye = Keyboard.GetState();
                if (Game1.sakarsayac2 < 60)
                    Game1.sakarsayac2++;
                if (Game1.heroanimation < 8 && Game1.herocan > 0 && klavye.IsKeyDown(Keys.Enter) && Game1.sakarsayac2 >= 60)
                {
                    dungeon = false;
                    Game1.menu = 4;
                }
                if ((Game1.heroanimation < 8 || Game1.heroanimation == 10) && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.A) || klavye.IsKeyDown(Keys.Left)) && (Game1.ziplama == 0 || Game1.ziplama > 3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.S))
                {
                    Color[] arkaplanRAR = new Color[1];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y + 98, 1, 1), arkaplanRAR, 0, 1);
                    Color renk = arkaplanRAR[0];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y + 98, 1, 1), arkaplanRAR, 0, 1);
                    Color irenk = arkaplanRAR[0];
                    if (Game1.heroanimation != 10 || (renk == Color.White && irenk == Color.White))
                    {
                        Game1.heroyon = SpriteEffects.FlipHorizontally;
                        Game1.koordinat.X -= 8;
                        arkaplanRAR = new Color[1];
                        Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                        renk = arkaplanRAR[0];
                        Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                        irenk = arkaplanRAR[0];
                        if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                            Game1.koordinat.X += 8;
                    }
                }
                if ((Game1.heroanimation < 8 || Game1.heroanimation == 10) && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.D) || klavye.IsKeyDown(Keys.Right)) && (Game1.ziplama == 0 || Game1.ziplama > 3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.S))
                {
                    Color[] arkaplanRAR = new Color[1];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y + 98, 1, 1), arkaplanRAR, 0, 1);
                    Color renk = arkaplanRAR[0];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y + 98, 1, 1), arkaplanRAR, 0, 1);
                    Color irenk = arkaplanRAR[0];
                    if (Game1.heroanimation != 10 || (renk == Color.White && irenk == Color.White))
                    {
                        Game1.heroyon = SpriteEffects.None;
                        Game1.koordinat.X += 8;
                        arkaplanRAR = new Color[1];
                        Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                        renk = arkaplanRAR[0];
                        Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                        irenk = arkaplanRAR[0];
                        if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                            Game1.koordinat.X -= 8;
                    }
                }
                if (Game1.heroanimation >= 10)
                {
                    Game1.f++;
                    if (Game1.f >= 12)
                    {
                        Game1.heroanimation = 0;
                        Game1.f = 0;
                    }
                }
                else if (Game1.heroanimation >= 8)
                {
                    if (Game1.f % 10 < 5)
                        Game1.heroanimation = 8;
                    else
                        Game1.heroanimation = 9;
                    Game1.f++;
                    if (Game1.f >= 60)
                    {
                        Game1.heroanimation = 0;
                        Game1.f = 0;
                    }
                }
                if (Game1.heroanimation < 10 && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.W) || klavye.IsKeyDown(Keys.Up)) && Game1.ziplama == 0 && !klavye.IsKeyDown(Keys.Down))
                {
                    Game1.ziplama = 1;
                    Game1.koordinat.Y += 8;
                    Color[] arkaplanRAR = new Color[1];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                    Color renk = arkaplanRAR[0];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                    Color irenk = arkaplanRAR[0];
                    if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                    {
                        Game1.koordinat.Y -= 8;
                    }
                    else if (renk == Color.Red && irenk == Color.Red)
                        Game1.menu = 2;
                    else
                        Game1.ziplama = 0;
                }
                else if (Game1.ziplama > 0 && Game1.ziplama < 4)
                    Game1.ziplama++;
                else if (Game1.ziplama > 3)
                {
                    Game1.ziplama++;
                    Game1.koordinat.Y -= 8;
                    if (Game1.ziplama >= 21)
                        Game1.ziplama = 0;
                    Color[] arkaplanRAR = new Color[1];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                    Color renk = arkaplanRAR[0];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                    Color irenk = arkaplanRAR[0];
                    if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                    {
                        Game1.koordinat.Y += 8;
                        Game1.ziplama = 0;
                    }
                }
                else if (Game1.ziplama == 0)
                {
                    Game1.koordinat.Y += 8;
                    Color[] arkaplanRAR = new Color[1];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                    Color renk = arkaplanRAR[0];
                    Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.koordinat.X + 47, (int)Game1.koordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                    Color irenk = arkaplanRAR[0];
                    if (renk == Color.Black || irenk == Color.Black || (renk == Color.Blue && Game1.lanet > 0) || (irenk == Color.Blue && Game1.lanet > 0) || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                        Game1.koordinat.Y -= 8;
                    else if ((renk == Color.Red && irenk == Color.Red) || (renk == Color.Blue && irenk == Color.Blue && Game1.lanet == 0))
                        Game1.menu = 2;
                }
                if (Game1.textZ > 0)
                {
                    Game1.textZ++;
                    if (Game1.textZ >= 310)
                        Game1.textZ = 0;
                }
            dungeon = false;
        }

        public static void Carpisma()
        {
            if (Game1.bulunulanbina == 6)
                Game1.kamera = new Vector2(Game1.dungeonkoordinat.X - 504, Game1.dungeonkoordinat.Y - 284);
            if (Game1.kamera.X < 0)
                Game1.kamera.X = 0;
            else if (Game1.kamera.X > 896)
                Game1.kamera.X = 896;
            if (Game1.kamera.Y < 0)
                Game1.kamera.Y = 0;
            if (Game1.bulunulanbina == 6 && Game1.dungeonsahne == 1 && Game1.dungeonkoordinat.Y > 1430)
                Game1.kamera = new Vector2(0, 1320);
            else if (Game1.bulunulanbina == 6 && Game1.dungeonsahne == 3 && Game1.dungeonkoordinat.Y > 340 && Game1.dungeonkoordinat.Y < 600 && Game1.dungeonkoordinat.X > 1090 && Game1.dungeonkoordinat.X < 1700)
                Game1.kamera = new Vector2(896, 200);
            else if (Game1.bulunulanbina == 6 && Game1.dungeonsahne == 5 && Game1.dungeonkoordinat.X > 1170 && Game1.dungeonkoordinat.Y > 1600)
                Game1.kamera = new Vector2(896, 1320);
            else if (Game1.lanet >= 3 && Game1.sahne == 3 && Game1.koordinat.X < 1024)
                Game1.kamera = new Vector2(0, 1000);
        }

        public static Vector2 uygunkoordinat = new Vector2();
        public static bool dungeon = false;
        public static void Dungeon()
        {
            dungeon = true;
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.sakarsayac2 < 60)
                Game1.sakarsayac2++;
            if (Game1.heroanimation < 10 && Game1.herocan > 0 && klavye.IsKeyDown(Keys.Enter) && Game1.sakarsayac2 >= 60)
            {
                Game1.menu = 4;
                dungeon = true;
            }
            if ((Game1.heroanimation < 8 || Game1.heroanimation == 10) && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.A) || klavye.IsKeyDown(Keys.Left)) && (Game1.ziplama == 0 || Game1.ziplama > 3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.S))
            {
                Game1.heroyon = SpriteEffects.FlipHorizontally;
                Game1.dungeonkoordinat.X -= 8;
                Color[] arkaplanRAR = new Color[1];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X, (int)Game1.dungeonkoordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                Color renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                    Game1.dungeonkoordinat.X += 8;
            }
            if ((Game1.heroanimation < 8 || Game1.heroanimation == 10) && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.D) || klavye.IsKeyDown(Keys.Right)) && (Game1.ziplama == 0 || Game1.ziplama > 3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.S))
            {
                Game1.heroyon = SpriteEffects.None;
                Game1.dungeonkoordinat.X += 8;
                Color[] arkaplanRAR = new Color[1];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 47, (int)Game1.dungeonkoordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                Color renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 47, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                    Game1.dungeonkoordinat.X -= 8;
                if (Game1.dungeonkoordinat.X + 48 > Game1.kapikoordinat.X && Game1.kapikoordinat.X + 48 > Game1.dungeonkoordinat.X && Game1.dungeonkoordinat.Y + 96 > Game1.kapikoordinat.Y && Game1.kapikoordinat.Y + 96 > Game1.dungeonkoordinat.Y)
                {
                    if (Game1.item[23] == 1)
                    {
                        Game1.item[23] = 0;
                        Game1.kapikoordinat = new Vector2(4000, 4000);
                    }
                    else
                    {
                        Game1.dungeonkoordinat.X -= 8;
                        Game1.yaziolantext = "The door is locked";
                        Game1.textZ = 1;
                    }
                }
            }
            if (Game1.heroanimation >= 10)
            {
                Game1.f++;
                if (Game1.f >= 12)
                {
                    Game1.heroanimation = 0;
                    Game1.f = 0;
                }
            }
            if (Game1.heroanimation < 10 && Game1.herocan > 0 && (klavye.IsKeyDown(Keys.W) || klavye.IsKeyDown(Keys.Up)) && Game1.ziplama == 0 && !klavye.IsKeyDown(Keys.Down))
            {
                Game1.ziplama = 1;
                Game1.dungeonkoordinat.Y += 8;
                Color[] arkaplanRAR = new Color[1];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 47, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                {
                    Game1.dungeonkoordinat.Y -= 8;
                }
                else if (renk == Color.Red && irenk == Color.Red)
                    Game1.menu = 2;
                else
                    Game1.ziplama = 0;
            }
            else if (Game1.ziplama > 0 && Game1.ziplama < 4)
                Game1.ziplama++;
            else if (Game1.ziplama > 3)
            {
                Game1.ziplama++;
                Game1.dungeonkoordinat.Y -= 8;
                if (Game1.ziplama >= 21)
                    Game1.ziplama = 0;
                Color[] arkaplanRAR = new Color[1];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X, (int)Game1.dungeonkoordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                Color renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 47, (int)Game1.dungeonkoordinat.Y, 1, 1), arkaplanRAR, 0, 1);
                Color irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                {
                    Game1.dungeonkoordinat.Y += 8;
                    Game1.ziplama = 0;
                }
            }
            else if (Game1.ziplama == 0)
            {
                Game1.dungeonkoordinat.Y += 8;
                Color[] arkaplanRAR = new Color[1];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color renk = arkaplanRAR[0];
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 47, (int)Game1.dungeonkoordinat.Y + 95, 1, 1), arkaplanRAR, 0, 1);
                Color irenk = arkaplanRAR[0];
                if (renk == Color.Black || irenk == Color.Black || (renk == Color.Blue && Game1.lanet > 0) || (irenk == Color.Blue && Game1.lanet > 0) || (renk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (irenk == new Color(0, 0, 25) && Game1.BlockActivater[0]) || (renk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (irenk == new Color(0, 0, 50) && Game1.BlockActivater[1]) || (renk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (irenk == new Color(0, 0, 75) && Game1.BlockActivater[2]) || (renk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (irenk == new Color(0, 0, 100) && Game1.BlockActivater[3]) || (renk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (irenk == new Color(0, 0, 125) && Game1.BlockActivater[4]) || (renk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (irenk == new Color(0, 0, 150) && Game1.BlockActivater[5]) || (renk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (irenk == new Color(0, 0, 175) && Game1.BlockActivater[6]) || (renk == new Color(0, 0, 200) && Game1.BlockActivater[7]) || (irenk == new Color(0, 0, 200) && Game1.BlockActivater[7]))
                {
                    Game1.dungeonkoordinat.Y -= 8;
                    if (Game1.herocan > 0 && (renk == Color.Black || irenk == Color.Black))
                        uygunkoordinat = Game1.dungeonkoordinat;
                }
                else if (renk == Color.Red && irenk == Color.Red)
                    Game1.herocan = 0;
                Game1.texture.GetData<Color>(0, new Rectangle((int)Game1.dungeonkoordinat.X + 40, (int)Game1.dungeonkoordinat.Y + 88, 1, 1), arkaplanRAR, 0, 1);
                renk = arkaplanRAR[0];
                if (renk == Color.Red)
                {
                    if (Game1.herocan != 0)
                    {
                        Game1.herocan = 0;
                        uygunkoordinat = new Vector2(312, 1200);
                    }
                }
            }
            if (Game1.dungeonkoordinat.X + 48 >= Game1.anahtarkoordinat.X && Game1.anahtarkoordinat.X + 48 >= Game1.dungeonkoordinat.X && Game1.dungeonkoordinat.Y + 96 >= Game1.anahtarkoordinat.Y && Game1.anahtarkoordinat.Y + 48 > Game1.dungeonkoordinat.Y)
            {
                Game1.anahtarkoordinat = new Vector2(4000, 4000);
                Game1.anahtaralindi = true;
                Game1.item[23] = 1;
            }
            if (Game1.textZ > 0)
            {
                Game1.textZ++;
                if (Game1.textZ >= 310)
                    Game1.textZ = 0;
            }
        }
    }
}
