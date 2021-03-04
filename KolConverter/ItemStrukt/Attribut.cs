using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolReader.ItemStrukt
{
    class Attribut
    {
        private int index;
        private string Tag;
        public Attribut(string rawtag, int index)
        {
            Tag = rawtag;
            this.index = index;
        }



        public string Text()
        {
            return Tag;
        }

        public int Index()
        {
            return index;
        }


        public Boolean HasTag(string tag)
        {
            return false;
        }

    }
}
