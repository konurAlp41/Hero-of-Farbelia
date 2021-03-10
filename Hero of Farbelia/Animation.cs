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
    class Animation
    {
        public static int[] kasabalianimasyon = new int[4];
        public static int C = 0;

        public static void SetHero()
        {
            KeyboardState klavye = Keyboard.GetState();
            C++;
            if (C == 7)
            {
                C = 0;
                if (Game1.parcacikkoordinat.X < 2000)
                {
                    Game1.parcacikanimation++;
                    if (Game1.parcacikanimation == 5)
                    {
                        Game1.parcacikanimation = 0;
                        Game1.parcacikkoordinat = new Vector2(4000, 4000);
                    }
                }
                if (Game1.herocan > 0 && Game1.heroanimation < 8)
                {
                    if ((klavye.IsKeyDown(Keys.Up) || klavye.IsKeyDown(Keys.W)) && Game1.ziplama < 8)
                        Game1.heroanimation = 4;
                    else if (Game1.ziplama > 4)
                        Game1.heroanimation = 5;
                    else if (klavye.IsKeyDown(Keys.Left) || klavye.IsKeyDown(Keys.A) || klavye.IsKeyDown(Keys.D) || klavye.IsKeyDown(Keys.Right))
                    {
                        Game1.heroanimation++;
                        if (Game1.heroanimation >= 4)
                            Game1.heroanimation = 0;
                    }
                    else
                        Game1.heroanimation = 0;
                    if (klavye.IsKeyDown(Keys.Left) || klavye.IsKeyDown(Keys.A))
                        Game1.heroyon = SpriteEffects.FlipHorizontally;
                    else if (klavye.IsKeyDown(Keys.Right) || klavye.IsKeyDown(Keys.D))
                        Game1.heroyon = SpriteEffects.None;
                }
            }
            if (Game1.herocan > 0 && (klavye.IsKeyDown(Keys.Down) || klavye.IsKeyDown(Keys.S)) && Game1.ziplama == 0)
            {
                if (Game1.heroanimation != 11)
                    Game1.heroanimation = 6;
            }
        }

        public static void SetTownsMen()
        {
            if (C == 6)
                for (int i = 0; i < 4; i++)
                {
                    kasabalianimasyon[i]++;
                    if (kasabalianimasyon[i] == 4)
                        kasabalianimasyon[i] = 0;
                }
            for (int i = 0; i < 4; i++)
                if (Game1.kafamindengisin[i])
                    kasabalianimasyon[i] = 0;
        }
    }
}
