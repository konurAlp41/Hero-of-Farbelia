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
    class TextDüzenleyici
    {
        public static void CreateText()
        {
            Game1.itemname[0] = "Red Yakub";
            Game1.itemname[1] = "Green Yakub";
            Game1.itemname[2] = "Blue Yakub";
            Game1.itemname[3] = "Purple Yakub";
            Game1.itemname[4] = "White Yakub";
            Game1.itemname[5] = "Gray Yakub";
            Game1.itemname[6] = "Black Yakub";
            Game1.itemname[7] = "Pink Yakub";
            Game1.itemname[8] = "Stone Knife";
            Game1.itemname[9] = "Stone Dagger";
            Game1.itemname[10] = "Silver Dagger";
            Game1.itemname[11] = "Silver Sword";
            Game1.itemname[12] = "Magical Sword";
            Game1.itemname[13] = "Mystical Liquid";
            Game1.itemname[14] = "Shield";
            Game1.itemname[15] = "Map";
            Game1.itemname[16] = "Glasses";
            Game1.itemname[17] = "Blackberries";
            Game1.itemname[18] = "Bamboo";
            Game1.itemname[19] = "Gambo Stone";
            Game1.itemname[20] = "Easter Egg";
            Game1.itemname[21] = "Easter Egg";
            Game1.itemname[22] = "Easter Egg";
            Game1.itemname[23] = "Key";
            Game1.itemname[24] = "Tomatoe";
            Game1.itemname[25] = "Bones";
            Game1.itemname[26] = "Meats";
            Game1.itemname[27] = "Monster Skins";
            Game1.itemname[28] = "Feathers";
            Game1.itemname[29] = "Money";
            Game1.text[0] = "Thank you for\nsaving us.";
            Game1.text[1] = "You saved us.\nNow you have\nto save Nebula.";
            Game1.text[3] = "You are our hero.";
            Game1.text[2] = "I know a boatman.\nHe can cross the\nsea with you.\nHe lives in\nMount Perk.";
            Game1.text[4] = "Take this map.\nWith this,\nyou can see the\nnames of the places.";
            Game1.text[5] = "You can see\ninvisible paths,\nif you use a yakub.\nBut don't use yakubs\nat the same time.\nIt may kill you";
            Game1.text[6] = "Take this red yakub.\nYou can only\nsave Rotta\nwith this.";
            Game1.text[7] = "Go to the\nTown of Perk.\nSomebody in Perk\nmay help you.";
            Game1.text[8] = "For green yakub,\nlook at the bushes.";
            Game1.text[9] = "A man sells\nblue yakub in the\nTown of Felsine.";
            Game1.text[10] = "If you want to\nsave Rotta, you\nneed red, green\nand blue yakubs...\nand a silver dagger.";
            Game1.text[11] = "If you stay in\ndesert 24 hours,\nyou will see\nmirage.";
            Game1.text[12] = "I saw\ngreen yakub in\nthe Town of Yosha.";
            Game1.text[13] = "I had a\nblue yakub, then\na monster took it\nin Plara Ruins.";
            Game1.text[14] = "If you want\nsome bones, kill\nskeletons in a\ngraveyard.";
            Game1.text[15] = "Be careful in\nSalawa Desert.\nYou can't see\nwell because\nof sun.";
            Game1.text[16] = "Monsters may\ngive you tomatoes.\nEat them and heal\nyour wounds.";
            Game1.text[17] = "White yakub is\ninvisible. You\ncan see it with\nthe special glasses\nin Purpura.";
            Game1.text[18] = "I saw purple\nyakub in\nNebula Woods.";
            Game1.text[19] = "If your house\nhas a garden,\nyou can grow\ntomatoes.";
            Game1.text[20] = "Thank you for\nsaving me,\nmy muscular hero.";
            Game1.text[21] = "You must save\nDinkleheith too.";
            Game1.text[23] = "You are our hero,\nhero of Farbelia!";
            Game1.text[22] = "Thank you.";
            Game1.text[28] = "For pink yakub,\nlook at the\nbridge in the\nTown of Felsine.";
            Game1.text[29] = "If you want to\nsave Nebula,\nyou must have\npurple, gray\nand white yakubs...\nand a silver sword.";
            Game1.text[30] = "Mirage is our\nbest friend.";
            Game1.text[31] = "White yakub is\nin a place that\ncan be\ncamouflaged easily.";
            Game1.text[24] = "Thank you for\nsaving us.";
            Game1.text[25] = "You are the hero.\nThe Chosen Hero\nfrom Rotta!";
            Game1.text[26] = "If you want to\ncross the sea,\nmy boatman friend\nmay help you.";
            Game1.text[27] = "For defeating\nLord Ailebra,\ngo to the\nPlara Ruins.";
            Game1.text[32] = "A bear killed\nmy mother\nand father\nwhen I was\na child.";
            Game1.text[33] = "I found the\ngreen yakub\nin this bushes.";
            Game1.text[34] = "I found the\npurple yakub\nbehind this\ntree.";
            Game1.text[35] = "I am making\nmystical liquid.\nOnly it can\ndefeat Ailebra,\nlord of darkness.\nBut I need\nyour help.";
            Game1.text[36] = "I need some\nblackberries.";
            Game1.text[37] = "Hmmm.\nDelicious\nblackberries.";
            Game1.text[38] = "Now I need\nbamboo.";
            Game1.text[39] = "Bamboo.\nIt is very\nrare.";
            Game1.text[40] = "Lastly I need\nGambo Stone.\nIt is black, rare,\nbright\nand triangle\nshaped.";
            Game1.text[41] = "Black, rare\nand triangle\nshaped. This\nmust be a\nGambo Stone.";
            Game1.text[42] = "I made it.\nTake this hero,\nand save\nFarbelia.";
            Game1.text[43] = "Take this\nglasses. You\ncan see white\nyakub with\nthis.";
            Game1.text[44] = "It is a\nmirage!\nMirage of\ngray yakub!";
            Game1.text[45] = "Good morning Rotta,\nmy lovely town.\n...Where are people,\nwhy is sky red?\nHey, there is a\nnote here.\n(Press Space)";
            Game1.text[46] = "I found\nan easter egg...";
        }

        public static void CreatePlaceNames()
        {
            Game1.placenames[0] = "Rotta Woods";
            Game1.placenames[1] = "Town of Rotta";
            Game1.placenames[2] = "Rotta Woods";
            Game1.placenames[3] = "Plara Ruins";
            Game1.placenames[4] = "Plara Path";
            Game1.placenames[5] = "Somewhere in Farbelia";
            Game1.placenames[6] = "Town of Yosha";
            Game1.placenames[7] = "Yosha Woods";
            Game1.placenames[8] = "Old Graveyard";
            Game1.placenames[9] = "Yosha Woods";
            Game1.placenames[10] = "Somewhere in Farbelia";
            Game1.placenames[11] = "Somewhere in Farbelia";
            Game1.placenames[12] = "Mount Perk";
            Game1.placenames[13] = "Town of Perk";
            Game1.placenames[14] = "Mount Perk";
            Game1.placenames[15] = "Felsine Bridge";
            Game1.placenames[16] = "Felsine Woods";
            Game1.placenames[17] = "Town of Felsine";
            Game1.placenames[18] = "Felsine Woods";
            Game1.placenames[19] = "Somewhere in Farbelia";
            Game1.placenames[20] = "Town of Wisen";
            Game1.placenames[21] = "Wisen Graveyard";
            Game1.placenames[22] = "Somewhere in Farbelia";
            Game1.placenames[23] = "Town of Nebula";
            Game1.placenames[24] = "Nebula Woods";
            Game1.placenames[25] = "Somewhere in Farbelia";
            Game1.placenames[26] = "Salawa Desert";
            Game1.placenames[27] = "Salawa Desert";
            Game1.placenames[28] = "Salawa Desert";
            Game1.placenames[29] = "Salawa Desert";
            Game1.placenames[30] = "Somewhere in Farbelia";
            Game1.placenames[31] = "Town of Dinkleheith";
            Game1.placenames[32] = "Dinkleheith Shore";
            Game1.placenames[33] = "Somewhere in Farbelia";
            Game1.placenames[34] = "Bridge of East";
            Game1.placenames[35] = "Town of Purpura";
            Game1.placenames[36] = "Purpura Woods";
            Game1.placenames[37] = "Mount Salwath";
        }
    }
}
