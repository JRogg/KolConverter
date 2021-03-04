using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolConverter.Data;
using KolReader.ItemStrukt;
namespace KolConverter.ItemStrukt
{
    class StdItem : KolReader.Item
    {
        public StdItem (string itemline)
        {
           this.Output = itemline;
           CreateAttributes(itemline);
        }

        protected void CreateAttributes(string itemline)
        {
            string[] singleStrings = itemline.Split(',');

            string itemtype = "hide";
            // müssen leider erst die desc durchgehen obs ne waffe ist
            foreach (string attriline in singleStrings)
            {
                if (attriline.IndexOf("description") > -1)
                {
                    itemtype = ItemType.GetisWeapon(attriline);
                }
            }


            foreach (string attriline in singleStrings)
            {
                // image und itemcolor sind uns egal

                // index: 1 name 2 type 3 socks 4 ed/ar 5 eth 6 acc/char
                if ((attriline.IndexOf("itemColor") > -1) || (attriline.IndexOf("image") > -1))
                {

                }
                else
                {
                    // gems etc wollen wir nicht anzeigen dort
                    if (attriline.IndexOf("title") == 1)
                    {
                        if (itemtype == "hide")
                        {
                            itemtype = ItemType.GetItemType(attriline);
                        }

                        if (itemtype != "hide")
                        {
                            ItemTypeDesc = itemtype;
                            Attributes.Add(new Attribut(attriline.Split(':')[1], 1));
                            name = attriline.Split(':')[1];
                            Attributes.Add(new Attribut(itemtype, 2));
                            this.itemtype = itemtype;
                        }


                    }

                    if (attriline.IndexOf("Ethereal") >= 0)
                    {
                        Attributes.Add(new Attribut("Ethereal", 5));
                        searchtags.Add("Ethereal");
                        ethereal = "Ethereal";
                    }
                    else
                    {
                        if (ethereal != "Ethereal")
                        {

                            ethereal = "Non-Ethereal";
                        }
                    }
                }

                if (attriline.IndexOf("Socketed (") >= 0)
                {

                    Attributes.Add(new Attribut(attriline[attriline.IndexOf("Socketed (") + 10] + " Sockets", 3));

                    sockets = attriline[attriline.IndexOf("Socketed (") + 10] + " Sockets";
                }





                if (attriline.IndexOf("header") == 1)
                {
                    string[] header = attriline.Split(':');
                    if (header.Length == 2)
                    {
                        Attributes.Add(new Attribut(header[1], 6));
                        accchar = header[1];

                    }

                }





            }


        }
    }

}
