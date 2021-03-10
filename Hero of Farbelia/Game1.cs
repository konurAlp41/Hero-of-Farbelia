using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Texture2D texture;
        Song song;
        SoundEffect soundeffect;
        SpriteFont font;

        public static byte bosser = 0;
        public static string[] itemname = new string[30];
        public static int geym = 0;
        public static Vector2 parcacikkoordinat = new Vector2(4000, 4000);
        public static int parcacikanimation = 0;
        public static int f = 0;
        public static int heroyarasayaci = 0;
        public static int herocan = 6;
        public static int Canavarsayisi = 0;
        public static int[] Canavartipi = new int[20]; //0:Ayý 1:Kurt 2:AteþliBitki 3:Mumya 4:Ýskelet 5:KardanAdam 6:Kuþ 7:AteþliBalýk 8:UçanGöz
        public static Vector2[] Canavarkoordinat = new Vector2[20];
        public static SpriteEffects[] Canavaryon = new SpriteEffects[20];
        public static int[] Canavarcan = new int[20];
        public static int[] Canavaryarasayac = new int[20];
        public static int[] Canavaranimasyon = new int[20];
        public static SpriteEffects heroyon = SpriteEffects.None;
        public static int heroanimation = 0;
        public static int animation = 0;
        public static int iksirmission = 0;
        public static Color kasabalirengi = new Color();
        public static int lanet = 0;
        public static int animasyonolmayanC = 0;
        public static Vector2 mapzer = new Vector2();
        public static bool maper = false;
        public static int map = 63;
        public static string[] placenames = new string[38];
        public static bool[] BlockActivater = new bool[8];
        public static int sahnebloksayisi = 0;
        public static int[] sahnebloktipi = new int[20];
        public static Vector2[] sahneblokkoordinat = new Vector2[20];
        public static int sakarsayac2 = 0;
        public static int[] eldekiItemler = new int[3];
        public static int seciliItem = 0;
        public static int itemmenuy = -421;
        public static int[] item = new int[30];
        public static Color karartma = new Color(255, 255, 255);
        public static Color background = new Color(153, 217, 234);
        public static int gun = 0;
        public static float saat = 1.60f * 60;
        public static int sakarsayac = 0;
        public static int secilitext = 0;
        public static bool[] kafamindengisin = new bool[5];
        public static SpriteEffects[] kasabaliyon = new SpriteEffects[4];
        public static int[] kasabalix = new int[4];
        public static int tableuzunluk = 0;
        public static int ziplama = 0;
        public static Vector2 kamera = new Vector2();
        public static Vector2 koordinat = new Vector2(744, 1680);
        public static int sahne = 1;
        public static int menu = 0; //0:Ana Menü 1:Oyun Menüsü 2:Oyun Ölüm 3:Oyun Bina 4:Item Menü 5:Sudan Geçiþ Menüsü 6:Ending
        public static string[] text = new string[47];
        public static int bulunulanbina = -1;
        public static bool[] benbuevesahibim = new bool[5];
        bool yes = true;
        Color kolor = new Color(255, 255, 255);
        public static string yaziolantext = "";
        public static bool exciter = false;
        public static int textZ = 0;
        public static int kalkancan = 100;
        public static bool konustumulan = false;
        public static int herohak = 3;
        public static int colsayaci = 0;
        public static Vector2 yakubkoordinat = new Vector2(4000, 4000);
        public static int orospununaklindantuttugusayi = 0;
        public static Vector2 dungeonkoordinat = new Vector2();
        public static int dungeonsahne = 0;
        public static Vector2 anahtarkoordinat = new Vector2();
        public static Vector2 kapikoordinat = new Vector2();
        public static bool anahtaralindi = false;
        public static int fzero = 0;
        public static int SAVEsahne = 0;
        public static Vector2 SAVEkoordinat = new Vector2();
        public static bool[] SAVEbenbuevesahibim = new bool[5];
        public static float SAVEsaat = 0f;
        public static int SAVEgun = 0;
        public static Color SAVEbackground = new Color();
        public static Color SAVEkarartma = new Color();
        public static int[] SAVEitem = new int[30];
        public static int SAVElanet = 0;
        public static int SAVEiksirmission = 0;
        public static int SAVEmap = 0;
        public static int SAVEkalkancan = 0;
        public static bool SAVEkonustumulan = false;
        public static bool iliikik = true;
        public static int noter = 600;
        public static bool sonbirkezdahabasildi = true;
        public static int[] canavaryenitip = new int[20];
        public static int[] gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort = new int[3];
        int supermegaintro = 1500;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 1024;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            item[8] = 1;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TextDüzenleyici.CreateText();
            TextDüzenleyici.CreatePlaceNames();
            font = Content.Load<SpriteFont>("font");
            for (int i = 0; i < 3; i++)
                eldekiItemler[i] = 30;
            eldekiItemler[0] = 8;
            benbuevesahibim[0] = true;
            for (int i = 1; i < 5; i++)
                benbuevesahibim[i] = false;
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
                Game1.SAVEitem[i] = item[i];
                if (i < 5)
                    Game1.SAVEbenbuevesahibim[i] = benbuevesahibim[i];
            }
            Database.FirstSearch();
            graphics.PreferredBackBufferHeight = (int)Database.grafiks;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            song = Content.Load<Song>("ThemeDay");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeCastle");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeHaunted");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeTown");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeBoss");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeVictory");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeEnding");
            MediaPlayer.Play(song);
            MediaPlayer.Stop();
            song = Content.Load<Song>("ThemeMain");
            MediaPlayer.Play(song);
            MediaPlayer.Volume = 1f;
            MediaPlayer.IsRepeating = true;
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            bosser = Boss.bosser;
            if (supermegaintro > 0)
                supermegaintro -= 3;
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.O))
            {
                graphics.IsFullScreen = false;
                graphics.ApplyChanges();
            }
            if (klavye.IsKeyDown(Keys.F5))
            {
                if (sonbirkezdahabasildi)
                {
                    sonbirkezdahabasildi = false;
                    if (graphics.PreferredBackBufferHeight == 600)
                        graphics.PreferredBackBufferHeight = 768;
                    else
                        graphics.PreferredBackBufferHeight = 600;
                    graphics.ApplyChanges();
                    Database.grafiks = graphics.PreferredBackBufferHeight;
                    Database.Grafix();
                }
            }
            else
                sonbirkezdahabasildi = true;
            if (kalkancan <= 0)
            {
                item[14] = 0;
                if (eldekiItemler[0] == 14)
                    eldekiItemler[0] = 30;
                else if (eldekiItemler[1] == 14)
                    eldekiItemler[1] = 30;
                else if (eldekiItemler[2] == 14)
                    eldekiItemler[2] = 30;
                kalkancan = 100;
            }
            if (exciter)
                Exit();
            else if (menu == 0)
            {
                iliikik = true;
                fzero++;
                if (fzero > 60)
                    fzero = 60;
                if (supermegaintro == 0)
                {
                    if (klavye.IsKeyDown(Keys.G))
                    {
                        geym = 1;
                        menu = 1;
                        Database.SecondSearch();
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
                        Game1.bulunulanbina = -1;
                        if ((sahne == 1 && lanet == 0) || (sahne == 23 && lanet < 2) || (sahne == 31 && lanet < 3))
                        {
                            song = Content.Load<Song>("ThemeHaunted");
                            MediaPlayer.Play(song);
                        }
                        else
                        {
                            song = Content.Load<Song>("ThemeTown");
                            MediaPlayer.Play(song);
                        }
                    }
                    else if (klavye.IsKeyDown(Keys.Z))
                    {
                        geym = 1;
                        Database.Delete();
                        Database.FirstSearch();
                    }
                    else if (klavye.IsKeyDown(Keys.H))
                    {
                        menu = 1;
                        geym = 2;
                        Database.SecondSearch();
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
                        Game1.bulunulanbina = -1;
                        if ((sahne == 1 && lanet == 0) || (sahne == 23 && lanet < 2) || (sahne == 31 && lanet < 3))
                        {
                            song = Content.Load<Song>("ThemeHaunted");
                            MediaPlayer.Play(song);
                        }
                        else
                        {
                            song = Content.Load<Song>("ThemeTown");
                            MediaPlayer.Play(song);
                        }
                    }
                    else if (klavye.IsKeyDown(Keys.X))
                    {
                        geym = 2;
                        Database.Delete();
                        Database.FirstSearch();
                    }
                    else if (klavye.IsKeyDown(Keys.J))
                    {
                        menu = 1;
                        geym = 3;
                        Database.SecondSearch();
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
                        Game1.bulunulanbina = -1;
                        if ((sahne == 1 && lanet == 0) || (sahne == 23 && lanet < 2) || (sahne == 31 && lanet < 3))
                        {
                            song = Content.Load<Song>("ThemeHaunted");
                            MediaPlayer.Play(song);
                        }
                        else
                        {
                            song = Content.Load<Song>("ThemeTown");
                            MediaPlayer.Play(song);
                        }
                    }
                    else if (klavye.IsKeyDown(Keys.C))
                    {
                        geym = 3;
                        Database.Delete();
                        Database.FirstSearch();
                    }
                    else if (klavye.IsKeyDown(Keys.Escape) && fzero >= 60)
                        Exit();
                }
            }
            else if (menu == 1)
            {
                if ((lanet < 3 || sahne != 3) && (sahne != 1) && (sahne != 6) && (sahne != 13) && (sahne != 17) && (sahne != 20) && (sahne != 23) && (sahne != 31) && (sahne != 35) && (song == Content.Load<Song>("ThemeHaunted") || song == Content.Load<Song>("ThemeTown")))
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeDay");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1;
                }
                else if ((lanet < 3 || sahne != 3) && ((sahne == 1 && lanet > 0) || (sahne == 23 && lanet > 1) || (sahne == 31 && lanet > 2) || (sahne == 6) || (sahne == 13) || (sahne == 20) || (sahne == 35)) && (song == Content.Load<Song>("ThemeDay") || song == Content.Load<Song>("gameover")))
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeTown");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1;
                }
                else if ((lanet < 3 || sahne != 3) && ((sahne == 1 && lanet == 0) || (sahne == 23 && lanet <= 1) || (sahne == 31 && lanet <= 2)) && (song == Content.Load<Song>("ThemeDay") || song == Content.Load<Song>("gameover")))
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeHaunted");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1;
                }
                if (klavye.IsKeyDown(Keys.K) && klavye.IsKeyDown(Keys.A) && klavye.IsKeyDown(Keys.Y))
                    for (int i = 0; i < 20; i++)
                        item[i] = 1;
                if ((song == Content.Load<Song>("ThemeCastle") || song == Content.Load<Song>("ThemeBoss") || song == Content.Load<Song>("ThemeVictory")) && bulunulanbina == -1 && (lanet < 3 || sahne != 3))
                {
                    MediaPlayer.Stop();
                    if ((sahne == 1 && lanet == 0) || (sahne == 23 && lanet < 2) || (sahne == 31 && lanet < 3))
                        song = Content.Load<Song>("ThemeHaunted");
                    else
                        song = Content.Load<Song>("ThemeTown");
                    MediaPlayer.Play(song);
                }
                
                if (klavye.IsKeyDown(Keys.Escape))
                {
                    iliikik = true;
                    noter = 600;
                    fzero = 0;
                    menu = 0;
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeMain");
                    MediaPlayer.Play(song);
                    Database.FirstSearch();
                    eldekiItemler[0] = 30;
                    eldekiItemler[1] = 30;
                    eldekiItemler[2] = 30;
                }
                if (klavye.IsKeyDown(Keys.Space) && kafamindengisin[4] == true && sahne == 1)
                {
                    menu = 3;
                    bulunulanbina = 9;
                }
                texture = Content.Load<Texture2D>(sahne + "mask");
                if (!kafamindengisin[4] && !kafamindengisin[0] && !kafamindengisin[1] && !kafamindengisin[2] && !kafamindengisin[3])
                {
                    Hareket.HareketEtme();
                    SahneDüzenleyici.YeniSahneyiKur();
                    SahneDüzenleyici.SahneyeGoreHaritayiHazirla();
                    SahneDüzenleyici.SahneyeGoreRenkAyarla();
                    Canavarlar.HareketEtme();
                    Canavarlar.Carpisma();
                    Canavarlar.YaraBere();
                    CanDurumu.Yaralandim();
                }
                kamera = new Vector2(Game1.koordinat.X - 504, Game1.koordinat.Y - ((graphics.PreferredBackBufferHeight / 2) - 16));
                Hareket.Carpisma();
                Vatandaþlar.Dolasma();
                Menu.EnteringTheMenu();
                zaman.SetTime();
                zaman.SetSkyColor();
                Item.UseItem();
                Item.ItemGetter();
                Animation.SetHero();
                Animation.SetTownsMen();
                if (kafamindengisin[4] || kafamindengisin[0] || kafamindengisin[1] || kafamindengisin[2] || kafamindengisin[3])
                    Vatandaþlar.Konusma();
                if ((lanet < 1 && sahne == 1) || (lanet < 2 && sahne == 23) || (lanet < 3 && sahne == 31))
                    for (int i = 0; i < 4; i++)
                        kasabalix[i] = -3000;
                if (bulunulanbina == -1 && (sahne == 1 || sahne == 6 || sahne == 13 || sahne == 17 || sahne == 20 || sahne == 23 || sahne == 31 || sahne == 35))
                    Canavarsayisi = 0;
                if (lanet >= 3)
                    Boss.LordOfDarknessGuy();
            }
            else if (menu == 2)
            {
                CanDurumu.Oldum();
            }
            else if (menu == 3)
            {
                if (bulunulanbina == 0)
                    Menu.House();
                else if (bulunulanbina == 1)
                    Menu.Market();
                else if (bulunulanbina == 2)
                    Menu.Blacksmith();
                else if (bulunulanbina == 3)
                    Menu.Man();
                else if (bulunulanbina == 4)
                    Menu.Casino();
                else if (bulunulanbina == 5)
                    Menu.Arena();
                else if (bulunulanbina == 6)
                {
                    if (song == Content.Load<Song>("ThemeHaunted"))
                    {
                        MediaPlayer.Stop();
                        song = Content.Load<Song>("ThemeCastle");
                        MediaPlayer.Play(song);
                    }
                    texture = Content.Load<Texture2D>("cast" + dungeonsahne + "mask");
                    Menu.Castle();
                }
                else if (bulunulanbina == 7)
                {
                    if (song != Content.Load<Song>("gameover"))
                    {
                        MediaPlayer.Stop();
                        song = Content.Load<Song>("gameover");
                        MediaPlayer.Play(song);
                        MediaPlayer.IsRepeating = false;
                    }
                    Menu.Death();
                }
                else if (bulunulanbina == 8)
                    Menu.BuyingAHouse();
                else if (bulunulanbina == 9)
                    Menu.Note();
            }
            else if (menu == 4)
            {
                Item.Menu();
            }
            else if (menu == 5)
            {
                kamera = new Vector2(koordinat.X - 504, koordinat.Y - 284);
                if (kamera.X > 896)
                    kamera.X = 896;
                else if (kamera.X < 0)
                    kamera.X = 0;
                if (yes)
                {
                    kolor.R -= 10;
                    kolor.G -= 10;
                    kolor.B -= 10;
                    if (kolor.R <= 5)
                    {
                        yes = false;
                        if (sahne < 18)
                        {
                            sahne = 19;
                            koordinat = new Vector2(248, 1536 - 96);
                            Game1.Canavarsayisi = 1;
                            Game1.Canavartipi[0] = 7;
                            Game1.Canavaryarasayac[0] = 0;
                            Game1.Canavarcan[0] = 8;
                            Game1.Canavaranimasyon[0] = 3;
                            Game1.Canavaryon[0] = SpriteEffects.None;
                            Game1.Canavarkoordinat[0] = new Vector2(864, 1328 - 192);
                        }
                        else if (sahne == 19 && lanet > 0)
                        {
                            sahne = 14;
                            koordinat = new Vector2(1680, 1776 - 96);
                            Game1.Canavarsayisi = 3;
                            Game1.Canavartipi[0] = 1;
                            Game1.Canavaryarasayac[0] = 0;
                            Game1.Canavarcan[0] = 3;
                            Game1.Canavaranimasyon[0] = 3;
                            Game1.Canavaryon[0] = SpriteEffects.None;
                            Game1.Canavarkoordinat[0] = new Vector2(381, 720 - 96);
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
                        else if (sahne == 19)
                        {
                            sahne = 3;
                            lanet += 10;
                            koordinat = new Vector2(1680, 0);
                        }
                        else
                        {
                            sahne = 0;
                            koordinat = new Vector2(288 + 8, 1152 - 96);
                            Game1.Canavarsayisi = 2;
                            Game1.Canavartipi[0] = 0;
                            Game1.Canavaryarasayac[0] = 0;
                            Game1.Canavarcan[0] = 2;
                            Game1.Canavaranimasyon[0] = 3;
                            Game1.Canavaryon[0] = SpriteEffects.None;
                            Game1.Canavarkoordinat[0] = new Vector2(858, 1248 - 96);
                            Game1.Canavartipi[1] = 0;
                            Game1.Canavaryarasayac[1] = 0;
                            Game1.Canavarcan[1] = 2;
                            Game1.Canavaranimasyon[1] = 3;
                            Game1.Canavaryon[1] = SpriteEffects.None;
                            Game1.Canavarkoordinat[1] = new Vector2(296, 1152 - 96);
                        }
                    }
                }
                else
                {
                    kolor.R += 10;
                    kolor.G += 10;
                    kolor.B += 10;
                    if (kolor.R >= 245)
                    {
                        menu = 1;
                        yes = true;
                    }
                }
            }
            else if (menu == 6)
            {
                if (song != Content.Load<Song>("ThemeEnding"))
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeEnding");
                    MediaPlayer.Play(song);
                    MediaPlayer.IsRepeating = false;
                }
                if (klavye.IsKeyDown(Keys.Escape))
                {
                    menu = 0;
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeMain");
                    MediaPlayer.Play(song);
                    MediaPlayer.IsRepeating = true;
                    fzero = 0;
                    lanet = 0;
                    sahne = 1;
                    Database.FirstSearch();
                    eldekiItemler[0] = 30;
                    eldekiItemler[1] = 30;
                    eldekiItemler[2] = 30;
                }
            }
            if (menu != 0)
            {
                fzero++;
                if (fzero >= 60)
                {
                    fzero = 0;
                    gun++;
                }
            }
            if (bosser != Boss.bosser)
            {
                if (Boss.bosser == 0)
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeCastle");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1f;
                }
                else if (Boss.bosser == 1)
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeBoss");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1f;
                }
                else if (Boss.bosser == 2)
                {
                    MediaPlayer.Stop();
                    song = Content.Load<Song>("ThemeVictory");
                    MediaPlayer.Play(song);
                    MediaPlayer.Volume = 1f;
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            if (Game1.kamera.Y > 1920 - graphics.PreferredBackBufferHeight)
                Game1.kamera.Y = 1920 - graphics.PreferredBackBufferHeight;
            if (menu == 0 || menu == 6)
                GraphicsDevice.Clear(Color.Black);
            else if (menu == 5)
                GraphicsDevice.Clear(new Color((byte)(kolor.R * background.R / 255), (byte)(kolor.G * background.G / 255), (byte)(kolor.B * background.B / 255)));
            else
            {
                if ((lanet == 0 && sahne == 1) || (lanet < 2 && sahne == 23) || (lanet < 3 && sahne == 31) || (lanet >= 3 && sahne == 3))
                    GraphicsDevice.Clear(Color.DarkRed);
                else
                    GraphicsDevice.Clear(background);
            }
            spriteBatch.Begin();
            if (menu == 0)
            {
                texture = Content.Load<Texture2D>("anam");
                if (supermegaintro <= 768)
                    spriteBatch.Draw(texture, new Rectangle(0, -supermegaintro, 1024, graphics.PreferredBackBufferHeight * 2), new Rectangle(0, 0, 1024, 1200), Color.White);
                else
                    spriteBatch.Draw(texture, new Rectangle(0, -768, 1024, graphics.PreferredBackBufferHeight * 2), new Rectangle(0, 0, 1024, 1200), Color.White);
                if (supermegaintro == 0)
                {
                    if (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[0] == 0)
                        spriteBatch.DrawString(font, "               New Game (Press G)", new Vector2(300, 230 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                    else
                    {
                        spriteBatch.DrawString(font, "   Game A: Played " + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[0] / 60) + "." + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[0]) % 60 + " minutes (Press G)", new Vector2(300, 230 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                        spriteBatch.DrawString(font, "Delete (Press Z)", new Vector2(770, 230 * graphics.PreferredBackBufferHeight / 600), Color.Red);
                    }
                    if (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[1] == 0)
                        spriteBatch.DrawString(font, "               New Game (Press H)", new Vector2(300, 320 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                    else
                    {
                        spriteBatch.DrawString(font, "   Game B: Played " + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[1] / 60) + "." + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[1]) % 60 + " minutes (Press H)", new Vector2(300, 320 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                        spriteBatch.DrawString(font, "Delete (Press X)", new Vector2(770, 320 * graphics.PreferredBackBufferHeight / 600), Color.Red);
                    }
                    if (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[2] == 0)
                        spriteBatch.DrawString(font, "               New Game (Press J)", new Vector2(300, 410 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                    else
                    {
                        spriteBatch.DrawString(font, "   Game C: Played " + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[2] / 60) + "." + (gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[2]) % 60 + " minutes (Press J)", new Vector2(300, 410 * graphics.PreferredBackBufferHeight / 600), Color.Black);
                        spriteBatch.DrawString(font, "Delete (Press C)", new Vector2(770, 410 * graphics.PreferredBackBufferHeight / 600), Color.Red);
                    }
                    spriteBatch.DrawString(font, "Quit (ESC)", new Vector2(450, 540 * graphics.PreferredBackBufferHeight / 600), Color.Red);
                }
            }
            else if (menu == 1)
            {
                texture = Content.Load<Texture2D>(sahne.ToString());
                spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                texture = Content.Load<Texture2D>("blocks");
                for (int i = 0; i < 8; i++)
                    for (int ii = 0; ii < sahnebloksayisi; ii++)
                        if (BlockActivater[i] && sahnebloktipi[ii] == i)
                            spriteBatch.Draw(texture, new Rectangle((int)(sahneblokkoordinat[ii].X - kamera.X), (int)(sahneblokkoordinat[ii].Y - kamera.Y), 48, 48), new Rectangle(i * 48, 0, 48, 48), karartma);
                if (Game1.sahne == 1 || Game1.sahne == 6 || Game1.sahne == 13 || Game1.sahne == 17 || Game1.sahne == 20 || Game1.sahne == 23 || Game1.sahne == 31 || Game1.sahne == 35)
                {
                    texture = Content.Load<Texture2D>("door");
                    if (sahne == 13 && !benbuevesahibim[1])
                        spriteBatch.Draw(texture, new Rectangle(816 - (int)kamera.X, 1686 - (int)kamera.Y, 96, 90), karartma);
                    else if (sahne == 17 && !benbuevesahibim[2])
                        spriteBatch.Draw(texture, new Rectangle(120 - (int)kamera.X, 1686 - (int)kamera.Y, 96, 90), karartma);
                    else if (sahne == 20 && !benbuevesahibim[3])
                        spriteBatch.Draw(texture, new Rectangle(816 - (int)kamera.X, 1734 - (int)kamera.Y, 96, 90), karartma);
                    else if (sahne == 35 && !benbuevesahibim[4])
                        spriteBatch.Draw(texture, new Rectangle(408 - (int)kamera.X, 1686 - (int)kamera.Y, 96, 90), karartma);
                    texture = Content.Load<Texture2D>("dooor");
                    if (sahne == 1 && lanet > 0)
                        spriteBatch.Draw(texture, new Rectangle(1032 - (int)kamera.X, 1686 - (int)kamera.Y, 93, 90), karartma);
                    else if (sahne == 23 && lanet > 1)
                        spriteBatch.Draw(texture, new Rectangle(1080 - (int)kamera.X, 1686 - (int)kamera.Y, 93, 90), karartma);
                    else if (sahne == 31 && lanet > 2)
                        spriteBatch.Draw(texture, new Rectangle(1056 - (int)kamera.X, 1638 - (int)kamera.Y, 93, 90), karartma);
                    for (int i = 0; i < 4; i++)
                    {
                        texture = Content.Load<Texture2D>("kasabahalký");
                        if (sahne == 20)
                        {
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1824 - 96 - (int)kamera.Y, 48, 96), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 96), kasabalirengi, 0, new Vector2(), kasabaliyon[i], 0);
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1824 - 96 - (int)kamera.Y, 48, 24), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 24), karartma, 0, new Vector2(), kasabaliyon[i], 0);
                        }
                        else if (sahne == 31)
                        {
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1728 - 96 - (int)kamera.Y, 48, 96), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 96), kasabalirengi, 0, new Vector2(), kasabaliyon[i], 0);
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1728 - 96 - (int)kamera.Y, 48, 24), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 24), karartma, 0, new Vector2(), kasabaliyon[i], 0);
                        }
                        else
                        {
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1776 - 96 - (int)kamera.Y, 48, 96), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 96), kasabalirengi, 0, new Vector2(), kasabaliyon[i], 0);
                            spriteBatch.Draw(texture, new Rectangle(kasabalix[i] - (int)kamera.X, 1776 - 96 - (int)kamera.Y, 48, 24), new Rectangle(Animation.kasabalianimasyon[i] * 48, i * 96, 48, 24), karartma, 0, new Vector2(), kasabaliyon[i], 0);
                        }
                    }
                }
                texture = Content.Load<Texture2D>("kasabahalký");
                if (sahne == 4)
                {
                    spriteBatch.Draw(texture, new Rectangle(1765 - (int)kamera.X, 865 - (int)kamera.Y, 48, 96), new Rectangle(0, 192, 48, 96), Color.Red, 0, new Vector2(), SpriteEffects.FlipHorizontally, 0);
                    spriteBatch.Draw(texture, new Rectangle(1765 - (int)kamera.X, 865 - (int)kamera.Y, 48, 21), new Rectangle(0, 192, 48, 21), karartma, 0, new Vector2(), SpriteEffects.FlipHorizontally, 0);
                }
                else if (sahne == 8)
                {
                    spriteBatch.Draw(texture, new Rectangle(192 - (int)kamera.X, 1728 - 96 - (int)kamera.Y, 48, 96), new Rectangle(0, 96, 48, 96), new Color(40, 255, 13), 0, new Vector2(), SpriteEffects.None, 0);
                    spriteBatch.Draw(texture, new Rectangle(192 - (int)kamera.X, 1728 - 96 - (int)kamera.Y, 48, 21), new Rectangle(0, 96, 48, 21), karartma, 0, new Vector2(), SpriteEffects.None, 0);
                }
                texture = Content.Load<Texture2D>("parçacýk");
                if (parcacikkoordinat.X < 2000)
                    spriteBatch.Draw(texture, new Rectangle((int)(parcacikkoordinat.X - kamera.X), (int)(parcacikkoordinat.Y - kamera.Y - 24), 48, 96), new Rectangle(parcacikanimation * 48, 0, 48, 96), Color.White);
                texture = Content.Load<Texture2D>("kayýkçý");
                if (sahne == 14 && lanet > 0)
                    spriteBatch.Draw(texture, new Rectangle(1731 - (int)kamera.X, 1791 - (int)kamera.Y - 96, 96, 96), karartma);
                if ((eldekiItemler[0] == 16 || eldekiItemler[1] == 16 || eldekiItemler[2] == 16) && item[4] == 0 && sahne == 14)
                {
                    texture = Content.Load<Texture2D>("Items");
                    spriteBatch.Draw(texture, new Rectangle(336 - (int)kamera.X, 720 - 42 - (int)kamera.Y, 48, 48), new Rectangle(192, 0, 48, 48), Color.White);
                }
                if (yakubkoordinat.X < 2000)
                {
                    texture = Content.Load<Texture2D>("Items");
                    spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X), (int)(yakubkoordinat.Y - kamera.Y), 48, 48), new Rectangle(0, 48, 48, 48), Color.White);
                }
                if (sahne == 20 && item[24] == 0 && benbuevesahibim[3])
                {
                    if (koordinat.X + 48 > 1004 && 1004 + 16 > koordinat.X)
                    {
                        item[24] = 1;
                        textZ = 1;
                        yaziolantext = "You gained a tomatoe.";
                    }
                    texture = Content.Load<Texture2D>("Items");
                    spriteBatch.Draw(texture, new Rectangle(1004 - (int)kamera.X, 1704 - (int)kamera.Y, 16, 16), new Rectangle(192, 192, 48, 48), Color.White);
                }
                else if (sahne == 35 && item[24] == 0 && benbuevesahibim[4])
                {
                    if (koordinat.X + 48 > 596 && 596 + 16 > koordinat.X)
                    {
                        item[24] = 1;
                        textZ = 1;
                        yaziolantext = "You gained a tomatoe.";
                    }
                    texture = Content.Load<Texture2D>("Items");
                    spriteBatch.Draw(texture, new Rectangle(596 - (int)kamera.X, 1662 - (int)kamera.Y, 16, 16), new Rectangle(192, 192, 48, 48), Color.White);
                }
                texture = Content.Load<Texture2D>("Hero");
                if (eldekiItemler[0] == 14 || eldekiItemler[1] == 14 || eldekiItemler[2] == 14)
                {
                    if (heroyarasayaci % 10 < 5)
                        spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X), (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(heroanimation * 48, 96, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                }
                else
                {
                    if (heroyarasayaci % 10 < 5)
                        spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X), (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(heroanimation * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                }
                if (heroanimation >= 10 && heroyarasayaci % 10 < 5)
                {
                    if (heroyon == SpriteEffects.None)
                        spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X) + 48, (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(12 * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                    else
                        spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X) - 48, (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(12 * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                }
                if (lanet >= 3 && sahne == 3)
                {
                    if (!Boss.form)
                    {
                        if (Boss.bossyarasayaci % 10 < 5 && Boss.bosscan >= 0)
                        {
                            texture = Content.Load<Texture2D>("boss3");
                            spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X), (int)(Boss.bosskoordinat.Y - kamera.Y), 96, 96), new Rectangle(Boss.bossanimation * 96, 0, 96, 96), karartma);
                            if (Boss.bossanimation == 2)
                            {
                                texture = Content.Load<Texture2D>("megadalga");
                                spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X), (int)(Boss.bosskoordinat.Y + 64 - kamera.Y), 96, 1000), new Rectangle(0, 0, 96, 1), karartma);
                            }
                        }
                        else if (Boss.bosscan <= 0)
                        {
                            texture = Content.Load<Texture2D>("boss4");
                            spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X + 24), (int)(Boss.bosskoordinat.Y - kamera.Y), 48, 96), new Rectangle(Boss.bossanimation * 48, 0, 48, 96), karartma);
                        }
                    }
                    else
                    {
                        if (Boss.bossyarasayaci % 10 < 5)
                        {
                            texture = Content.Load<Texture2D>("boss4");
                            spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X + 24), (int)(Boss.bosskoordinat.Y - kamera.Y), 48, 96), new Rectangle(Boss.bossanimation * 48, 0, 48, 96), karartma, 0, Vector2.Zero, Boss.bossyon, 0);
                        }
                        texture = Content.Load<Texture2D>("canbol");
                        for (int i = 0; i < 24; i++)
                            spriteBatch.Draw(texture, new Rectangle((int)(Boss.ballkoordinat[i].X - kamera.X), (int)(Boss.ballkoordinat[i].Y - kamera.Y), 24, 24), new Rectangle(72, 0, 24, 24), Color.White);
                    }
                }
                for (int i = 0; i < Canavarsayisi; i++)
                {
                    texture = Content.Load<Texture2D>("canbol");
                    if (Canavartipi[i] == 2)
                        spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(0, 0, 24, 24), karartma);
                    else if (Canavartipi[i] == 5)
                        spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(24, 0, 24, 24), karartma);
                    else if (Canavartipi[i] == 7)
                        spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(48, 0, 24, 24), karartma);
                    texture = Content.Load<Texture2D>("can" + Canavartipi[i]);
                    if (Canavaryarasayac[i] % 10 < 5 && herocan > 0)
                    {
                        if (Canavartipi[i] == 6 || Canavartipi[i] == 8 || Canavartipi[i] == 2)
                            spriteBatch.Draw(texture, new Rectangle((int)(Canavarkoordinat[i].X - kamera.X), (int)(Canavarkoordinat[i].Y - kamera.Y), 48, 48), new Rectangle(Canavaranimasyon[i] * 48, canavaryenitip[i] * 48, 48, 48), karartma, 0, Vector2.Zero, Canavaryon[i], 0);
                        else
                            spriteBatch.Draw(texture, new Rectangle((int)(Canavarkoordinat[i].X - kamera.X), (int)(Canavarkoordinat[i].Y - kamera.Y), 48, 96), new Rectangle(Canavaranimasyon[i] * 48, canavaryenitip[i] * 96, 48, 96), karartma, 0, Vector2.Zero, Canavaryon[i], 0);
                    }
                }
                if (sahne == 8 || sahne == 15 || sahne == 21 || sahne == 34)
                {
                    texture = Content.Load<Texture2D>(sahne + "front");
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                }
                for (int i = 0; i < 5; i++)
                    if (kafamindengisin[i])
                    {
                        texture = Content.Load<Texture2D>("table");
                        spriteBatch.Draw(texture, new Rectangle(50, 200, 240, tableuzunluk), new Rectangle(0, 0, 240, tableuzunluk), Color.White);
                        if (tableuzunluk == 240)
                            spriteBatch.DrawString(font, text[secilitext], new Vector2(70, 220), Color.Black);
                    }
                texture = Content.Load<Texture2D>("saat");
                spriteBatch.Draw(texture, new Rectangle(20, 499 + (graphics.PreferredBackBufferHeight - 600), 81, 81), Color.White);
                texture = Content.Load<Texture2D>("akrep");
                spriteBatch.Draw(texture, new Rectangle(60, 539 + (graphics.PreferredBackBufferHeight - 600), 39, 15), new Rectangle(0, 0, 39, 15), Color.White, saat / 60, new Vector2(7, 7), SpriteEffects.None, 0);
                if (maper)
                {
                        texture = Content.Load<Texture2D>("map");
                        spriteBatch.Draw(texture, new Rectangle(701, 50, map, texture.Height), new Rectangle(0, 0, map, texture.Height), Color.White);
                        spriteBatch.DrawString(font, placenames[sahne], new Vector2(701, 20), Color.Red);
                        if (animasyonolmayanC < 8)
                            spriteBatch.Draw(texture, new Rectangle((int)mapzer.X, (int)mapzer.Y, 3, 3), new Rectangle(0, 0, 3, 3), Color.White);
                }
                texture = Content.Load<Texture2D>("canbar");
                spriteBatch.Draw(texture, new Rectangle(20, 20, 180, 30), new Rectangle(0, 0, 180, 30), Color.DarkGray);
                spriteBatch.Draw(texture, new Rectangle(20, 20, herocan * 30, 30), new Rectangle(0, 0, herocan * 30, 30), Color.White);
                if (eldekiItemler[0] == 14 || eldekiItemler[1] == 14 || eldekiItemler[2] == 14)
                {
                    texture = Content.Load<Texture2D>("kalkancan");
                    spriteBatch.Draw(texture, new Rectangle(20, 50, 106, 21), new Rectangle(0, 0, 106, 21), Color.DarkGray);
                    spriteBatch.Draw(texture, new Rectangle(20, 50, kalkancan + 3, 21), new Rectangle(0, 0, kalkancan + 3, 21), Color.White);
                }
                texture = Content.Load<Texture2D>("ItemMenu");
                spriteBatch.Draw(texture, new Rectangle(830, 526 + (graphics.PreferredBackBufferHeight - 600), 174, 54), new Rectangle(0, 0, 174, 54), Color.White);
                for (int i = 0; i < 3; i++)
                    if (eldekiItemler[i] < 30)
                    {
                        texture = Content.Load<Texture2D>("ItemMenu");
                        spriteBatch.Draw(texture, new Rectangle(833 + (i * 60), 529 + (graphics.PreferredBackBufferHeight - 600), 48, 48), new Rectangle(4, 4, 10, 10), Color.White);
                        texture = Content.Load<Texture2D>("Items");
                        spriteBatch.Draw(texture, new Rectangle(833 + (i * 60), 529 + (graphics.PreferredBackBufferHeight - 600), 48, 48), new Rectangle((eldekiItemler[i] % 5) * 48, (eldekiItemler[i] / 5) * 48, 48, 48), Color.White);
                    }
                if (sahne == 3 && lanet >= 3)
                    spriteBatch.DrawString(font, "Use mystical liquid to defeat Ailebra, after he gets tired", new Vector2(20, 104), Color.Green);
                else if (textZ > 0)
                    spriteBatch.DrawString(font, yaziolantext, new Vector2(20, 104), Color.Green);
                texture = Content.Load<Texture2D>("Hero");
                spriteBatch.Draw(texture, new Rectangle(20, 80, 18, 21), new Rectangle(14, 0, 18, 21), Color.White);
                spriteBatch.DrawString(font, "x " + herohak, new Vector2(42, 78), Color.Green);
                if (iliikik && gun < 2)
                {
                    iliikik = false;
                    kafamindengisin[4] = true;
                    secilitext = 45;
                }
            }
            else if (menu == 2)
            {
                if (Hareket.dungeon)
                {
                    texture = Content.Load<Texture2D>("Hero");
                    spriteBatch.Draw(texture, new Rectangle((int)(dungeonkoordinat.X - kamera.X), (int)(dungeonkoordinat.Y - kamera.Y), 48, 96), new Rectangle(0, 0, 48, 96), karartma);
                    texture = Content.Load<Texture2D>("cast" + dungeonsahne);
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                }
                else
                {
                    texture = Content.Load<Texture2D>("Hero");
                    spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X), (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(0, 0, 48, 96), karartma);
                    texture = Content.Load<Texture2D>(sahne.ToString());
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    if (sahne == 8 || sahne == 15 || sahne == 21 || sahne == 34)
                    {
                        texture = Content.Load<Texture2D>(sahne + "front");
                        spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    }
                }
            }
            else if (menu == 3)
            {
                if (bulunulanbina != 3 && bulunulanbina != 6 && bulunulanbina != 7 && bulunulanbina != 8 && bulunulanbina != 9)
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(0, 0, 1024, 84), new Rectangle(0, 0, 1024, 61), kasabalirengi);
                    spriteBatch.Draw(texture, new Rectangle(0, (graphics.PreferredBackBufferHeight - 600) / 2, 1024, 600), kasabalirengi);
                    spriteBatch.Draw(texture, new Rectangle(0, 684, 1024, 84), new Rectangle(0, 0, 1024, 64), kasabalirengi);
                }
                if (bulunulanbina == 0)
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    spriteBatch.DrawString(font, "What would you like to do\nin your house?\n\n\n\n\nSave the game (G or Z)\nQuit the game (H or X)\nNothing (J or C)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 1)//Market
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    spriteBatch.DrawString(font, "You can sell your items to me.\nYou have " + item[26] + " meat, " + item[27] + " monster skin\nand " + item[28] + " feather.\nI will give you " + ((20 * item[26]) + (10 * item[27]) + (30 * item[28])) + " coins\nfor them.\n\n\n\nSell (G or Z)\nDo not sell (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 2)//Demirci
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    spriteBatch.DrawString(font, "I can make shields from bones.\nIf you give me 3 bones, I will make\na shield for you.\n\n\n\nGive him 3 bones (G or Z)\nDo not give him 3 bones (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 3)//Asshole
                {
                    texture = Content.Load<Texture2D>(sahne.ToString());
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    if (item[9] == 0)
                        spriteBatch.DrawString(font, "You want a stone dagger?\nIt is stronger than your stone knife\nand it is just 25 coins.\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else if (item[10] == 0)
                        spriteBatch.DrawString(font, "You want a silver dagger?\nIt is stronger than your stone dagger\nand it is just 50 coins.\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else if (item[11] == 0 && sahne == 6)
                        spriteBatch.DrawString(font, "You already have\nall the weapons\nI sell.\nMaybe in another town\nyou can find stronger\nweapons.\n\n\nExit (G or Z)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else if (item[11] == 0)
                        spriteBatch.DrawString(font, "You want a silver sword?\nIt is stronger than your silver dagger\nand it is just 100 coins.\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else if (item[12] == 0 && sahne < 19)
                        spriteBatch.DrawString(font, "You already have\nall the weapons\nI sell.\nMaybe in another town\nyou can find stronger\nweapons.\n\n\nExit (G or Z)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else if (item[12] == 0)
                        spriteBatch.DrawString(font, "You want a magical sword?\nIt is stronger than your silver sword\nand it is just 150 coins.\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else
                        spriteBatch.DrawString(font, "You already have\nall the weapons\nI sell.\n\n\n\nExit (G or Z)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 4)
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    spriteBatch.DrawString(font, "Let's play a game.\nI will think a number\nand you will guess.\nIf you find the number,\nI will give you 20 coins.\nOtherwise you will give\nme 10 coins. Let's play.\n\n\n1 (G or Z)\n2 (H or X)\n3 (J or C)\nDo not play (K or V)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 5)
                {
                    menu = 1;
                    bulunulanbina = -1;
                }
                else if (bulunulanbina == 6)
                {
                    texture = Content.Load<Texture2D>("cast" + dungeonsahne);
                        spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    texture = Content.Load<Texture2D>("blocks");
                    for (int i = 0; i < 8; i++)
                        for (int ii = 0; ii < sahnebloksayisi; ii++)
                            if (BlockActivater[i] && sahnebloktipi[ii] == i)
                                spriteBatch.Draw(texture, new Rectangle((int)(sahneblokkoordinat[ii].X - kamera.X), (int)(sahneblokkoordinat[ii].Y - kamera.Y), 48, 48), new Rectangle(i * 48, 0, 48, 48), karartma);
                    
                    texture = Content.Load<Texture2D>("parçacýk");
                    if (parcacikkoordinat.X < 2000)
                        spriteBatch.Draw(texture, new Rectangle((int)(parcacikkoordinat.X - kamera.X), (int)(parcacikkoordinat.Y - kamera.Y - 24), 48, 96), new Rectangle(parcacikanimation * 48, 0, 48, 96), karartma);
                    texture = Content.Load<Texture2D>("kapi");
                    spriteBatch.Draw(texture, new Rectangle((int)(kapikoordinat.X - kamera.X), (int)(kapikoordinat.Y - kamera.Y), 48, 96), karartma);
                    texture = Content.Load<Texture2D>("Items");
                    spriteBatch.Draw(texture, new Rectangle((int)(anahtarkoordinat.X - kamera.X), (int)(anahtarkoordinat.Y - kamera.Y), 48, 48), new Rectangle(144, 192, 48, 48), karartma);
                    if (dungeonsahne == 1 && Boss.bossyarasayaci % 10 < 5)
                    {
                        texture = Content.Load<Texture2D>("boss0");
                        spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X), (int)(Boss.bosskoordinat.Y - kamera.Y), 96, 96), new Rectangle(Boss.bossanimation * 96, 0, 96, 96), karartma, 0, new Vector2(), Boss.bossyon, 0);
                    }
                    else if (dungeonsahne == 3 && Boss.bossyarasayaci % 10 < 5)
                    {
                        texture = Content.Load<Texture2D>("boss1");
                        spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X), (int)(Boss.bosskoordinat.Y - kamera.Y), 96, 96), new Rectangle(Boss.bossanimation * 96, 0, 96, 96), karartma, 0, new Vector2(), Boss.bossyon, 0);
                    }
                    else if (dungeonsahne == 5 && Boss.bossyarasayaci % 10 < 5)
                    {
                        texture = Content.Load<Texture2D>("boss2");
                        spriteBatch.Draw(texture, new Rectangle((int)(Boss.bosskoordinat.X - kamera.X), (int)(Boss.bosskoordinat.Y - kamera.Y), 72, 72), new Rectangle(Boss.bossanimation * 72, 0, 72, 72), karartma);
                    }
                    if (dungeonsahne == 3 && item[6] == 0)
                    {
                        if (dungeonkoordinat.X + 48 > 192 && 192 + 48 > dungeonkoordinat.X && dungeonkoordinat.Y + 96 > 1104 - 48 && 1104 - 48 + 96 > dungeonkoordinat.Y)
                        {
                            item[6] = 1;
                            textZ = 1;
                            yaziolantext = "You gained black yakub!";
                        }
                        texture = Content.Load<Texture2D>("Items");
                        spriteBatch.Draw(texture, new Rectangle(192 - (int)kamera.X, 1104 - 48 - (int)kamera.Y, 48, 48), new Rectangle(48, 48, 48, 48), karartma);
                    }
                    texture = Content.Load<Texture2D>("Hero");
                    if (eldekiItemler[0] == 14 || eldekiItemler[1] == 14 || eldekiItemler[2] == 14)
                    {
                        if (heroyarasayaci % 10 < 5)
                            spriteBatch.Draw(texture, new Rectangle((int)(dungeonkoordinat.X - kamera.X), (int)(dungeonkoordinat.Y - kamera.Y), 48, 96), new Rectangle(heroanimation * 48, 96, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                    }
                    else
                    {
                        if (heroyarasayaci % 10 < 5)
                            spriteBatch.Draw(texture, new Rectangle((int)(dungeonkoordinat.X - kamera.X), (int)(dungeonkoordinat.Y - kamera.Y), 48, 96), new Rectangle(heroanimation * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                    }
                    if (heroanimation >= 10 && heroyarasayaci % 10 < 5)
                    {
                        if (heroyon == SpriteEffects.None)
                            spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X) + 48, (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(12 * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                        else
                            spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X) - 48, (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(12 * 48, 0, 48, 96), karartma, 0, new Vector2(), heroyon, 0);
                    }
                    for (int i = 0; i < Canavarsayisi; i++)
                    {
                        texture = Content.Load<Texture2D>("canbol");
                        if (Canavartipi[i] == 2)
                            spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(0, 0, 24, 24), karartma);
                        else if (Canavartipi[i] == 5)
                            spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(24, 0, 24, 24), karartma);
                        else if (Canavartipi[i] == 7)
                            spriteBatch.Draw(texture, new Rectangle((int)(Canavarlar.snowballer[i].X - kamera.X), (int)(Canavarlar.snowballer[i].Y - kamera.Y), 24, 24), new Rectangle(48, 0, 24, 24), karartma);
                        texture = Content.Load<Texture2D>("can" + Canavartipi[i]);
                        if (Canavaryarasayac[i] % 10 < 5 && herocan > 0)
                        {
                            if (Canavartipi[i] == 6 || Canavartipi[i] == 8 || Canavartipi[i] == 2)
                                spriteBatch.Draw(texture, new Rectangle((int)(Canavarkoordinat[i].X - kamera.X), (int)(Canavarkoordinat[i].Y - kamera.Y), 48, 48), new Rectangle(Canavaranimasyon[i] * 48, canavaryenitip[i] * 48, 48, 48), karartma, 0, Vector2.Zero, Canavaryon[i], 0);
                            else
                                spriteBatch.Draw(texture, new Rectangle((int)(Canavarkoordinat[i].X - kamera.X), (int)(Canavarkoordinat[i].Y - kamera.Y), 48, 96), new Rectangle(Canavaranimasyon[i] * 48, canavaryenitip[i] * 96, 48, 96), karartma, 0, Vector2.Zero, Canavaryon[i], 0);
                        }
                    }
                    texture = Content.Load<Texture2D>("canbar");
                    spriteBatch.Draw(texture, new Rectangle(20, 20, 180, 30), new Rectangle(0, 0, 180, 30), Color.DarkGray);
                    spriteBatch.Draw(texture, new Rectangle(20, 20, herocan * 30, 30), new Rectangle(0, 0, herocan * 30, 30), Color.White);
                    if (eldekiItemler[0] == 14 || eldekiItemler[1] == 14 || eldekiItemler[2] == 14)
                    {
                        texture = Content.Load<Texture2D>("kalkancan");
                        spriteBatch.Draw(texture, new Rectangle(20, 50, 106, 21), new Rectangle(0, 0, 106, 21), Color.DarkGray);
                        spriteBatch.Draw(texture, new Rectangle(20, 50, kalkancan + 3, 21), new Rectangle(0, 0, kalkancan + 3, 21), Color.White);
                    }
                    texture = Content.Load<Texture2D>("ItemMenu");
                    spriteBatch.Draw(texture, new Rectangle(830, 526 + (graphics.PreferredBackBufferHeight - 600), 174, 54), new Rectangle(0, 0, 174, 54), Color.White);
                    for (int i = 0; i < 3; i++)
                        if (eldekiItemler[i] < 30)
                        {
                            texture = Content.Load<Texture2D>("ItemMenu");
                            spriteBatch.Draw(texture, new Rectangle(833 + (i * 60), 529 + (graphics.PreferredBackBufferHeight - 600), 48, 48), new Rectangle(4, 4, 10, 10), Color.White);
                            texture = Content.Load<Texture2D>("Items");
                            spriteBatch.Draw(texture, new Rectangle(833 + (i * 60), 529 + (graphics.PreferredBackBufferHeight - 600), 48, 48), new Rectangle((eldekiItemler[i] % 5) * 48, (eldekiItemler[i] / 5) * 48, 48, 48), Color.White);
                        }
                    if (lanet >= 3 && sahne == 3)
                        spriteBatch.DrawString(font, "Use mystical liquid to defeat Ailebra, after he gets tired", new Vector2(20, 104), Color.Green);
                    else if (textZ > 0 && dungeonsahne >= 4)
                        spriteBatch.DrawString(font, yaziolantext, new Vector2(20, 104), Color.Red);
                    else if (textZ > 0)
                        spriteBatch.DrawString(font, yaziolantext, new Vector2(20, 104), Color.Green);
                    texture = Content.Load<Texture2D>("Hero");
                    spriteBatch.Draw(texture, new Rectangle(20, 80, 18, 21), new Rectangle(14, 0, 18, 21), Color.White);
                    if (dungeonsahne >= 4)
                        spriteBatch.DrawString(font, "x " + herohak, new Vector2(42, 78), Color.Red);
                    else
                        spriteBatch.DrawString(font, "x " + herohak, new Vector2(42, 78), Color.Green);
                }
                else if (bulunulanbina == 7)
                {
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(0, 0, 1024, graphics.PreferredBackBufferHeight), new Rectangle(0, 0, 1024, 600), Color.White);
                    spriteBatch.DrawString(font, "GAME OVER\n\n\nThe chosen hero from Rotta died.\nHe was just a coward chicken.\n\n\n\nStart from last save (G or Z)\nQuit (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 8)
                {
                    texture = Content.Load<Texture2D>(sahne.ToString());
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    texture = Content.Load<Texture2D>("menuler");
                    spriteBatch.Draw(texture, new Rectangle(255, 69 + ((graphics.PreferredBackBufferHeight - 600) / 2), 731 - 255, 505 - 69), new Rectangle(255, 69, 731 - 255, 505 - 69), Color.White);
                    if (sahne > 18)
                        spriteBatch.DrawString(font, "Do you want to buy\nthis house?\nIt has a garden and\nit is just 250 coins.\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                    else
                        spriteBatch.DrawString(font, "Do you want to buy\nthis house?\nIt is just 150 coins.\n\n\n\n\nBuy (G or Z)\nDo not buy (H or X)", new Vector2(300, 100 + ((graphics.PreferredBackBufferHeight - 600) / 2)), Color.Black);
                }
                else if (bulunulanbina == 9)
                {
                    texture = Content.Load<Texture2D>(sahne.ToString());
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                    texture = Content.Load<Texture2D>("not");
                    spriteBatch.Draw(texture, new Rectangle(150, noter + ((graphics.PreferredBackBufferHeight - 600) / 2), 400, 600), Color.White);
                    texture = Content.Load<Texture2D>("inst");
                    spriteBatch.Draw(texture, new Rectangle(600, noter + ((graphics.PreferredBackBufferHeight - 600) / 2), 342, 600), Color.White);
                }
            }
            else if (menu == 4)
            {
                if (Hareket.dungeon)
                    texture = Content.Load<Texture2D>("cast" + dungeonsahne);
                else
                    texture = Content.Load<Texture2D>(sahne.ToString());
                spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                if (sahne == 8 || sahne == 15 || sahne == 21 || sahne == 34)
                {
                    texture = Content.Load<Texture2D>(sahne + "front");
                    spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), karartma);
                }
                texture = Content.Load<Texture2D>("ItemMenu");
                spriteBatch.Draw(texture, new Rectangle(350, itemmenuy, texture.Width, texture.Height), Color.White);
                if (item[seciliItem] > 0)
                    spriteBatch.DrawString(font, itemname[seciliItem], new Vector2(550, itemmenuy + 20), Color.Red);
                texture = Content.Load<Texture2D>("Items");
                for (int i = 0; i < 30; i++)
                {
                    if (item[i] > 0)
                        spriteBatch.Draw(texture, new Rectangle(353 + ((i % 5) * 60), itemmenuy + 78 + ((i / 5) * 60), 48, 48), new Rectangle((i % 5) * 48, (i / 5) * 48, 48, 48), Color.White);
                    if (item[i] > 1)
                        spriteBatch.DrawString(font, item[i] + "", new Vector2(353 + ((i % 5) * 60), itemmenuy + 78 + ((i / 5) * 60)), Color.Red);
                }
                for (int i = 0; i < 3; i++)
                    if (eldekiItemler[i] < 30)
                        spriteBatch.Draw(texture, new Rectangle(353 + (i * 60), 3 + itemmenuy, 48, 48), new Rectangle((eldekiItemler[i] % 5) * 48, (eldekiItemler[i] / 5) * 48, 48, 48), Color.White);
                texture = Content.Load<Texture2D>("ItemSelected");
                if (itemmenuy >= 21)
                    spriteBatch.Draw(texture, new Rectangle(347 + ((seciliItem % 5) * 60), 102 + ((seciliItem / 5) * 60), 60, 60), Color.White);
            }
            else if (menu == 5)
            {
                texture = Content.Load<Texture2D>(sahne.ToString());
                spriteBatch.Draw(texture, new Rectangle(-(int)kamera.X, -(int)kamera.Y, 1920, 1920), kolor);
                texture = Content.Load<Texture2D>("Hero");
                if (heroyarasayaci % 10 < 5)
                    spriteBatch.Draw(texture, new Rectangle((int)(koordinat.X - kamera.X), (int)(koordinat.Y - kamera.Y), 48, 96), new Rectangle(heroanimation * 48, 0, 48, 96), kolor, 0, new Vector2(), heroyon, 0);
            }
            else if (menu == 6)
            {
                texture = Content.Load<Texture2D>("end");
                spriteBatch.Draw(texture, new Rectangle(0, 0, 1024, graphics.PreferredBackBufferHeight), new Rectangle(0, 0, 1024, 600), Color.White);
            }
            texture = Content.Load<Texture2D>("anam");
            spriteBatch.Draw(texture, new Rectangle(1024, 0, 1024, 1024), new Rectangle(0, 0, 48, 48), Color.Black);
            spriteBatch.Draw(texture, new Rectangle(0, graphics.PreferredBackBufferHeight, 1024, 1024), new Rectangle(0, 0, 48, 48), Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
