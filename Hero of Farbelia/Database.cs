using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
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
    class Database
    {
        public static void Delete()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source = farbeliasav.mdb");
            baglanti.Open();
            string sql = "Update sav set [sahne] = '1',[x] = '744',[y]='1680',[ev1]= '1',[ev2]='0',[ev3]='0',[ev4]='0',[ev5]='0',[saat]='96',[gun]='0',[bred]='153',[bgreen]='217',[bblue]='234',[kred]='255',[kgreen]='255',[kblue]='255',[item1]='0',[item2]='0',[item3]='0',[item4]='0',[item5]='0',[item6]='0',[item7]='0',[item8]='0',[item9]='1',[item10]='0',[item11]='0',[item12]='0',[item13]='0',[item14]='0',[item15]='0',[item16]='0',[item17]='0',[item18]='0',[item19]='0',[item20]='0',[item21]='0',[item22]='0',[item23]='0',[item24]='0',[item25]='0',[item26]='0',[item27]='0',[item28]='0',[item29]='0',[item30]='0',[lanet]='0',[iksirmission]='0',[map]='63',[kalkancan]='100',[konustumulan]='0' Where [slot]='" + Game1.geym + "'";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void Grafix()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source = farbeliasav.mdb");
            baglanti.Open();
            string sql = "Update sav set [ALAN]='" + grafiks + "' Where [slot]='1'";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static int grafiks = 0;
        public static void FirstSearch()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source = farbeliasav.mdb");
            baglanti.Open();
            string sql = "Select * from sav Where [slot] = '1'";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            OleDbDataReader reader = komut.ExecuteReader();
            reader.Read();
            Game1.gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[0] = Convert.ToInt32(reader.GetValue(11));
            grafiks = Convert.ToInt32(reader.GetValue(53));
            sql = "Select * from sav Where [slot] = '2'";
            komut = new OleDbCommand(sql, baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            Game1.gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[1] = Convert.ToInt32(reader.GetValue(11));
            sql = "Select * from sav Where [slot] = '3'";
            komut = new OleDbCommand(sql, baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            Game1.gosteripdevermeyengunlericinsifirbesyuzonikiikiyuzotuzbiryirmiondort[2] = Convert.ToInt32(reader.GetValue(11));
            baglanti.Close();
        }

        public static void SecondSearch()
        {
            int[] ev = new int[6];
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source = farbeliasav.mdb");
            baglanti.Open();
            string sql = "Select * from sav Where [slot] = '" + Game1.geym + "'";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            OleDbDataReader reader = komut.ExecuteReader();
            reader.Read();
            Game1.sahne = Convert.ToInt32(reader.GetValue(2));
            Game1.koordinat.X = (float)Convert.ToInt32(reader.GetValue(3));
            Game1.koordinat.Y = (float)Convert.ToInt32(reader.GetValue(4));
            ev[0] = Convert.ToInt32(reader.GetValue(5));
            ev[1] = Convert.ToInt32(reader.GetValue(6));
            ev[2] = Convert.ToInt32(reader.GetValue(7));
            ev[3] = Convert.ToInt32(reader.GetValue(8));
            ev[4] = Convert.ToInt32(reader.GetValue(9));
            Game1.saat = (float)Convert.ToInt32(reader.GetValue(10));
            Game1.gun = Convert.ToInt32(reader.GetValue(11));
            Game1.background.R = (byte)Convert.ToInt32(reader.GetValue(12));
            Game1.background.G = (byte)Convert.ToInt32(reader.GetValue(13));
            Game1.background.B = (byte)Convert.ToInt32(reader.GetValue(14));
            Game1.karartma.R = (byte)Convert.ToInt32(reader.GetValue(15));
            Game1.karartma.G = (byte)Convert.ToInt32(reader.GetValue(16));
            Game1.karartma.B = (byte)Convert.ToInt32(reader.GetValue(17));
            Game1.item[0] = Convert.ToInt32(reader.GetValue(18));
            Game1.item[1] = Convert.ToInt32(reader.GetValue(19));
            Game1.item[2] = Convert.ToInt32(reader.GetValue(20));
            Game1.item[3] = Convert.ToInt32(reader.GetValue(21));
            Game1.item[4] = Convert.ToInt32(reader.GetValue(22));
            Game1.item[5] = Convert.ToInt32(reader.GetValue(23));
            Game1.item[6] = Convert.ToInt32(reader.GetValue(24));
            Game1.item[7] = Convert.ToInt32(reader.GetValue(25));
            Game1.item[8] = Convert.ToInt32(reader.GetValue(26));
            Game1.item[9] = Convert.ToInt32(reader.GetValue(27));
            Game1.item[10] = Convert.ToInt32(reader.GetValue(28));
            Game1.item[11] = Convert.ToInt32(reader.GetValue(29));
            Game1.item[12] = Convert.ToInt32(reader.GetValue(30));
            Game1.item[13] = Convert.ToInt32(reader.GetValue(31));
            Game1.item[14] = Convert.ToInt32(reader.GetValue(32));
            Game1.item[15] = Convert.ToInt32(reader.GetValue(33));
            Game1.item[16] = Convert.ToInt32(reader.GetValue(34));
            Game1.item[17] = Convert.ToInt32(reader.GetValue(35));
            Game1.item[18] = Convert.ToInt32(reader.GetValue(36));
            Game1.item[19] = Convert.ToInt32(reader.GetValue(37));
            Game1.item[20] = Convert.ToInt32(reader.GetValue(38));
            Game1.item[21] = Convert.ToInt32(reader.GetValue(39));
            Game1.item[22] = Convert.ToInt32(reader.GetValue(40));
            Game1.item[23] = Convert.ToInt32(reader.GetValue(41));
            Game1.item[24] = Convert.ToInt32(reader.GetValue(42));
            Game1.item[25] = Convert.ToInt32(reader.GetValue(43));
            Game1.item[26] = Convert.ToInt32(reader.GetValue(44));
            Game1.item[27] = Convert.ToInt32(reader.GetValue(45));
            Game1.item[28] = Convert.ToInt32(reader.GetValue(46));
            Game1.item[29] = Convert.ToInt32(reader.GetValue(47));
            Game1.lanet = Convert.ToInt32(reader.GetValue(48));
            Game1.iksirmission = Convert.ToInt32(reader.GetValue(49));
            Game1.map = Convert.ToInt32(reader.GetValue(50));
            Game1.kalkancan = Convert.ToInt32(reader.GetValue(51));
            ev[5] = Convert.ToInt32(reader.GetValue(52));
            for (int i = 0; i < 5; i++)
            {
                if (ev[i] == 1)
                    Game1.benbuevesahibim[i] = true;
                else
                    Game1.benbuevesahibim[i] = false;
            }
            if (ev[5] == 1)
                Game1.konustumulan = true;
            else
                Game1.konustumulan = false;
            baglanti.Close();
        }

        public static void Update()
        {
            int[] ev = new int[6];
            for (int i = 0; i < 5; i++)
            {
                if (Game1.benbuevesahibim[i])
                    ev[i] = 1;
                else
                    ev[i] = 0;
            }
            if (Game1.konustumulan)
                ev[5] = 1;
            else
                ev[5] = 0;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source = farbeliasav.mdb");
            baglanti.Open();
            string sql = "Update sav set [sahne] = '" + Game1.sahne + "',[x] = '" + Game1.koordinat.X + "',[y]='" + Game1.koordinat.Y + "',[ev1]= '" + ev[0] + "',[ev2]='" + ev[1] + "',[ev3]='" + ev[2] + "',[ev4]='" + ev[3] + "',[ev5]='" + ev[4] + "',[saat]='" + (int)Game1.saat + "',[gun]='" + Game1.gun + "',[bred]='" + Game1.background.R + "',[bgreen]='" + Game1.background.G + "',[bblue]='" + Game1.background.B + "',[kred]='" + Game1.karartma.R + "',[kgreen]='" + Game1.karartma.G + "',[kblue]='" + Game1.karartma.B + "',[item1]='" + Game1.item[0] + "',[item2]='" + Game1.item[1] + "',[item3]='" + Game1.item[2] + "',[item4]='" + Game1.item[3] + "',[item5]='" + Game1.item[4] + "',[item6]='" + Game1.item[5] + "',[item7]='" + Game1.item[6] + "',[item8]='" + Game1.item[7] + "',[item9]='" + Game1.item[8] + "',[item10]='" + Game1.item[9] + "',[item11]='" + Game1.item[10] + "',[item12]='" + Game1.item[11] + "',[item13]='" + Game1.item[12] + "',[item14]='" + Game1.item[13] + "',[item15]='" + Game1.item[14] + "',[item16]='" + Game1.item[15] + "',[item17]='" + Game1.item[16] + "',[item18]='" + Game1.item[17] + "',[item19]='" + Game1.item[18] + "',[item20]='" + Game1.item[19] + "',[item21]='" + Game1.item[20] + "',[item22]='" + Game1.item[21] + "',[item23]='" + Game1.item[22] + "',[item24]='" + Game1.item[23] + "',[item25]='" + Game1.item[24] + "',[item26]='" + Game1.item[25] + "',[item27]='" + Game1.item[26] + "',[item28]='" + Game1.item[27] + "',[item29]='" + Game1.item[28] + "',[item30]='" + Game1.item[29] + "',[lanet]='" + Game1.lanet + "',[iksirmission]='" + Game1.iksirmission + "',[map]='" + Game1.map + "',[kalkancan]='" + Game1.kalkancan + "',[konustumulan]='" + ev[5] + "' Where [slot]='" + Game1.geym + "'";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
