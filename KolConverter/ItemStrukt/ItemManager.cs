using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KolConverter;
using KolConverter.ItemStrukt;

namespace KolReader.ItemStrukt
{
  
    class ItemManager
    {

        private static ItemManager Manager = new ItemManager();

        private static List<Item> Items = new List<Item>();



        public static void FilterItems(BrightIdeasSoftware.ObjectListView listView1, string filter)
        { 
            List<Item> filteredItems = new List<Item>();
            filteredItems.AddRange(Items.FindAll(delegate (Item fitem) { return (fitem).FilterFits(filter); }));
            FillTree(listView1,filteredItems); 
        }

        public static void ListRunes(string filename)
        {
            Items.Clear();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    String file = sr.ReadToEnd();
                    string[] lines = file.Split('{');
                    RuneItem tempRuneItem = null;
                    foreach (string itemline in lines)
                    {
                        tempRuneItem = new RuneItem(itemline, "default");
                        if (tempRuneItem.Show())
                        {
                            Items.Add(tempRuneItem);
                        } 
                    }

                    List<RuneCounter> runelist = new List<RuneCounter>();

                    string clipresult = "";
                    foreach (Item item in Items)
                    {
                        Boolean found = false;
                        foreach (RuneCounter runeCounter in runelist)
                        {
                            if (item.Name() == runeCounter.RuneName)
                            {
                                found = true;
                                runeCounter.Cnt++;
                            }


                        }

                        if (!found)
                        {
                            runelist.Add(new RuneCounter(item.Name()));
                        }
                    } 

                    clipresult = " " + Environment.NewLine;

                    foreach (RuneCounter runeCounter in runelist)
                    {
                        clipresult = clipresult + runeCounter.Cnt + "x" + runeCounter.RuneName +
                                     Environment.NewLine;
                    }
 
                    Clipboard.SetText(clipresult);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static Boolean LoadItems(string filename )
        {
            Manager.CreateItems(filename);
            return true;
        }


        public static void LoadKeys(string filename)
        { 
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {

                    String file = sr.ReadToEnd();
                    string[] lines = file.Split('{');


                    List<Item> tmpItems = new List<Item>();
        
                      // für die kompletten Keysets brauchen wir den Header leider eh

                    string header = "";

                    if (lines.Length > 1)
                    {
                        string[] singleattri = lines[1].Split(',');
                        foreach (string attriline in singleattri)
                        {
                            if (attriline.IndexOf("header") == 1)
                            {
                                header = attriline; 
                            }
                        }

                    }

                    // alles was Key ist wird als Item gesichert 

                    KeyItem tempKeyItem = null;
                    foreach (string itemline in lines)
                    {
                        tempKeyItem = new KeyItem(itemline, header);
                        if (tempKeyItem.Show())
                        {
                            tmpItems.Add(tempKeyItem);
                        }
                    }

                    tmpItems.FindAll(delegate(Item fitem) { return ((KeyItem)fitem).IsTerror(); }).Count(); 
                     
                    if ((tmpItems.FindAll(delegate (Item fitem) { return ((KeyItem)fitem).IsTerror(); }).Count() >= 3)
                     && (tmpItems.FindAll(delegate (Item fitem) { return ((KeyItem)fitem).IsHate(); }).Count() >= 3)
                     && (tmpItems.FindAll(delegate (Item fitem) { return ((KeyItem)fitem).IsDest(); }).Count() >= 3))
                    {


                        tmpItems.Add(new KeyItem("", header));
                        tmpItems.Last().SetName("Complete Keyset");
                    }
                    Items.AddRange(tmpItems);

                }
                     
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


        }

        private void CreateItems(string filename)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                { 
                    String line = sr.ReadToEnd();
                    string[] singleStrings = line.Split('{');
                    foreach(string itemline in singleStrings)
                    {
                        Items.Add(new StdItem(itemline));
                        if (!Items.Last().Show())
                        {
                            Items.Remove(Items.Last());
                        }

                    } 
                     
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


        }

        internal static void Clear()
        {
            Items.Clear();
        }
        internal static void FillTreeUnFiltered(BrightIdeasSoftware.ObjectListView listView1)
        {
            FillTree(listView1, Items);
        }


        internal static void FillTree(BrightIdeasSoftware.ObjectListView listView1, List<Item> items)
        {
            // listView1.Clear();
            listView1.Objects = items;
            //listView1.AddObjects(Items);
            /*
            foreach (Item Item in Items)
            {
                if (Item.Show())
                {
                    listView1.AddObjects(Items);
                }
            }*/

        } 
    }
}
