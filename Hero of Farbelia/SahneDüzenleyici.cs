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
    class SahneDüzenleyici
    {
        public static bool firstday = true;
        public static int r = 0;
        public static void Dungeon()
        {
            if (Game1.dungeonkoordinat.X <= 8)
            {
                for (int i = 0; i < 20; i++)
                    Game1.canavaryenitip[i] = 0;
                if (Game1.dungeonsahne % 2 == 0)
                {
                    Game1.menu = 1;
                    Game1.bulunulanbina = -1;
                    if (Game1.sahne == 1)
                    {
                        Game1.koordinat = new Vector2(1032, 1776 - 96);
                        Game1.dungeonkoordinat = new Vector2(1032, 1776 - 96);
                        Canavarlar.simdilikdepolama = new Vector2(1032, 1776 - 96);
                        Game1.SAVEkoordinat = new Vector2(1032, 1776 - 96);
                    }
                    else if (Game1.sahne == 23)
                    {
                        Game1.koordinat = new Vector2(1080, 1776 - 96);
                        Game1.dungeonkoordinat = new Vector2(1080, 1776 - 96);
                        Canavarlar.simdilikdepolama = new Vector2(1080, 1776 - 96);
                        Game1.SAVEkoordinat = new Vector2(1080, 1776 - 96);
                    }
                    else if (Game1.sahne == 31)
                    {
                        Game1.koordinat = new Vector2(1056, 1728 - 96);
                        Game1.dungeonkoordinat = new Vector2(1056, 1728 - 96);
                        Canavarlar.simdilikdepolama = new Vector2(1056, 1728 - 96);
                        Game1.SAVEkoordinat = new Vector2(1056, 1728 - 96);
                    }
                }
                else
                {
                    firstday = true;
                    Game1.dungeonkoordinat.X = 1864;
                    Game1.dungeonsahne--;
                    Random rnd = new Random();
                    r = rnd.Next(0, 8);
                }
            }
            else if (Game1.dungeonkoordinat.X >= 1865)
            {
                firstday = true;
                Game1.dungeonkoordinat.X = 16;
                Game1.dungeonsahne++;
            }
            if (Game1.dungeonsahne == 0)
            {
                Game1.SAVEkoordinat = new Vector2(1032, 1776 - 96);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 12;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(528, 816 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1056, 1200);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 0;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 5;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1344, 1200);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 0;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 5;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1296, 1728 - 96);
                    Game1.canavaryenitip[3] = 1;

                    Game1.Canavartipi[4] = 0;
                    Game1.Canavaryarasayac[4] = 0;
                    Game1.Canavarcan[4] = 5;
                    Game1.Canavaranimasyon[4] = 0;
                    Game1.Canavaryon[4] = SpriteEffects.None;
                    Game1.Canavarkoordinat[4] = new Vector2(1008, 1728 - 96);
                    Game1.canavaryenitip[4] = 1;

                    Game1.Canavartipi[5] = 0;
                    Game1.Canavaryarasayac[5] = 0;
                    Game1.Canavarcan[5] = 5;
                    Game1.Canavaranimasyon[5] = 0;
                    Game1.Canavaryon[5] = SpriteEffects.None;
                    Game1.Canavarkoordinat[5] = new Vector2(576, 1728 - 96);
                    Game1.canavaryenitip[5] = 1;

                    Game1.Canavartipi[6] = 1;
                    Game1.Canavaryarasayac[6] = 0;
                    Game1.Canavarcan[6] = 3;
                    Game1.Canavaranimasyon[6] = 0;
                    Game1.Canavaryon[6] = SpriteEffects.None;
                    Game1.Canavarkoordinat[6] = new Vector2(1398, 1584 - 96);
                    Game1.canavaryenitip[6] = 1;

                    Game1.Canavartipi[7] = 1;
                    Game1.Canavaryarasayac[7] = 0;
                    Game1.Canavarcan[7] = 3;
                    Game1.Canavaranimasyon[7] = 0;
                    Game1.Canavaryon[7] = SpriteEffects.None;
                    Game1.Canavarkoordinat[7] = new Vector2(1056, 1488);
                    Game1.canavaryenitip[7] = 1;

                    Game1.Canavartipi[8] = 1;
                    Game1.Canavaryarasayac[8] = 0;
                    Game1.Canavarcan[8] = 3;
                    Game1.Canavaranimasyon[8] = 0;
                    Game1.Canavaryon[8] = SpriteEffects.None;
                    Game1.Canavarkoordinat[8] = new Vector2(1776, 1104);
                    Game1.canavaryenitip[8] = 1;

                    Game1.Canavartipi[9] = 1;
                    Game1.Canavaryarasayac[9] = 0;
                    Game1.Canavarcan[9] = 3;
                    Game1.Canavaranimasyon[9] = 0;
                    Game1.Canavaryon[9] = SpriteEffects.None;
                    Game1.Canavarkoordinat[9] = new Vector2(528, 816 - 96);
                    Game1.canavaryenitip[9] = 1;

                    Game1.Canavartipi[10] = 1;
                    Game1.Canavaryarasayac[10] = 0;
                    Game1.Canavarcan[10] = 3;
                    Game1.Canavaranimasyon[10] = 0;
                    Game1.Canavaryon[10] = SpriteEffects.None;
                    Game1.Canavarkoordinat[10] = new Vector2(1536, 768 - 96);
                    Game1.canavaryenitip[10] = 1;

                    Game1.Canavartipi[11] = 1;
                    Game1.Canavaryarasayac[11] = 0;
                    Game1.Canavarcan[11] = 3;
                    Game1.Canavaranimasyon[11] = 0;
                    Game1.Canavaryon[11] = SpriteEffects.None;
                    Game1.Canavarkoordinat[11] = new Vector2(1056, 912 - 96);
                    Game1.canavaryenitip[11] = 1;
                }

                if (Game1.anahtaralindi && Game1.item[23] == 0)
                    Game1.kapikoordinat = new Vector2(4000, 4000);
                else
                    Game1.kapikoordinat = new Vector2(1152, 384 - 96);
                if (Game1.anahtaralindi)
                    Game1.anahtarkoordinat = new Vector2(4000, 4000);
                else
                    Game1.anahtarkoordinat = new Vector2(1440, 1584 - 48);
                Game1.sahnebloksayisi = 15;
                Game1.sahnebloktipi[0] = 1;
                Game1.sahneblokkoordinat[0] = new Vector2(480, 1104);
                Game1.sahnebloktipi[1] = 0;
                Game1.sahneblokkoordinat[1] = new Vector2(432, 1008);
                Game1.sahnebloktipi[2] = 2;
                Game1.sahneblokkoordinat[2] = new Vector2(480, 912);
                Game1.sahnebloktipi[3] = 0;
                Game1.sahneblokkoordinat[3] = new Vector2(816, 1632);
                Game1.sahnebloktipi[4] = 1;
                Game1.sahneblokkoordinat[4] = new Vector2(816, 1632 - 96);
                Game1.sahnebloktipi[5] = 2;
                Game1.sahneblokkoordinat[5] = new Vector2(816, 1632 - 192);
                Game1.sahnebloktipi[6] = 0;
                Game1.sahneblokkoordinat[6] = new Vector2(816, 1632 - (96 * 3));
                Game1.sahnebloktipi[7] = 1;
                Game1.sahneblokkoordinat[7] = new Vector2(816, 1632 - (96 * 4));
                Game1.sahnebloktipi[8] = 2;
                Game1.sahneblokkoordinat[8] = new Vector2(816, 1632 - (96 * 5));
                Game1.sahnebloktipi[9] = 0;
                Game1.sahneblokkoordinat[9] = new Vector2(816, 1632 - (96 * 6));
                Game1.sahnebloktipi[10] = 1;
                Game1.sahneblokkoordinat[10] = new Vector2(816, 1632 - (96 * 7));
                Game1.sahnebloktipi[11] = 2;
                Game1.sahneblokkoordinat[11] = new Vector2(864, 816);
                Game1.sahnebloktipi[12] = 0;
                Game1.sahneblokkoordinat[12] = new Vector2(864, 816 - 96);
                Game1.sahnebloktipi[13] = 1;
                Game1.sahneblokkoordinat[13] = new Vector2(864, 816 - 192);
                Game1.sahnebloktipi[14] = 2;
                Game1.sahneblokkoordinat[14] = new Vector2(864, 816 - 192 - 96);
            }
            else if (Game1.dungeonsahne == 1)
            {
                Game1.SAVEkoordinat = new Vector2(1032, 1776 - 96);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 12;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(336, 720 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(720, 720 - 96);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 0;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 5;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(912, 624 - 96);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 0;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 5;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1368, 624 - 96);
                    Game1.canavaryenitip[3] = 1;

                    Game1.Canavartipi[4] = 0;
                    Game1.Canavaryarasayac[4] = 0;
                    Game1.Canavarcan[4] = 5;
                    Game1.Canavaranimasyon[4] = 0;
                    Game1.Canavaryon[4] = SpriteEffects.None;
                    Game1.Canavarkoordinat[4] = new Vector2(1248, 1152 - 96);
                    Game1.canavaryenitip[4] = 1;

                    Game1.Canavartipi[5] = 0;
                    Game1.Canavaryarasayac[5] = 0;
                    Game1.Canavarcan[5] = 5;
                    Game1.Canavaranimasyon[5] = 0;
                    Game1.Canavaryon[5] = SpriteEffects.None;
                    Game1.Canavarkoordinat[5] = new Vector2(1632, 1152 - 96);
                    Game1.canavaryenitip[5] = 1;

                    Game1.Canavartipi[6] = 0;
                    Game1.Canavaryarasayac[6] = 0;
                    Game1.Canavarcan[6] = 5;
                    Game1.Canavaranimasyon[6] = 0;
                    Game1.Canavaryon[6] = SpriteEffects.None;
                    Game1.Canavarkoordinat[6] = new Vector2(792, 1248 - 96);
                    Game1.canavaryenitip[6] = 1;

                    Game1.Canavartipi[7] = 1;
                    Game1.Canavaryarasayac[7] = 0;
                    Game1.Canavarcan[7] = 3;
                    Game1.Canavaranimasyon[7] = 0;
                    Game1.Canavaryon[7] = SpriteEffects.None;
                    Game1.Canavarkoordinat[7] = new Vector2(1152, 960);
                    Game1.canavaryenitip[7] = 1;

                    Game1.Canavartipi[8] = 1;
                    Game1.Canavaryarasayac[8] = 0;
                    Game1.Canavarcan[8] = 3;
                    Game1.Canavaranimasyon[8] = 0;
                    Game1.Canavaryon[8] = SpriteEffects.None;
                    Game1.Canavarkoordinat[8] = new Vector2(1298 - 48, 384);
                    Game1.canavaryenitip[8] = 1;

                    Game1.Canavartipi[9] = 1;
                    Game1.Canavaryarasayac[9] = 0;
                    Game1.Canavarcan[9] = 3;
                    Game1.Canavaranimasyon[9] = 0;
                    Game1.Canavaryon[9] = SpriteEffects.None;
                    Game1.Canavarkoordinat[9] = new Vector2(1298 - 248, 384);
                    Game1.canavaryenitip[9] = 1;
                }

                Game1.anahtarkoordinat = new Vector2(4000, 4000);
                Game1.kapikoordinat = new Vector2(4000, 4000);
                Game1.sahnebloksayisi = 0;
            }
            else if (Game1.dungeonsahne == 2)
            {
                Game1.SAVEkoordinat = new Vector2(1080, 1776 - 96);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 16;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(624, 528 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1008, 192 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 5;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1008, 192 - 96);
                    Game1.canavaryenitip[2] = 2;

                    Game1.Canavartipi[3] = 7;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1056, 672 - 96);

                    Game1.Canavartipi[4] = 7;
                    Game1.Canavaryarasayac[4] = 0;
                    Game1.Canavarcan[4] = 8;
                    Game1.Canavaranimasyon[4] = 0;
                    Game1.Canavaryon[4] = SpriteEffects.None;
                    Game1.Canavarkoordinat[4] = new Vector2(672, 1200 - 96);

                    Game1.Canavartipi[5] = 1;
                    Game1.Canavaryarasayac[5] = 0;
                    Game1.Canavarcan[5] = 8;
                    Game1.Canavaranimasyon[5] = 0;
                    Game1.Canavaryon[5] = SpriteEffects.None;
                    Game1.Canavarkoordinat[5] = new Vector2(1248, 960);
                    Game1.canavaryenitip[5] = 2;

                    Game1.Canavartipi[6] = 7;
                    Game1.Canavaryarasayac[6] = 0;
                    Game1.Canavarcan[6] = 8;
                    Game1.Canavaranimasyon[6] = 0;
                    Game1.Canavaryon[6] = SpriteEffects.None;
                    Game1.Canavarkoordinat[6] = new Vector2(1344, 1440 - 96);

                    Game1.Canavartipi[7] = 7;
                    Game1.Canavaryarasayac[7] = 0;
                    Game1.Canavarcan[7] = 8;
                    Game1.Canavaranimasyon[7] = 0;
                    Game1.Canavaryon[7] = SpriteEffects.None;
                    Game1.Canavarkoordinat[7] = new Vector2(1056, 1488 - 96);

                    Game1.Canavartipi[8] = 7;
                    Game1.Canavaryarasayac[8] = 0;
                    Game1.Canavarcan[8] = 8;
                    Game1.Canavaranimasyon[8] = 0;
                    Game1.Canavaryon[8] = SpriteEffects.None;
                    Game1.Canavarkoordinat[8] = new Vector2(480, 1440 - 96);

                    Game1.Canavartipi[9] = 7;
                    Game1.Canavaryarasayac[9] = 0;
                    Game1.Canavarcan[9] = 8;
                    Game1.Canavaranimasyon[9] = 0;
                    Game1.Canavaryon[9] = SpriteEffects.None;
                    Game1.Canavarkoordinat[9] = new Vector2(744, 1440 - 96);

                    Game1.Canavartipi[10] = 7;
                    Game1.Canavaryarasayac[10] = 0;
                    Game1.Canavarcan[10] = 8;
                    Game1.Canavaranimasyon[10] = 0;
                    Game1.Canavaryon[10] = SpriteEffects.None;
                    Game1.Canavarkoordinat[10] = new Vector2(336, 1872 - 96);

                    Game1.Canavartipi[11] = 7;
                    Game1.Canavaryarasayac[11] = 0;
                    Game1.Canavarcan[11] = 8;
                    Game1.Canavaranimasyon[11] = 0;
                    Game1.Canavaryon[11] = SpriteEffects.None;
                    Game1.Canavarkoordinat[11] = new Vector2(624, 1872 - 96);

                    Game1.Canavartipi[12] = 1;
                    Game1.Canavaryarasayac[12] = 0;
                    Game1.Canavarcan[12] = 8;
                    Game1.Canavaranimasyon[12] = 0;
                    Game1.Canavaryon[12] = SpriteEffects.None;
                    Game1.Canavarkoordinat[12] = new Vector2(624, 1872 - 96);
                    Game1.canavaryenitip[12] = 2;

                    Game1.Canavartipi[13] = 7;
                    Game1.Canavaryarasayac[13] = 0;
                    Game1.Canavarcan[13] = 8;
                    Game1.Canavaranimasyon[13] = 0;
                    Game1.Canavaryon[13] = SpriteEffects.None;
                    Game1.Canavarkoordinat[13] = new Vector2(864, 1680 - 96);

                    Game1.Canavartipi[14] = 7;
                    Game1.Canavaryarasayac[14] = 0;
                    Game1.Canavarcan[14] = 8;
                    Game1.Canavaranimasyon[14] = 0;
                    Game1.Canavaryon[14] = SpriteEffects.None;
                    Game1.Canavarkoordinat[14] = new Vector2(1228, 1680 - 96);

                    Game1.Canavartipi[15] = 7;
                    Game1.Canavaryarasayac[15] = 0;
                    Game1.Canavarcan[15] = 8;
                    Game1.Canavaranimasyon[15] = 0;
                    Game1.Canavaryon[15] = SpriteEffects.None;
                    Game1.Canavarkoordinat[15] = new Vector2(1528, 1680 - 96);
                }
                Game1.anahtarkoordinat = new Vector2(4000, 4000);
                Game1.kapikoordinat = new Vector2(4000, 4000);
                Game1.sahnebloksayisi = 15;
                Game1.sahnebloktipi[0] = 3;
                Game1.sahneblokkoordinat[0] = new Vector2(240, 1200);
                Game1.sahnebloktipi[1] = 5;
                Game1.sahneblokkoordinat[1] = new Vector2(240, 1200 - 96);
                Game1.sahnebloktipi[2] = 4;
                Game1.sahneblokkoordinat[2] = new Vector2(240, 1200 - 192);
                Game1.sahnebloktipi[3] = 3;
                Game1.sahneblokkoordinat[3] = new Vector2(240, 1200 - 192 - 96);
                Game1.sahnebloktipi[4] = 5;
                Game1.sahneblokkoordinat[4] = new Vector2(240, 1200 - 192 - 192);
                Game1.sahnebloktipi[5] = 4;
                Game1.sahneblokkoordinat[5] = new Vector2(240, 1200 - 192 - 192 - 96);
                Game1.sahnebloktipi[6] = 3;
                Game1.sahneblokkoordinat[6] = new Vector2(240, 1200 - 192 - 192 - 192);
                Game1.sahnebloktipi[7] = 3;
                Game1.sahneblokkoordinat[7] = new Vector2(1584, 912);
                Game1.sahnebloktipi[8] = 5;
                Game1.sahneblokkoordinat[8] = new Vector2(1728, 912 - 48);
                Game1.sahnebloktipi[9] = 4;
                Game1.sahneblokkoordinat[9] = new Vector2(1680, 912 - 192 + 48);
                Game1.sahnebloktipi[10] = 3;
                Game1.sahneblokkoordinat[10] = new Vector2(1680, 912 - 192);
                Game1.sahnebloktipi[11] = 5;
                Game1.sahneblokkoordinat[11] = new Vector2(1632, 912 - 192 - 192 + 48);
                Game1.sahnebloktipi[12] = 4;
                Game1.sahneblokkoordinat[12] = new Vector2(1728, 912 - 192 - 192 - 96 + 48);
                Game1.sahnebloktipi[13] = 3;
                Game1.sahneblokkoordinat[13] = new Vector2(1680, 912 - 192 - 192 - 192 + 48);
                Game1.sahnebloktipi[14] = 4;
                Game1.sahneblokkoordinat[14] = new Vector2(1728, 912 - 192 - 192 - 192 - 96 + 48);
            }
            else if (Game1.dungeonsahne == 3)
            {
                Game1.SAVEkoordinat = new Vector2(1080, 1776 - 96);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(96, 144 - 96);
                    Game1.canavaryenitip[1] = 0;

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1596, 144 - 96);
                    Game1.canavaryenitip[2] = 0;

                    Game1.Canavartipi[3] = 7;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1096, 144 - 96);
                    Game1.canavaryenitip[3] = 0;

                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(596, 144 - 96);
                    Game1.canavaryenitip[0] = 0;
                }
                Game1.anahtarkoordinat = new Vector2(4000, 4000);
                Game1.kapikoordinat = new Vector2(4000, 4000);
                Game1.sahnebloksayisi = 13;
                Game1.sahnebloktipi[0] = 4;
                Game1.sahneblokkoordinat[0] = new Vector2(288, 1056);
                Game1.sahnebloktipi[1] = 3;
                Game1.sahneblokkoordinat[1] = new Vector2(288, 1056 + 48);
                Game1.sahnebloktipi[2] = 5;
                Game1.sahneblokkoordinat[2] = new Vector2(288 + 48, 1056 + 48);
                Game1.sahnebloktipi[3] = 4;
                Game1.sahneblokkoordinat[3] = new Vector2(288 + 96, 1056 + 48);
                Game1.sahnebloktipi[4] = 3;
                Game1.sahneblokkoordinat[4] = new Vector2(288 + 96, 1056);
                Game1.sahnebloktipi[5] = 5;
                Game1.sahneblokkoordinat[5] = new Vector2(624, 1104);
                Game1.sahnebloktipi[6] = 5;
                Game1.sahneblokkoordinat[6] = new Vector2(912, 1536);
                Game1.sahnebloktipi[7] = 3;
                Game1.sahneblokkoordinat[7] = new Vector2(912 + 48, 1536);
                Game1.sahnebloktipi[8] = 5;
                Game1.sahneblokkoordinat[8] = new Vector2(912 + 48, 1536 - 48);
                Game1.sahnebloktipi[9] = 5;
                Game1.sahneblokkoordinat[9] = new Vector2(1152, 1488);
                Game1.sahnebloktipi[10] = 4;
                Game1.sahneblokkoordinat[10] = new Vector2(1152, 1488 - 96);
                Game1.sahnebloktipi[11] = 3;
                Game1.sahneblokkoordinat[11] = new Vector2(1392, 1392);
                Game1.sahnebloktipi[12] = 5;
                Game1.sahneblokkoordinat[12] = new Vector2(1632, 1392);

            }
            else if (Game1.dungeonsahne == 4)
            {
                Game1.SAVEkoordinat = new Vector2(1056, 1776 - 96 - 48);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 14;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(854, 576 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(768, 192 - 96);

                    Game1.Canavartipi[2] = 3;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 15;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1488, 144 - 96);

                    Game1.Canavartipi[3] = 3;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 15;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1440, 1776 - 96);

                    Game1.Canavartipi[4] = 3;
                    Game1.Canavaryarasayac[4] = 0;
                    Game1.Canavarcan[4] = 15;
                    Game1.Canavaranimasyon[4] = 0;
                    Game1.Canavaryon[4] = SpriteEffects.None;
                    Game1.Canavarkoordinat[4] = new Vector2(912, 960 - 96);

                    Game1.Canavartipi[5] = 3;
                    Game1.Canavaryarasayac[5] = 0;
                    Game1.Canavarcan[5] = 15;
                    Game1.Canavaranimasyon[5] = 0;
                    Game1.Canavaryon[5] = SpriteEffects.None;
                    Game1.Canavarkoordinat[5] = new Vector2(1008, 1392 - 96);

                    Game1.Canavartipi[6] = 3;
                    Game1.Canavaryarasayac[6] = 0;
                    Game1.Canavarcan[6] = 15;
                    Game1.Canavaranimasyon[6] = 0;
                    Game1.Canavaryon[6] = SpriteEffects.None;
                    Game1.Canavarkoordinat[6] = new Vector2(1632, 1296 - 96);

                    Game1.Canavartipi[7] = 3;
                    Game1.Canavaryarasayac[7] = 0;
                    Game1.Canavarcan[7] = 15;
                    Game1.Canavaranimasyon[7] = 0;
                    Game1.Canavaryon[7] = SpriteEffects.None;
                    Game1.Canavarkoordinat[7] = new Vector2(480, 1584 - 96);

                    Game1.Canavartipi[8] = 3;
                    Game1.Canavaryarasayac[8] = 0;
                    Game1.Canavarcan[8] = 15;
                    Game1.Canavaranimasyon[8] = 0;
                    Game1.Canavaryon[8] = SpriteEffects.None;
                    Game1.Canavarkoordinat[8] = new Vector2(864, 1776 - 96);

                    Game1.Canavartipi[9] = 8;
                    Game1.Canavaryarasayac[9] = 0;
                    Game1.Canavarcan[9] = 10;
                    Game1.Canavaranimasyon[9] = 0;
                    Game1.Canavaryon[9] = SpriteEffects.None;
                    Game1.Canavarkoordinat[9] = new Vector2(96, 144);

                    Game1.Canavartipi[10] = 8;
                    Game1.Canavaryarasayac[10] = 0;
                    Game1.Canavarcan[10] = 10;
                    Game1.Canavaranimasyon[10] = 0;
                    Game1.Canavaryon[10] = SpriteEffects.None;
                    Game1.Canavarkoordinat[10] = new Vector2(896, 844);

                    Game1.Canavartipi[11] = 8;
                    Game1.Canavaryarasayac[11] = 0;
                    Game1.Canavarcan[11] = 10;
                    Game1.Canavaranimasyon[11] = 0;
                    Game1.Canavaryon[11] = SpriteEffects.None;
                    Game1.Canavarkoordinat[11] = new Vector2(1796, 96);

                    Game1.Canavartipi[12] = 8;
                    Game1.Canavaryarasayac[12] = 0;
                    Game1.Canavarcan[12] = 10;
                    Game1.Canavaranimasyon[12] = 0;
                    Game1.Canavaryon[12] = SpriteEffects.None;
                    Game1.Canavarkoordinat[12] = new Vector2(1796, 1496);

                    Game1.Canavartipi[13] = 8;
                    Game1.Canavaryarasayac[13] = 0;
                    Game1.Canavarcan[13] = 10;
                    Game1.Canavaranimasyon[13] = 0;
                    Game1.Canavaryon[13] = SpriteEffects.None;
                    Game1.Canavarkoordinat[13] = new Vector2(1496, 1796);
                }
                Game1.kapikoordinat = new Vector2(4000, 4000);
                if (Game1.anahtaralindi)
                    Game1.anahtarkoordinat = new Vector2(4000, 4000);
                else if (r == 0)
                    Game1.anahtarkoordinat = new Vector2(549, 220 - 48);
                else if (r == 1)
                    Game1.anahtarkoordinat = new Vector2(1632, 240);
                else if (r == 2)
                    Game1.anahtarkoordinat = new Vector2(170, 518);
                else if (r == 3)
                    Game1.anahtarkoordinat = new Vector2(955, 839);
                else if (r == 4)
                    Game1.anahtarkoordinat = new Vector2(1111, 1300);
                else if (r == 5)
                    Game1.anahtarkoordinat = new Vector2(1683, 1205);
                else if (r == 6)
                    Game1.anahtarkoordinat = new Vector2(250, 1670);
                else if (r == 7)
                    Game1.anahtarkoordinat = new Vector2(1100, 1650);
                Game1.sahnebloksayisi = 15;
                Game1.sahnebloktipi[0] = 6;
                Game1.sahneblokkoordinat[0] = new Vector2(240, 1152);
                Game1.sahnebloktipi[1] = 7;
                Game1.sahneblokkoordinat[1] = new Vector2(240, 1152 - 96);
                Game1.sahnebloktipi[2] = 6;
                Game1.sahneblokkoordinat[2] = new Vector2(432, 864);
                Game1.sahnebloktipi[3] = 7;
                Game1.sahneblokkoordinat[3] = new Vector2(432, 864 - 96);
                Game1.sahnebloktipi[4] = 6;
                Game1.sahneblokkoordinat[4] = new Vector2(432, 864 - 192);
                Game1.sahnebloktipi[5] = 6;
                Game1.sahneblokkoordinat[5] = new Vector2(1584, 240);
                Game1.sahnebloktipi[6] = 7;
                Game1.sahneblokkoordinat[6] = new Vector2(816, 1680);
                Game1.sahnebloktipi[7] = 6;
                Game1.sahneblokkoordinat[7] = new Vector2(576, 1488);
                Game1.sahnebloktipi[8] = 7;
                Game1.sahneblokkoordinat[8] = new Vector2(576, 1488 - 96);
                Game1.sahnebloktipi[9] = 6;
                Game1.sahneblokkoordinat[9] = new Vector2(1200, 1200);
                Game1.sahnebloktipi[10] = 7;
                Game1.sahneblokkoordinat[10] = new Vector2(1200, 1200 - 96);
                Game1.sahnebloktipi[11] = 6;
                Game1.sahneblokkoordinat[11] = new Vector2(1200, 1200 - 192);
                Game1.sahnebloktipi[12] = 6;
                Game1.sahneblokkoordinat[12] = new Vector2(1392, 864);
                Game1.sahnebloktipi[13] = 7;
                Game1.sahneblokkoordinat[13] = new Vector2(1392, 864 - 96);
                Game1.sahnebloktipi[14] = 6;
                Game1.sahneblokkoordinat[14] = new Vector2(1392, 864 - 192);
            }
            else if (Game1.dungeonsahne == 5)
            {
                Game1.SAVEkoordinat = new Vector2(1056, 1776 - 96 - 48);
                if (firstday)
                {
                    firstday = false;
                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 0;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(816, 1056 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 0;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(672, 1584 - 96);

                    Game1.Canavartipi[2] = 3;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 15;
                    Game1.Canavaranimasyon[2] = 0;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(624, 1872 - 96);

                    Game1.Canavartipi[3] = 3;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 15;
                    Game1.Canavaranimasyon[3] = 0;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(384, 1872 - 96);
                }
                if (Game1.anahtaralindi && Game1.item[23] == 0)
                    Game1.kapikoordinat = new Vector2(4000, 4000);
                else
                    Game1.kapikoordinat = new Vector2(984, 1056 - 96);
                Game1.anahtarkoordinat = new Vector2(4000, 4000);
                Game1.sahnebloksayisi = 0;
            }
        }

        public static void YeniSahneyiKur()
        {
            if ((Game1.eldekiItemler[0] == 16 || Game1.eldekiItemler[1] == 16 || Game1.eldekiItemler[2] == 16) && Game1.sahne == 14 && Game1.item[4] == 0 && Game1.koordinat.X + 48 > 336 && 336 + 48 > Game1.koordinat.X)
            {
                Game1.item[4] = 1;
                Game1.yaziolantext = "You found white yakub.";
                Game1.textZ = 2;
            }
            if (Game1.sahne == 19)
                if (Game1.map < 170)
                    Game1.map = 170;
            if ((Game1.sahne == 19 && Game1.koordinat.X <= 160) || (Game1.sahne == 14 && Game1.lanet > 0 && Game1.koordinat.X > 1725) || (Game1.sahne == 32 && Game1.koordinat.X > 1677))
                Game1.menu = 5;
            if (Game1.koordinat.X <= 7)
            {
                for (int i = 0; i < 20; i++)
                    Game1.canavaryenitip[i] = 0;
                Game1.kafamindengisin[1] = false;
                Game1.kafamindengisin[2] = false;
                Game1.kafamindengisin[3] = false;
                Game1.kafamindengisin[0] = false;
                Game1.ziplama = 0;
                if (Game1.sahne == 1)
                {
                    Game1.sahne = 0;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 1;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(632, 1104);

                    Game1.Canavartipi[1] = 1;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 1;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(332, 1104);

                    Game1.Canavartipi[2] = 0;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 2;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(858, 1248 - 96);

                    Game1.Canavartipi[3] = 0;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 2;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(296, 1152 - 96);
                }
                else if (Game1.sahne == 2)
                {
                    Game1.sahne = 1;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);
                    
                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 4)
                {
                    Game1.sahne = 3;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1440 - 96);

                    if (Game1.lanet < 3)
                    {
                        Game1.Canavarsayisi = 4;
                        Game1.Canavartipi[0] = 6;
                        Game1.Canavaryarasayac[0] = 0;
                        Game1.Canavarcan[0] = 3;
                        Game1.Canavaranimasyon[0] = 3;
                        Game1.Canavaryon[0] = SpriteEffects.None;
                        Game1.Canavarkoordinat[0] = new Vector2(632, 1104);

                        Game1.Canavartipi[1] = 3;
                        Game1.Canavaryarasayac[1] = 0;
                        Game1.Canavarcan[1] = 6;
                        Game1.Canavaranimasyon[1] = 3;
                        Game1.Canavaryon[1] = SpriteEffects.None;
                        Game1.Canavarkoordinat[1] = new Vector2(240, 1488 - 96);

                        Game1.Canavartipi[2] = 3;
                        Game1.Canavaryarasayac[2] = 0;
                        Game1.Canavarcan[2] = 6;
                        Game1.Canavaranimasyon[2] = 3;
                        Game1.Canavaryon[2] = SpriteEffects.None;
                        Game1.Canavarkoordinat[2] = new Vector2(768, 1536 - 96);

                        Game1.Canavartipi[3] = 3;
                        Game1.Canavaryarasayac[3] = 0;
                        Game1.Canavarcan[3] = 6;
                        Game1.Canavaranimasyon[3] = 3;
                        Game1.Canavaryon[3] = SpriteEffects.None;
                        Game1.Canavarkoordinat[3] = new Vector2(1344, 1624 - 96);
                    }
                    else
                        Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 5 && Game1.koordinat.Y < 814)
                {
                    Game1.sahne = 2;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1824 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(758, 1536 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1216, 1632 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(900, 1536 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1300, 1632 - 96);
                }
                else if (Game1.sahne == 5)
                {
                    Game1.sahne = 4;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 480 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(328, 1248 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(528, 1248 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(424, 1248 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(632, 1248 - 96);
                }
                else if (Game1.sahne == 6)
                {
                    Game1.sahne = 5;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1152 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(452, 1056 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 4;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1680, 1200 - 48);
                    Game1.canavaryenitip[3] = 1;
                }
                else if (Game1.sahne == 7)
                {
                    Game1.sahne = 6;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 8)
                {
                    Game1.sahne = 7;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 814 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(672, 1246 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1544, 958 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(640, 1198 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1248, 1102 - 96);
                }
                else if (Game1.sahne == 9)
                {
                    Game1.sahne = 7;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1726 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(672, 1246 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1544, 958 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(640, 1198 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1248, 1102 - 96);
                }
                else if (Game1.sahne == 10)
                {
                    Game1.sahne = 9;
                    Game1.sahnebloksayisi = 1;
                    Game1.sahnebloktipi[0] = 0;
                    Game1.sahneblokkoordinat[0] = new Vector2(960, 1488);
                    Game1.koordinat = new Vector2(1864, 1344 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(776, 1584 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1204, 1392 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(336, 1296 - 96);
                }
                else if (Game1.sahne == 11)
                {
                    Game1.sahne = 10;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 912 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 2;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 4;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(776, 1296 - 48);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 2;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 4;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1446, 1248 - 48);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 4;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1632, 1152 - 48);
                    Game1.canavaryenitip[2] = 1;
                }
                else if (Game1.sahne == 12)
                {
                    Game1.sahne = 11;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1392 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(384, 1344 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1224, 1440 - 96);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(776, 1344 - 96);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 4;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(240, 1488 - 48);
                    Game1.canavaryenitip[3] = 1;
                }
                else if (Game1.sahne == 13)
                {
                    Game1.sahne = 12;
                    Game1.sahnebloksayisi = 2;
                    Game1.sahnebloktipi[0] = 0;
                    Game1.sahneblokkoordinat[0] = new Vector2(192, 1488);
                    Game1.sahnebloktipi[1] = 0;
                    Game1.sahneblokkoordinat[1] = new Vector2(192, 1488 + 48);
                    Game1.koordinat = new Vector2(1864, 720 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(1400, 672 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 5;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(704, 720 - 96);

                    Game1.Canavartipi[2] = 5;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1042, 768 - 96);

                    Game1.Canavartipi[3] = 5;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 3;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1504, 672 - 96);
                }
                else if (Game1.sahne == 14)
                {
                    Game1.sahne = 13;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 15)
                {
                    Game1.sahne = 10;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1536 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 2;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 4;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(776, 1296 - 48);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 2;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 4;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1446, 1248 - 48);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 4;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1632, 1152 - 48);
                    Game1.canavaryenitip[2] = 1;
                }
                else if (Game1.sahne == 16)
                {
                    Game1.sahne = 15;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1584 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(900, 1488 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(800, 1488 - 96);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1000, 1488 - 96);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 6;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(900, 1000 - 96);
                }
                else if (Game1.sahne == 17)
                {
                    Game1.sahne = 16;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1056 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(556, 1248 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1152 - 96);
                    Game1.canavaryenitip[1] = 1;
                }
                else if (Game1.sahne == 18)
                {
                    Game1.sahne = 17;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);
                    
                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 20)
                {
                    Game1.sahne = 19;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1056 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(464, 1328 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1043, 1328 - 96);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1440, 1200 - 96);
                }
                else if (Game1.sahne == 21)
                {
                    Game1.sahne = 20;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1824 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 22)
                {
                    Game1.sahne = 19;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1728 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(464, 1328);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1043, 1328);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1440, 1200 - 96);
                }
                else if (Game1.sahne == 23)
                {
                    Game1.sahne = 22;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1488 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(240, 1344 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1152, 1440 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1392, 1440 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(432, 1344 - 48);
                }
                else if (Game1.sahne == 24)
                {
                    Game1.sahne = 23;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 25)
                {
                    Game1.sahne = 24;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 720 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(384, 1008 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1056 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1440, 864 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(720, 1008 - 48);
                }
                else if (Game1.sahne == 26)
                {
                    Game1.sahne = 25;
                    Game1.sahnebloksayisi = 1;
                    Game1.sahnebloktipi[0] = 5;
                    Game1.sahneblokkoordinat[0] = new Vector2(1248, 1344);
                    Game1.koordinat = new Vector2(1864, 1632 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(328, 1536 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1344, 1536 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1104, 1440 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(528, 1536 - 48);
                }
                else if (Game1.sahne == 27)
                {
                    Game1.sahne = 26;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1440 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(672, 1392 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1200, 1488 - 96);

                    Game1.Canavartipi[2] = 8;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1028, 1140);
                }
                else if (Game1.sahne == 28)
                {
                    Game1.sahne = 27;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1440 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(576, 1488 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1296, 1296 - 96);

                    Game1.Canavartipi[2] = 8;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1072, 1392);
                }
                else if (Game1.sahne == 29)
                {
                    Game1.sahne = 28;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1392 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 8;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 10;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(376, 1488 - 96);

                    Game1.Canavartipi[1] = 8;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 10;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1476, 1488 - 96);
                }
                else if (Game1.sahne == 30)
                {
                    Game1.sahne = 29;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1392 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 8;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 10;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(376, 1488 - 96);

                    Game1.Canavartipi[1] = 8;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 10;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1476, 1488 - 96);
                }
                else if (Game1.sahne == 31)
                {
                    Game1.sahne = 30;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1200 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 2;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(531, 1440 - 48);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1200, 1200);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1014, 1344 - 96);
                }
                else if (Game1.sahne == 32)
                {
                    Game1.sahne = 31;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1728 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 33)
                {
                    Game1.sahne = 24;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1536 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(384, 1008 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1056 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1440, 864 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(720, 1008 - 48);
                }
                else if (Game1.sahne == 34)
                {
                    Game1.sahne = 33;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1488 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(864, 1392 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1684, 1392 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(720, 1200 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(96, 1008 - 48);
                }
                else if (Game1.sahne == 35)
                {
                    Game1.sahne = 34;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1584 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 6;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(364, 1092);
                    Canavarlar.durum = 2;

                    Game1.Canavartipi[1] = 6;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1192);

                    Game1.Canavartipi[2] = 6;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1064, 1392);
                }
                else if (Game1.sahne == 36)
                {
                    Game1.sahne = 35;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 37)
                {
                    Game1.sahne = 36;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1864, 1824 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 6;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(964, 1092);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(576, 1632 - 96);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1419, 1680 - 96);
                }
                else
                {
                    Game1.sahne = 31;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(1000, 1816);
                }
                if ((Game1.sahne == 1 && Game1.lanet > 0) || Game1.sahne == 6 || Game1.sahne == 13 || Game1.sahne == 17 || Game1.sahne == 20 || (Game1.sahne == 23 && Game1.lanet > 1) || (Game1.sahne == 31 && Game1.lanet > 2) || Game1.sahne == 35)
                {
                    for (int i = 0; i < 4; i++)
                        Game1.kasabalix[i] = 400 + (400 * i);
                }
            }
            else if (Game1.koordinat.X >= 1865)
            {
                for (int i = 0; i < 20; i++)
                    Game1.canavaryenitip[i] = 0;
                Game1.kafamindengisin[1] = false;
                Game1.kafamindengisin[2] = false;
                Game1.kafamindengisin[3] = false;
                Game1.kafamindengisin[0] = false;
                Game1.ziplama = 0;
                if (Game1.sahne == 0)
                {
                    Game1.sahne = 1;
                    if (Game1.map < 27)
                        Game1.map = 27;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 1)
                {
                    Game1.sahne = 2;
                    if (Game1.map < 39)
                        Game1.map = 39;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1488 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(758, 1536 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1216, 1632 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(900, 1536 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1300, 1632 - 96);
                }
                else if (Game1.sahne == 2)
                {
                    Game1.sahne = 5;
                    if (Game1.map < 51)
                        Game1.map = 51;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 624 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(452, 1056 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 4;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1680, 1200 - 48);
                    Game1.canavaryenitip[3] = 1;
                }
                else if (Game1.sahne == 3)
                {
                    Game1.sahne = 4;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1200);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(328, 1248 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(528, 1248 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(424, 1248 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(632, 1248 - 96);
                }
                else if (Game1.sahne == 4)
                {
                    Game1.sahne = 5;
                    if (Game1.map < 51)
                        Game1.map = 51;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1200);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(452, 1056 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1404, 1296 - 96);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 4;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1680, 1200 - 48);
                    Game1.canavaryenitip[3] = 1;
                }
                else if (Game1.sahne == 5)
                {
                    Game1.sahne = 6;
                    if (Game1.map < 63)
                        Game1.map = 63;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 6)
                {
                    Game1.sahne = 7;
                    if (Game1.map < 75)
                        Game1.map = 75;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1248 - 98);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(672, 1246 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1544, 958 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(640, 1198 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1248, 1102 - 96);
                }
                else if (Game1.sahne == 7 && Game1.koordinat.Y < 1000)
                {
                    Game1.sahne = 8;
                    if (Game1.map < 87)
                        Game1.map = 87;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1728 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 4;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 4;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(1296, 1584 - 96);

                    Game1.Canavartipi[1] = 4;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 4;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1584, 1392 - 96);
                }
                else if (Game1.sahne == 7)
                {
                    Game1.sahne = 9;
                    if (Game1.map < 87)
                        Game1.map = 87;
                    Game1.sahnebloksayisi = 1;
                    Game1.sahnebloktipi[0] = 0;
                    Game1.sahneblokkoordinat[0] = new Vector2(960, 1488);
                    Game1.koordinat = new Vector2(8, 1104 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 2;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(776, 1584 - 96);

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 2;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1204, 1392 - 96);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 1;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(336, 1296 - 96);
                }
                else if (Game1.sahne == 9)
                {
                    Game1.sahne = 10;
                    if (Game1.map < 99)
                        Game1.map = 99;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1248 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 2;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 4;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(776, 1296 - 48);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 2;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 4;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1446, 1248 - 48);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 4;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1632, 1152 - 48);
                    Game1.canavaryenitip[2] = 1;
                }
                else if (Game1.sahne == 10 && Game1.koordinat.Y < 1200)
                {
                    Game1.sahne = 11;
                    if (Game1.map < 111)
                        Game1.map = 111;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1680 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(384, 1344 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1224, 1440 - 96);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(776, 1344 - 96);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 4;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(240, 1488 - 48);
                    Game1.canavaryenitip[3] = 1;
                }
                else if (Game1.sahne == 10)
                {
                    Game1.sahne = 15;
                    if (Game1.map < 111)
                        Game1.map = 111;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1584 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(900, 1488 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(800, 1488 - 96);
                    Game1.canavaryenitip[1] = 1;

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1000, 1488 - 96);
                    Game1.canavaryenitip[2] = 1;

                    Game1.Canavartipi[3] = 6;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 1;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(900, 1000 - 96);
                }
                else if (Game1.sahne == 11)
                {
                    Game1.sahne = 12;
                    if (Game1.map < 123)
                        Game1.map = 123;
                    Game1.sahnebloksayisi = 2;
                    Game1.sahnebloktipi[0] = 0;
                    Game1.sahneblokkoordinat[0] = new Vector2(192, 1488);
                    Game1.sahnebloktipi[1] = 0;
                    Game1.sahneblokkoordinat[1] = new Vector2(192, 1488 + 48);
                    Game1.koordinat = new Vector2(8, 1728 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[1] = 5;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(704, 720 - 96);

                    Game1.Canavartipi[2] = 5;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1042, 768 - 96);

                    Game1.Canavartipi[0] = 5;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(1504, 672 - 96);
                }
                else if (Game1.sahne == 12)
                {
                    if (Game1.map < 135)
                        Game1.map = 135;
                    Game1.sahne = 13;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 13)
                {
                    if (Game1.map < 147)
                        Game1.map = 147;
                    Game1.sahne = 14;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 672 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(381, 720 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 5;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(609, 768 - 96);

                    Game1.Canavartipi[2] = 5;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(797, 864 - 96);
                }
                else if (Game1.sahne == 15)
                {
                    if (Game1.map < 123)
                        Game1.map = 123;
                    Game1.sahne = 16;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1200 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 0;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(556, 1248 - 96);
                    Game1.canavaryenitip[0] = 1;

                    Game1.Canavartipi[1] = 0;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1152 - 96);
                    Game1.canavaryenitip[1] = 1;
                }
                else if (Game1.sahne == 16)
                {
                    if (Game1.map < 135)
                        Game1.map = 135;
                    Game1.sahne = 17;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 17)
                {
                    if (Game1.map < 147)
                        Game1.map = 147;
                    Game1.sahne = 18;
                    Game1.sahnebloksayisi = 0;

                    Game1.Canavarsayisi = 1;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(192, 1584);
                    Game1.canavaryenitip[0] = 1;

                    Game1.koordinat = new Vector2(8, 1248 - 96);
                }
                else if (Game1.sahne == 19 && Game1.koordinat.Y < 1200)
                {
                    Game1.sahne = 20;
                    if (Game1.map < 182)
                        Game1.map = 182;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1824 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 19)
                {
                    Game1.sahne = 22;
                    if (Game1.map < 182)
                        Game1.map = 182;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1056 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(240, 1344 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1152, 1440 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1392, 1440 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(432, 1344 - 48);
                }
                else if (Game1.sahne == 20)
                {
                    Game1.sahne = 21;
                    if (Game1.map < 194)
                        Game1.map = 194;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1824 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 4;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 5;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(1536, 1680 - 96);

                    Game1.Canavartipi[1] = 4;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 5;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1728, 1632 - 96);

                    Game1.Canavartipi[2] = 6;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1784, 1392 - 96);
                }
                else if (Game1.sahne == 22)
                {
                    Game1.sahne = 23;
                    if (Game1.map < 194)
                        Game1.map = 194;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 23)
                {
                    Game1.sahne = 24;
                    if (Game1.map < 206)
                        Game1.map = 206;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1056 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(384, 1008 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1056 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1440, 864 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(720, 1008 - 48);
                }
                else if (Game1.sahne == 24 && Game1.koordinat.Y < 900)
                {
                    Game1.sahne = 25;
                    if (Game1.map < 218)
                        Game1.map = 218;
                    Game1.sahnebloksayisi = 1;
                    Game1.sahnebloktipi[0] = 5;
                    Game1.sahneblokkoordinat[0] = new Vector2(1248, 1344);
                    Game1.koordinat = new Vector2(8, 1680 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(328, 1536 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1344, 1536 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1104, 1440 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(528, 1536 - 48);
                }
                else if (Game1.sahne == 24)
                {
                    Game1.sahne = 33;
                    if (Game1.map < 218)
                        Game1.map = 218;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 912 - 96);

                    Game1.Canavarsayisi = 4;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(864, 1392 - 96);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1684, 1392 - 96);

                    Game1.Canavartipi[2] = 2;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(720, 1200 - 48);

                    Game1.Canavartipi[3] = 2;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(96, 1008 - 48);
                }
                else if (Game1.sahne == 25)
                {
                    Game1.sahne = 26;
                    if (Game1.map < 230)
                        Game1.map = 230;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1488 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(672, 1392 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1200, 1488 - 96);

                    Game1.Canavartipi[2] = 8;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1028, 1140);
                }
                else if (Game1.sahne == 26)
                {
                    Game1.sahne = 27;
                    if (Game1.map < 242)
                        Game1.map = 242;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1296 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 3;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 15;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(576, 1488 - 96);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1296, 1296 - 96);

                    Game1.Canavartipi[2] = 8;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1072, 1392);
                }
                else if (Game1.sahne == 27)
                {
                    Game1.sahne = 28;
                    if (Game1.map < 254)
                        Game1.map = 254;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1392 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 8;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 10;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(376, 1488 - 96);

                    Game1.Canavartipi[1] = 8;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 10;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1476, 1488 - 96);
                }
                else if (Game1.sahne == 28)
                {
                    Game1.sahne = 29;
                    if (Game1.map < 266)
                        Game1.map = 266;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1344 - 96);

                    Game1.Canavarsayisi = 2;
                    Game1.Canavartipi[0] = 8;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 10;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(376, 1488 - 96);

                    Game1.Canavartipi[1] = 8;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 10;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1476, 1488 - 96);
                }
                else if (Game1.sahne == 29)
                {
                    Game1.sahne = 30;
                    if (Game1.map < 278)
                        Game1.map = 278;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1632 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 2;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(531, 1440 - 48);

                    Game1.Canavartipi[1] = 3;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 15;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1200, 1200);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 10;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1014, 1344 - 96);
                }
                else if (Game1.sahne == 30)
                {
                    Game1.sahne = 31;
                    if (Game1.map < 290)
                        Game1.map = 290;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1728 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 31)
                {
                    Game1.sahne = 32;
                    if (Game1.map < 303)
                        Game1.map = 303;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1008 - 96);

                    Game1.Canavarsayisi = 1;
                    Game1.Canavartipi[0] = 7;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(624, 1104);
                }
                else if (Game1.sahne == 33)
                {
                    Game1.sahne = 34;
                    if (Game1.map < 230)
                        Game1.map = 230;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1584 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 6;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(364, 1092);
                    Canavarlar.durum = 2;

                    Game1.Canavartipi[1] = 6;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 3;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(864, 1192);

                    Game1.Canavartipi[2] = 6;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 3;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1064, 1392);
                }
                else if (Game1.sahne == 34)
                {
                    Game1.sahne = 35;
                    if (Game1.map < 242)
                        Game1.map = 242;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1776 - 96);

                    Game1.Canavarsayisi = 0;
                }
                else if (Game1.sahne == 35)
                {
                    Game1.sahne = 36;
                    if (Game1.map < 254)
                        Game1.map = 254;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1632 - 96);

                    Game1.Canavarsayisi = 3;
                    Game1.Canavartipi[0] = 6;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 3;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(964, 1092);

                    Game1.Canavartipi[1] = 7;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(576, 1632 - 96);

                    Game1.Canavartipi[2] = 7;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1419, 1680 - 96);
                }
                else if (Game1.sahne == 36)
                {
                    Game1.sahne = 37;
                    if (Game1.map < 266)
                        Game1.map = 266;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(8, 1728 - 96);

                    Game1.Canavarsayisi = 6;
                    Game1.Canavartipi[0] = 1;
                    Game1.Canavaryarasayac[0] = 0;
                    Game1.Canavarcan[0] = 8;
                    Game1.Canavaranimasyon[0] = 3;
                    Game1.Canavaryon[0] = SpriteEffects.None;
                    Game1.Canavarkoordinat[0] = new Vector2(864, 1056 - 96);

                    Game1.Canavartipi[1] = 1;
                    Game1.Canavaryarasayac[1] = 0;
                    Game1.Canavarcan[1] = 8;
                    Game1.Canavaranimasyon[1] = 3;
                    Game1.Canavaryon[1] = SpriteEffects.None;
                    Game1.Canavarkoordinat[1] = new Vector2(1200 - 96, 624);

                    Game1.Canavartipi[2] = 1;
                    Game1.Canavaryarasayac[2] = 0;
                    Game1.Canavarcan[2] = 8;
                    Game1.Canavaranimasyon[2] = 3;
                    Game1.Canavaryon[2] = SpriteEffects.None;
                    Game1.Canavarkoordinat[2] = new Vector2(1200, 624 - 96);

                    Game1.Canavartipi[3] = 1;
                    Game1.Canavaryarasayac[3] = 0;
                    Game1.Canavarcan[3] = 8;
                    Game1.Canavaranimasyon[3] = 3;
                    Game1.Canavaryon[3] = SpriteEffects.None;
                    Game1.Canavarkoordinat[3] = new Vector2(1392, 336 - 96);

                    Game1.Canavartipi[4] = 1;
                    Game1.Canavaryarasayac[4] = 0;
                    Game1.Canavarcan[4] = 8;
                    Game1.Canavaranimasyon[4] = 3;
                    Game1.Canavaryon[4] = SpriteEffects.None;
                    Game1.Canavarkoordinat[4] = new Vector2(1776, 192 - 96);

                    Game1.Canavartipi[5] = 1;
                    Game1.Canavaryarasayac[5] = 0;
                    Game1.Canavarcan[5] = 8;
                    Game1.Canavaranimasyon[5] = 3;
                    Game1.Canavaryon[5] = SpriteEffects.None;
                    Game1.Canavarkoordinat[5] = new Vector2(1488, 192 - 96);
                }
                else
                {
                    Game1.sahne = 0;
                    Game1.sahnebloksayisi = 0;
                    Game1.koordinat = new Vector2(480, 480);
                }
                if ((Game1.sahne == 1 && Game1.lanet > 0) || Game1.sahne == 6 || Game1.sahne == 13 || Game1.sahne == 17 || Game1.sahne == 20 || (Game1.sahne == 23 && Game1.lanet > 1) || (Game1.sahne == 31 && Game1.lanet > 2) || Game1.sahne == 35)
                    for (int i = 0; i < 4; i++)
                        Game1.kasabalix[i] = 400 + (400 * i);
            }
        }

        public static void SahneyeGoreRenkAyarla()
        {
            if (Game1.sahne == 1)
                Game1.kasabalirengi = new Color(255, 0, 0);
            else if (Game1.sahne == 6)
                Game1.kasabalirengi = new Color(40, 255, 13);
            else if (Game1.sahne == 13)
                Game1.kasabalirengi = new Color(16, 110, 128);
            else if (Game1.sahne == 17)
                Game1.kasabalirengi = new Color(250, 150, 0);
            else if (Game1.sahne == 20)
                Game1.kasabalirengi = new Color(127, 127, 150);
            else if (Game1.sahne == 23)
                Game1.kasabalirengi = new Color(8, 55, 64);
            else if (Game1.sahne == 31)
                Game1.kasabalirengi = new Color(20, 130, 8);
            else if (Game1.sahne == 35)
                Game1.kasabalirengi = new Color(250, 0, 250);
        }

        public static void SahneyeGoreHaritayiHazirla()
        {
            if (Game1.sahne == 0)
                Game1.mapzer = new Vector2(707, 56);
            else if (Game1.sahne == 1)
                Game1.mapzer = new Vector2(719, 56);
            else if (Game1.sahne == 2)
                Game1.mapzer = new Vector2(731, 56);
            else if (Game1.sahne == 3)
                Game1.mapzer = new Vector2(719, 68);
            else if (Game1.sahne == 4)
                Game1.mapzer = new Vector2(731, 68);
            else if (Game1.sahne == 5)
                Game1.mapzer = new Vector2(743, 62);
            else if (Game1.sahne == 6)
                Game1.mapzer = new Vector2(755, 62);
            else if (Game1.sahne == 7)
                Game1.mapzer = new Vector2(767, 62);
            else if (Game1.sahne == 8)
                Game1.mapzer = new Vector2(779, 56);
            else if (Game1.sahne == 9)
                Game1.mapzer = new Vector2(779, 68);
            else if (Game1.sahne == 10)
                Game1.mapzer = new Vector2(791, 68);
            else if (Game1.sahne == 11)
                Game1.mapzer = new Vector2(803, 62);
            else if (Game1.sahne == 12)
                Game1.mapzer = new Vector2(815, 56);
            else if (Game1.sahne == 13)
                Game1.mapzer = new Vector2(827, 56);
            else if (Game1.sahne == 14)
                Game1.mapzer = new Vector2(839, 56);
            else if (Game1.sahne == 15)
                Game1.mapzer = new Vector2(803, 74);
            else if (Game1.sahne == 16)
                Game1.mapzer = new Vector2(815, 74);
            else if (Game1.sahne == 17)
                Game1.mapzer = new Vector2(827, 74);
            else if (Game1.sahne == 18)
                Game1.mapzer = new Vector2(839, 74);
            else if (Game1.sahne == 19)
                Game1.mapzer = new Vector2(863, 62);
            else if (Game1.sahne == 20)
                Game1.mapzer = new Vector2(875, 56);
            else if (Game1.sahne == 21)
                Game1.mapzer = new Vector2(887, 56);
            else if (Game1.sahne == 22)
                Game1.mapzer = new Vector2(875, 68);
            else if (Game1.sahne == 23)
                Game1.mapzer = new Vector2(887, 68);
            else if (Game1.sahne == 24)
                Game1.mapzer = new Vector2(899, 68);
            else if (Game1.sahne == 25)
                Game1.mapzer = new Vector2(911, 62);
            else if (Game1.sahne == 26)
                Game1.mapzer = new Vector2(923, 62);
            else if (Game1.sahne == 27)
                Game1.mapzer = new Vector2(935, 62);
            else if (Game1.sahne == 28)
                Game1.mapzer = new Vector2(947, 62);
            else if (Game1.sahne == 29)
                Game1.mapzer = new Vector2(959, 62);
            else if (Game1.sahne == 30)
                Game1.mapzer = new Vector2(971, 56);
            else if (Game1.sahne == 31)
                Game1.mapzer = new Vector2(983, 56);
            else if (Game1.sahne == 32)
                Game1.mapzer = new Vector2(995, 56);
            else if (Game1.sahne == 33)
                Game1.mapzer = new Vector2(911, 74);
            else if (Game1.sahne == 34)
                Game1.mapzer = new Vector2(923, 74);
            else if (Game1.sahne == 35)
                Game1.mapzer = new Vector2(935, 74);
            else if (Game1.sahne == 36)
                Game1.mapzer = new Vector2(947, 74);
            else if (Game1.sahne == 37)
                Game1.mapzer = new Vector2(959, 74);
            Game1.animasyonolmayanC++;
            if (Game1.animasyonolmayanC >= 15)
                Game1.animasyonolmayanC = 0;
        }
    }
}
