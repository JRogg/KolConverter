using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolReader.ItemStrukt; 
namespace KolConverter.ItemStrukt
{
    class RuneItem : KolConverter.Item
    {
        private new Boolean show;
        private readonly string[] RuneList = new string[] { "Vex", "Ohm", "Lo", "Sur", "Ber", "Jah", "Cham", "Zod" };

        public RuneItem(string itemline, string rune)
        {
            ReadRunes(itemline, new String[] { "default" });

        }
        public RuneItem(string itemline, string[] rune)
        {
            ReadRunes(itemline, rune);
        }

        public new Boolean Show()
        {
            return show;
        }

        private void ReadRunes(string itemline, string[] rune)
        {
            this.Output = itemline;
            string[] rList;
         //   CreateAttributes(itemline);
            if (rune[0] == "default")
            {
                rList = RuneList;
            }
            else
            {
                rList = rune;
            }

            show = false;
            foreach (string singlerune in rList)
            {
                if (itemline.IndexOf(singlerune + " Rune") > -1)
                {
                    name = singlerune;
                    show = true;
                }
            }
        }



    }
}
