using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Entities
{
    public class Account
    {
        public List<Character> Characters;
        public string APIKey;
        public List<Item> Items;

        public Account()
        {
            this.Characters = new List<Character>();
            this.APIKey = Concrete.Constants.apiKey;
            this.Items = new List<Item>();
        }

        public void getAccountCharacters()
        {
            var url = @"https://api.guildwars2.com/v2/characters?page=0";

            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers.Add("Content-Type", "text");
                webClient.Headers[System.Net.HttpRequestHeader.Authorization] = "Bearer " + this.APIKey;
                var response = webClient.DownloadString(url);

                this.Characters = JsonConvert.DeserializeObject<List<Character>>(response);
            }

            foreach (Character c in this.Characters)
            {
                c.getCreationInfo();
                c.getHoursPlayed();

                switch (c.profession)
                {
                    case "Elementalist":
                        c.color = Concrete.Constants.ElementalistColor;
                        c.smallPNG = Concrete.Constants.ElementalistSmallPNG;
                        break;
                    case "Mesmer":
                        c.color = Concrete.Constants.MesmerColor;
                        c.smallPNG = Concrete.Constants.MesmerSmallPNG;
                        break;
                    case "Necromancer":
                        c.color = Concrete.Constants.NecromancerColor;
                        c.smallPNG = Concrete.Constants.NecromancerSmallPNG;
                        break;
                    case "Thief":
                        c.color = Concrete.Constants.ThiefColor;
                        c.smallPNG = Concrete.Constants.ThiefSmallPNG;
                        break;
                    case "Ranger":
                        c.color = Concrete.Constants.RangerColor;
                        c.smallPNG = Concrete.Constants.RangerSmallPNG;
                        break;
                    case "Engineer":
                        c.color = Concrete.Constants.EngineerColor;
                        c.smallPNG = Concrete.Constants.EngineerSmallPNG;
                        break;
                    case "Revenant":
                        c.color = Concrete.Constants.RevenantColor;
                        c.smallPNG = Concrete.Constants.RevenantSmallPNG;
                        break;
                    case "Warrior":
                        c.color = Concrete.Constants.WarriorColor;
                        c.smallPNG = Concrete.Constants.WarriorSmallPNG;
                        break;
                    case "Guardian":
                        c.color = Concrete.Constants.GuardianColor;
                        c.smallPNG = Concrete.Constants.GuardianSmallPNG;
                        break;
                    default:
                        c.color = "#000000";
                        break;
                }
                
            }
        }

        public void getAccountItems()
        {
            List<string> ItemIds = new List<string>();

            foreach (Character c in Characters)
            {
                foreach (Bag b in c.bags)
                {
                    if (b != null)
                    {
                        if (!ItemIds.Contains(b.id.ToString()))
                        {
                            ItemIds.Add(b.id.ToString());
                        }
                    }

                    foreach (Inventory item in b.inventory)
                    {
                        if (item != null)
                        {
                            if (!ItemIds.Contains(item.id.ToString()))
                            {
                                ItemIds.Add(item.id.ToString());
                            }
                            
                        }
                    }
                }
            }

            int itemCount = ItemIds.Count();
            int skipIndex = 0;
            int takeIndex = 0;

            if (itemCount < 200)
            {
                takeIndex = Items.Count();
            }
            else
            {
                takeIndex = 200;
            }

            string JsonUrl = @"https://api.guildwars2.com/v2/items?ids=";

            using (var webClient = new System.Net.WebClient())
            {
                for (int i = 0; i < itemCount; )
                {
                    string idQuery = String.Join(",", ItemIds.Skip(skipIndex).Take(takeIndex));      
                                    
                    var webResponse = webClient.DownloadString(String.Format("{0}{1}", JsonUrl, idQuery));

                    var idResponse = JsonConvert.DeserializeObject<List<Item>>(webResponse);

                    foreach (Item item in idResponse)
                    {
                        this.Items.Add(item);
                    }

                    i += 200;

                    if ((i + 200) > itemCount)
                    {
                        takeIndex = itemCount - i;
                        skipIndex += 200;
                    }
                    else
                    {
                        takeIndex = 200;
                        skipIndex += 200;
                    }
                }     
            }

            //for (int i = 0; i < itemCount;)
            //{
            //    string idQuery = String.Join(",", ItemIds.Skip(skipIndex).Take(takeIndex));

            //    using (var webClient = new System.Net.WebClient())
            //    {
            //        var webResponse = webClient.DownloadString(String.Format("{0}{1}", JsonUrl, idQuery));

            //        var idResponse = JsonConvert.DeserializeObject<List<Item>>(webResponse);

            //        foreach (Item item in idResponse)
            //        {
            //            this.Items.Add(item);
            //        }
            //    }

            //    i += 200;

            //    if ((i + 200) > itemCount)
            //    {
            //        takeIndex = itemCount - i;
            //        skipIndex += 200;
            //    }
            //    else
            //    {
            //        takeIndex = 200;
            //        skipIndex += 200;
            //    }


            //}
        }

        public void pairItems()
        {
            foreach (Character c in Characters)
            {
                int usedInventorySlots = 0;
                int totalInventorySlots = 0;

                c.inventoryItems = new List<Tuple<Inventory, Item>>();
                c.bagItems = new List<Tuple<Bag, Item>>();

                foreach (Bag bag in c.bags)
                {
                    totalInventorySlots += bag.size;

                    Tuple<Bag, Item> BagItem;

                    if (bag != null)
                    {
                        List<Item> result = Items.Where(x => x.id == bag.id).Select(x => x).ToList();

                        BagItem = new Tuple<Bag, Item>(bag, result.First());
                    }
                    else
                    {
                        Item i = new Item();

                        BagItem = new Tuple<Bag, Item>(bag, i);
                    }

                    c.bagItems.Add(BagItem);

                    foreach (Inventory item in bag.inventory)
                    {
                        Tuple<Inventory, Item> InventoryItem;

                        if (item != null)
                        {     
                            List<Item> result = Items.Where(x => x.id == item.id).Select(x => x).ToList();

                            if (result.Count() != 0)
                            {
                                InventoryItem = new Tuple<Inventory, Item>(item, result.First());
                            }
                            else
                            {
                                Item i = new Item();

                                i.rarity = "Junk";

                                i.icon = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\Deleted_Item.png";

                                InventoryItem = new Tuple<Inventory, Item>(item, i);
                            }

                            usedInventorySlots++;
                        }
                        else
                        {
                            Item i = new Item();

                            i.rarity = "Junk";

                            i.icon = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\BlackBox.png";

                            InventoryItem = new Tuple<Inventory, Item>(item, i);
                        }

                        c.inventoryItems.Add(InventoryItem);

                    }
                }

                c.totalInventorySlots = totalInventorySlots;
                c.usedInventorySlots = usedInventorySlots;
            }

        }
            
    }
}
