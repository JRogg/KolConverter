using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KolConverter.Data
{
    class ItemType
    {
        public static string GetItemType(string attriline)
        {
            if ((attriline.IndexOf("Quilted Armor") > -1) ||
                (attriline.IndexOf("Leather Armor") > -1) ||
                (attriline.IndexOf("Hard Leather Armor") > -1) ||
                (attriline.IndexOf("Studded Leather Armor") > -1) ||
                (attriline.IndexOf("Ring Mail") > -1) ||
                (attriline.IndexOf("Scale Mail") > -1) ||
                (attriline.IndexOf("Breast Plate") > -1) ||
                (attriline.IndexOf("Chain Mail") > -1) ||
                (attriline.IndexOf("Splint Mail") > -1) ||
                (attriline.IndexOf("Light Plate") > -1) ||
                (attriline.IndexOf("Field Plate") > -1) ||
                (attriline.IndexOf("Plate Mail") > -1) ||
                (attriline.IndexOf("Gothic Plate") > -1) ||
                (attriline.IndexOf("Full Plate") > -1) ||
                (attriline.IndexOf("Ancient Armor") > -1) ||
                (attriline.IndexOf("Ghost Armor") > -1) ||
                (attriline.IndexOf("Serpentskin Armor") > -1) ||
                (attriline.IndexOf("Demonhide Armor") > -1) ||
                (attriline.IndexOf("Trellised Armor") > -1) ||
                (attriline.IndexOf("Linked Mail") > -1) ||
                (attriline.IndexOf("Tigulated Mail") > -1) ||
                (attriline.IndexOf("Cuirass") > -1) ||
                (attriline.IndexOf("Mesh Armor") > -1) ||
                (attriline.IndexOf("Russet Armor") > -1) ||
                (attriline.IndexOf("Mage Plate") > -1) ||
                (attriline.IndexOf("Templar Coat") > -1) ||
                (attriline.IndexOf("Sharktooth Armor") > -1) ||
                (attriline.IndexOf("Embossed Plate") > -1) ||
                (attriline.IndexOf("Chaos Armor") > -1) ||
                (attriline.IndexOf("Ornate Armor") > -1) ||
                (attriline.IndexOf("Dusk Shroud") > -1) ||
                (attriline.IndexOf("Wyrmhide") > -1) ||
                (attriline.IndexOf("Scarab Husk") > -1) ||
                (attriline.IndexOf("Wire Fleece") > -1) ||
                (attriline.IndexOf("Diamond Mail") > -1) ||
                (attriline.IndexOf("Loricated Mail") > -1) ||
                (attriline.IndexOf("Great Hauberk") > -1) ||
                (attriline.IndexOf("Boneweave") > -1) ||
                (attriline.IndexOf("Balrog Skin") > -1) ||
                (attriline.IndexOf("Archon Plate") > -1) ||
                (attriline.IndexOf("Hellforge Plate") > -1) ||
                (attriline.IndexOf("Kraken Shell") > -1) ||
                (attriline.IndexOf("Lacquered Plate") > -1) ||
                (attriline.IndexOf("Shadow Plate") > -1) ||
                (attriline.IndexOf("Sacred Armor") > - 1))
            {
                return "Armor";
            }

            if ( (attriline.IndexOf("Sash") > -1) ||
                (attriline.IndexOf("Light Belt") > -1) ||
                (attriline.IndexOf("Belt") > -1) ||
                (attriline.IndexOf("Heavy Belt") > -1) ||
                (attriline.IndexOf("Plate Belt") > -1) ||
                (attriline.IndexOf("Demonhide Sash") > -1) ||
                (attriline.IndexOf("Sharkskin Belt") > -1) ||
                (attriline.IndexOf("Mesh Belt") > -1) ||
                (attriline.IndexOf("Battle Belt") > -1) ||
                (attriline.IndexOf("War Belt") > -1) ||
                (attriline.IndexOf("Spiderweb Sash") > -1) ||
                (attriline.IndexOf("Vampirefang Belt") > -1) ||
                (attriline.IndexOf("Mithril Coil") > -1) ||
                (attriline.IndexOf("Troll Belt") > -1) ||
                (attriline.IndexOf("Colossus Girdle") > -1))
            {
                return "Belt";
            }

            if (attriline.IndexOf("Boots") > -1)
            {
                return "Boots";
            }


            if ((attriline.IndexOf("Cap") > -1) ||
                (attriline.IndexOf("Skull Cap") > -1) ||
                (attriline.IndexOf("Helm") > -1) ||
                (attriline.IndexOf("Full Helm") > -1) ||
                (attriline.IndexOf("Great Helm") > -1) ||
                (attriline.IndexOf("Mask") > -1) ||
                (attriline.IndexOf("Crown") > -1) ||
                (attriline.IndexOf("Bone Helm") > -1) ||
                (attriline.IndexOf("War Hat") > -1) ||
                (attriline.IndexOf("Sallet") > -1) ||
                (attriline.IndexOf("Casque") > -1) ||
                (attriline.IndexOf("Basinet") > -1) ||
                (attriline.IndexOf("Winged Helm") > -1) ||
                (attriline.IndexOf("Death Mask") > -1) ||
                (attriline.IndexOf("Grand Crown") > -1) ||
                (attriline.IndexOf("Grim Helm") > -1) ||
                (attriline.IndexOf("Shako") > -1) ||
                (attriline.IndexOf("Hydra Skull") > -1) ||
                (attriline.IndexOf("Armet") > -1) ||
                (attriline.IndexOf("Giant Conch") > -1) ||
                (attriline.IndexOf("Spired Helm") > -1) ||
                (attriline.IndexOf("Demonhead") > -1) ||
                (attriline.IndexOf("Corona") > -1) ||
                (attriline.IndexOf("Bone Visage") > -1))
            {
                return "Helm";
            }

            if ((attriline.IndexOf("Wolf Head") > -1) ||
                (attriline.IndexOf("Hawk Helm") > -1) ||
                (attriline.IndexOf("Antlers") > -1) ||
                (attriline.IndexOf("Falcon Mask") > -1) ||
                (attriline.IndexOf("Spirit Mask") > -1) ||
                (attriline.IndexOf("Alpha Helm") > -1) ||
                (attriline.IndexOf("Griffon Headress") > -1) ||
                (attriline.IndexOf("Hunter's Guise") > -1) ||
                (attriline.IndexOf("Sacred Feathers") > -1) ||
                (attriline.IndexOf("Totemic Mask") > -1) ||
                (attriline.IndexOf("Blood Spirit") > -1) ||
                (attriline.IndexOf("Sun Spirit") > -1) ||
                (attriline.IndexOf("Earth Spirit") > -1) ||
                (attriline.IndexOf("Sky Spirit") > -1) ||
                (attriline.IndexOf("Dream Spirit") > -1) )
            {
                return "Helm Druid Antlers";
            }

            if ((attriline.IndexOf("Jawbone Cap") > -1) ||
                (attriline.IndexOf("Fanged Helm") > -1) ||
                (attriline.IndexOf("Horned Helm") > -1) ||
                (attriline.IndexOf("Assault Helmet") > -1) ||
                (attriline.IndexOf("Avenger Guard") > -1) ||
                (attriline.IndexOf("Jawbone Visor") > -1) ||
                (attriline.IndexOf("Lion Helm") > -1) ||
                (attriline.IndexOf("Rage Mask") > -1) ||
                (attriline.IndexOf("Savage Helmet") > -1) ||
                (attriline.IndexOf("Slayer Guard") > -1) ||
                (attriline.IndexOf("Carnage Helm") > -1) ||
                (attriline.IndexOf("Fury Visor") > -1) ||
                (attriline.IndexOf("Destroyer Helm") > -1) ||
                (attriline.IndexOf("Conqueror Crown") > -1) ||
                (attriline.IndexOf("Guardian Crown") > -1))
            {
                return "Helm Barbar";
            }

            if ((attriline.IndexOf("Buckler") > -1) ||
                (attriline.IndexOf("Small Shield") > -1) ||
                (attriline.IndexOf("Large Shield") > -1) ||
                (attriline.IndexOf("Kite Shield") > -1) ||
                (attriline.IndexOf("Spiked Shield") > -1) ||
                (attriline.IndexOf("Tower Shield") > -1) ||
                (attriline.IndexOf("Bone Shield") > -1) ||
                (attriline.IndexOf("Gothic Shield") > -1) ||
                (attriline.IndexOf("Defender") > -1) ||
                (attriline.IndexOf("Round Shield") > -1) ||
                (attriline.IndexOf("Scutum") > -1) ||
                (attriline.IndexOf("Barbed Shield") > -1) ||
                (attriline.IndexOf("Dragon Shield") > -1) ||
                (attriline.IndexOf("Grim Shield") > -1) ||
                (attriline.IndexOf("Pavise") > -1) ||
                (attriline.IndexOf("Ancient Shield") > -1) ||
                (attriline.IndexOf("Heater") > -1) ||
                (attriline.IndexOf("Luna") > -1) ||
                (attriline.IndexOf("Hyperion") > -1) ||
                (attriline.IndexOf("Monarch") > -1) ||
                (attriline.IndexOf("Blade Barrier") > -1) ||
                (attriline.IndexOf("Aegis") > -1) ||
                (attriline.IndexOf("Troll Nest") > -1) ||
                (attriline.IndexOf("Ward") > -1)) 
            {
                return "Shield";
            }




           if ((attriline.IndexOf("Targe") > -1) ||
                (attriline.IndexOf("Rondache") > -1) ||
                (attriline.IndexOf("Heraldic Shield") > -1) ||
                (attriline.IndexOf("Aerin Shield") > -1) ||
                (attriline.IndexOf("Crown Shield") > -1) ||
                (attriline.IndexOf("Akaran Targe") > -1) ||
                (attriline.IndexOf("Akaran Rondache") > -1) ||
                (attriline.IndexOf("Protector Shield") > -1) ||
                (attriline.IndexOf("Guilded Shield") > -1) ||
                (attriline.IndexOf("Royal Shield") > -1) ||
                (attriline.IndexOf("Sacred Targe") > -1) ||
                (attriline.IndexOf("Sacred Rondache") > -1) ||
                (attriline.IndexOf("Kurast Shield") > -1) ||
                (attriline.IndexOf("Zakarum Shield") > -1) ||
                (attriline.IndexOf("Vortex Shield") > -1))
            {
                return "Shield Pally";
            }

            if (attriline.IndexOf("Ring\"") > -1)
            {
                return "Ring";
            }
            if (attriline.IndexOf("Amulet") > -1)
            {
                return "Amulet";
            }
            if (attriline.IndexOf("Charm") > -1)
            {
                return "Charm";
            }



            return "hide";

    }

        internal static string GetisWeapon(string attriline)
        {
            if (attriline.IndexOf("Hand Damage:") > -1)
            {
                return "Weapon";
            }

            return "hide";
        }
    }
}
