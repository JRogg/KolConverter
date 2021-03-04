using KolConverter.Data;
using KolReader.ItemStrukt;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks; 

namespace KolReader
{
    class Item
    {
        private List<Attribut> Attributes = new List<Attribut>();
        private string Output;
        private string ItemTypeDesc = "hide";
        private List<string> searchtags = new List<string>();

        private Boolean isSet;
        private string name;
        private string itemtype;
        private string sockets;
        private string edar;
        private string ethereal;
        private string accchar;
        public Boolean show;
        private readonly string[] RuneList = new string[] {"Vex", "Ohm", "Lo", "Sur", "Ber", "Jah", "Cham", "Zod"};

        public void SetIsSet(Boolean isSet)
        {
            this.isSet = isSet;
        }

        public Boolean IsSet()
        {
            return isSet;
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public  Item( )
        { 

        }

        public Item(string itemline, string rune)
        {
            ReadRunes(itemline, new String[] {"default"});

        }


        public Item(string itemline, string[] rune)
        {
            ReadRunes(itemline,rune);
        }

        private void ReadRunes(string itemline, string[] rune)
        {
            this.Output = itemline;
            string[] rList;
            CreateAttributes(itemline);
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


        private void CreateAttributes(string itemline)
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

                        Attributes.Add(new Attribut(attriline[attriline.IndexOf("Socketed (")+10]  +  " Sockets",3));

                        sockets = attriline[attriline.IndexOf("Socketed (") + 10] + " Sockets";
                    }





                    if (attriline.IndexOf("header") == 1)
                    {
                        string[] header = attriline.Split(':');
                        if (header.Length == 2)
                        {
                            Attributes.Add(new Attribut(header[1],6));
                            accchar = header[1];

                        }

                    }


                


            }


        }
        public Boolean Show()
        {   
            return ItemTypeDesc != "hide";
        }
        public List<Attribut> GetAttributs()
        {
            return Attributes;
        }

        public void AddAttribut()
        {

        }

        public void SetTags()
        {

        }

        public Boolean HasTag(string tag)
        {
            foreach (Attribut attribut in Attributes)
            {
                if (attribut.HasTag(tag))
                {
                    return true;
                }
            }
            return false;
        }

        public string Name()
        {
            return name;
        }
        public string Itemtype()
        {
            return itemtype;
        }

        public string Sockets()
        {
            return sockets;
        }

        public string EDAR()
        {
            return edar;
        }

        public string Ethereal()
        {
            return ethereal;
        }

        public string AccChar()
        {
            return accchar;
        }



        


        public string GetAttribut(int index)
        {
            foreach (Attribut Attribut in Attributes)
            {
                if (Attribut.Index() == index)
                {
                    return Attribut.Text();
                }
            }

            return "";
        }

        internal string GetDescription()
        {
            string desc = "";
            foreach (Attribut Attribut in Attributes)
            {
                desc += Attribut.Text() + " ";
            }
             

            return desc;
        }
    }
}