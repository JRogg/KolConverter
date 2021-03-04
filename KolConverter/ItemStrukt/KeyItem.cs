using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KolReader.ItemStrukt; 
namespace KolConverter.ItemStrukt
{
    class KeyItem : KolReader.Item
    {
        public Boolean IsTerror()
        {
            return name == "Key of Terror";
        }
        public Boolean IsDest()
        {
            return name == "Key of Destruction";
        }
        public Boolean IsHate()
        {
            return name == "Key of Hate";
        }

        public new Boolean Show()
        {
            return show;
        }

        public KeyItem(string itemline, string header)
        {
            name = "no key";
            show = false;
            if (itemline.IndexOf("Key of Terror") > -1)
            {
                name = "Key of Terror"; 
                show = true;
            }
            if (itemline.IndexOf("Key of Hate") > -1)
            {
                name = "Key of Hate";
                show = true;
            }

            if (itemline.IndexOf("Key of Destruction") > -1)
            {
                name = "Key of Destruction";
                show = true;
            }

            string[] headers = header.Split(':');
            if (headers.Length == 2)
            { 
                accchar = headers[1]; 
            }
            //todo header verarbeiten
            //     this.Output = itemline;
            //     CreateAttributes(itemline);
        } 

    }
}
