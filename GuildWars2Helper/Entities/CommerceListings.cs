using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Entities
{
    //--https://api.guildwars2.com/v2/commerce/listings/--ItemIdHere--

    //API Response
    public class CommerceListings
    {
        public int id { get; set; }
        public List<Buy> buys { get; set; }
        public List<Sell> sells { get; set; }
    }

    public class Buy
    {
        public int listings { get; set; }
        public int unit_price { get; set; }
        public int quantity { get; set; }
    }

    public class Sell
    {
        public int listings { get; set; }
        public int unit_price { get; set; }
        public int quantity { get; set; }
    }
}
