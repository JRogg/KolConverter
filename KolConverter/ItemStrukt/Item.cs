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
    abstract class Item
    {
        protected List<Attribut> Attributes = new List<Attribut>();
        protected string Output;
        protected string ItemTypeDesc = "hide";
        protected List<string> searchtags = new List<string>();

        protected Boolean isSet;
        protected string name;
        protected string itemtype;
        protected string sockets; 
        protected string ethereal;
        protected string accchar;
        protected Boolean show;

        public Boolean FilterFits(string filter)
        {
            Boolean stringfits;
            Boolean result = true;
            string[] splitfilter = filter.Split(',');

            foreach (string singlefilter in splitfilter)
            {
                stringfits = false;
                foreach (Attribut attri in Attributes)
                {
                    stringfits = stringfits ||
                                 (attri.Text().IndexOf(singlefilter.Trim(), StringComparison.OrdinalIgnoreCase) > -1);
                }

                result = result && stringfits;
            } 
            return result;
        }


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