using GuildWars2Helper.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Entities
{
    //--https://api.guildwars2.com/v2/character/

    public class Character
    {
        //API Response
        public string name { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public List<object> flags { get; set; }
        public string profession { get; set; }
        public int level { get; set; }
        public string guild { get; set; }
        public int age { get; set; }
        public DateTime created { get; set; }
        public int deaths { get; set; }
        public List<Crafting> crafting { get; set; }
        public int title { get; set; }
        public List<string> backstory { get; set; }
        public List<object> wvw_abilities { get; set; }
        public Specializations specializations { get; set; }
        public Skills skills { get; set; }
        public List<Equipment> equipment { get; set; }
        public List<object> recipes { get; set; }
        public EquipmentPvp equipment_pvp { get; set; }
        public List<object> training { get; set; }
        public List<Bag> bags { get; set; }

        //Property
        public List<Tuple<Inventory, Item>> inventoryItems { get; set; }
        public List<Tuple<Bag, Item>> bagItems { get; set; }
        public List<Item> items { get; set; }
        public string color { get; set; }
        public string smallPNG { get; set; }
        public string CreationDate { get; set; }
        public string DaysTillBirthday { get; set; }
        public string totalAge { get; set; }
        public int hoursPlayed { get; set; }
        public int usedInventorySlots { get; set; }
        public int totalInventorySlots { get; set; }

        public void getCreationInfo()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime today = DateTime.Now;

            TimeSpan Age = today.Subtract(created);

            int years = (zeroTime + Age).Year - 1;
            int months = (zeroTime + Age).Month - 1;

            totalAge = years.ToString();

            if (years == 1)
            {
                totalAge += " year";
            }
            else
            {
                totalAge += " years";
            }            

            if (months != 0)
            {                
                totalAge += " and " + months.ToString();

                if (months == 1)
                {
                    totalAge += " month";
                }
                else
                {
                    totalAge += " months";
                }                
            }

            totalAge += " old";
        }

        public void getHoursPlayed()
        {
            this.hoursPlayed = (this.age / 3600);
        }
    }
    
    public class Crafting
    {
        public string discipline { get; set; }
        public int rating { get; set; }
        public bool active { get; set; }
    }
    public class Pve
    {
        public int id { get; set; }
        public List<object> traits { get; set; }
    }

    public class Pvp
    {
        public int id { get; set; }
        public List<int> traits { get; set; }
    }

    public class Wvw
    {
        public int id { get; set; }
        public List<int> traits { get; set; }
    }

    public class Specializations
    {
        public List<Pve> pve { get; set; }
        public List<Pvp> pvp { get; set; }
        public List<Wvw> wvw { get; set; }
    }

    public class Pets
    {
        public List<int> terrestrial { get; set; }
        public List<object> aquatic { get; set; }
    }

    public class Pve2
    {
        public int heal { get; set; }
        public List<object> utilities { get; set; }
        public int? elite { get; set; }
        public Pets pets { get; set; }
        public List<string> legends { get; set; }
    }

    public class Pets2
    {
        public List<object> terrestrial { get; set; }
        public List<object> aquatic { get; set; }
    }

    public class Pvp2
    {
        public int heal { get; set; }
        public List<int?> utilities { get; set; }
        public int? elite { get; set; }
        public Pets2 pets { get; set; }
        public List<string> legends { get; set; }
    }

    public class Pets3
    {
        public List<int> terrestrial { get; set; }
        public List<object> aquatic { get; set; }
    }

    public class Wvw2
    {
        public int heal { get; set; }
        public List<int?> utilities { get; set; }
        public int? elite { get; set; }
        public Pets3 pets { get; set; }
        public List<string> legends { get; set; }
    }

    public class Skills
    {
        public Pve2 pve { get; set; }
        public Pvp2 pvp { get; set; }
        public Wvw2 wvw { get; set; }
    }

    public class Attributes
    {
        public int Power { get; set; }
        public int Precision { get; set; }
        public int CritDamage { get; set; }
        public int? ConditionDamage { get; set; }
        public int? ConditionDuration { get; set; }
    }

    public class Stats
    {
        public int id { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Equipment
    {
        public int id { get; set; }
        public string slot { get; set; }
        public string binding { get; set; }
        public string bound_to { get; set; }
        public List<int?> infusions { get; set; }
        public int? skin { get; set; }
        public Stats stats { get; set; }
        public List<int?> upgrades { get; set; }
        public List<object> dyes { get; set; }
        public int? charges { get; set; }
    }

    public class EquipmentPvp
    {
        public int? amulet { get; set; }
        public int? rune { get; set; }
        public List<object> sigils { get; set; }
    }

    public class Attributes2
    {
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int CritDamage { get; set; }
        public int Healing { get; set; }
        public int? Precision { get; set; }
        public int? Vitality { get; set; }
    }

    public class Stats2
    {
        public int id { get; set; }
        public Attributes2 attributes { get; set; }
    }

    public class Inventory
    {
        public int id { get; set; }
        public int count { get; set; }
        public string binding { get; set; }
        public string bound_to { get; set; }
        public List<int?> upgrades { get; set; }
        public int? charges { get; set; }
        public int? skin { get; set; }
        public List<int?> infusions { get; set; }
        public Stats2 stats { get; set; }
        public List<int?> dyes { get; set; }
    }

    public class Bag
    {
        public int id { get; set; }
        public int size { get; set; }
        public List<Inventory> inventory { get; set; }
    }
}
