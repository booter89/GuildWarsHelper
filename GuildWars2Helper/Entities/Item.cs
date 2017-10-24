using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Entities
{

    //--https://api.guildwars2.com/v2/items/--ItemIdHere--

    public class Item
    {
        //API Response
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int level { get; set; }
        public string rarity { get; set; }
        public int vendor_value { get; set; }
        public string default_skin { get; set; }
        public List<string> game_types { get; set; }
        public List<string> flags { get; set; }
        public List<object> restrictions { get; set; }
        public int id { get; set; }
        public string chat_link { get; set; }
        public string icon { get; set; }
        public Details details { get; set; }

        //Property
        //--https://api.guildwars2.com/v2/commerce/prices/--ItemIdHere-
        //public Commerce commerce { get; set; }

        //--https://api.guildwars2.com/v2/commerce/listings/--ItemIdHere--
        //public CommerceListings listings { get; set; }

    }

    public class Attribute
    {
        public string attribute { get; set; }
        public int modifier { get; set; }
    }

    public class InfixUpgrade
    {
        public List<Attribute> attributes { get; set; }
    }

    public class Details
    {
        public string type { get; set; }
        public string damage_type { get; set; }
        public int min_power { get; set; }
        public int max_power { get; set; }
        public int defense { get; set; }
        public List<object> infusion_slots { get; set; }
        public InfixUpgrade infix_upgrade { get; set; }
        public int suffix_item_id { get; set; }
        public string secondary_suffix_item_id { get; set; }
    }







}
