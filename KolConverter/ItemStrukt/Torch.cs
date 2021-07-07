using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolConverter.ItemStrukt;

namespace KolConverter.ItemStrukt
{
    class Torch : KolConverter.Item
    {
        public Torch(string itemline)
        {
            if (itemline.IndexOf("xffc3+3") == -1)
            {
                Attributes.Add(new Attribut("error reading torch", 0));
            }
            else
            {
                string header = "";
                string[] singleattri = itemline.Split(',');
                foreach (string attriline in singleattri)
                {
                    if (attriline.IndexOf("header") == 1)
                    {
                        string[] headers = attriline.Split(':');
                        if (headers.Length == 2)
                        {
                            header = headers[1];
                        }
                    }
                }



                string sub = itemline.Substring(itemline.IndexOf("xffc3+3") + 11);
                string classname = sub.Substring(0, sub.IndexOf(" "));
                sub = sub.Substring(sub.IndexOf("xffc3") + 6);
                string stats = sub.Substring(0, sub.IndexOf(" "));
                sub = sub.Substring(sub.IndexOf("xffc3") + 22);

                string res = sub.Substring(0, sub.IndexOf("\\"));

                string allstats = classname.PadRight(15, ' ') + " " + stats + "/" + res;
                allstats = allstats.PadRight(30, ' ');
                allstats = allstats + header.Replace("\"", ""); ;
                Attributes.Add(new Attribut(allstats, 0));
                int sortindex = -1;

                
                    
                    
                    
                    
                    
                    

                switch (classname) {  
                    case "Amazon":
                    sortindex = 0;
                     break;
                    case "Assassin":
                        sortindex = 1;
                        break;
                    case "Barbarian":
                        sortindex = 2;
                        break;
                    case "Druid":
                        sortindex = 3;
                        break;
                    case "Necromancer":
                        sortindex = 4;
                        break;
                    case "Paladin":
                        sortindex = 5;
                        break;
                    case "Sorceress":
                        sortindex = 6;
                        break; 

                }
                Attributes.Add(new Attribut(sortindex.ToString(), 1));




            }
        }
    }
}
