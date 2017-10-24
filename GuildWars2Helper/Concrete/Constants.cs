using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Concrete
{
    /// <Summary>
    /// 
    /// </Summer>
    public class Constants
    {
        
        public const int MAX_API_ITEM_COUNT = 200;

        public const string apiKey = "64D31738-C039-5C45-BF33-2BAE0C23970F996CCFB4-2139-4E41-8BF7-4E83D1AF5B70";

        public static readonly int[] item_ids =
               {27020,26860,26221,26228,31038,44978,26395,36877,36820,36894,36825,36794,36762,36851,36787,36853,36824,36761,36791,36913,36895,36905,
                36759,44980,27024,46295,46187,46148,46334,46269,46041,46347,46168,46116,46002,46321,46028,46282,46308,46129,46161,27813,27952,27958,
                27174,44982,27184,48726,25975,15356,14654,14570,15475,15272,13983,15517,14577,14451,13899,15433,13906,15314,15398,14493,14443,26408,
                47088,47086,47097,48730,48731,27017,44960,27795,28266,27478,26703,47085,19364,32262,32298,32266,32274,32334,32286,32278,32306,32310,
                32322,32270,32302,15353,14651,14567,15472,15269,13980,15514,14574,14448,13896,15430,13903,15311,15395,14490,14445,34125,34149,34129,
                34133,34137,34153,34157,34161,34165,34169,34173,34181,34185,34189,34141,34197,46220,46101,46080,46241,46206,45988,46248,46094,46066,
                45967,46234,45981,46213,46227,46073,46087,47084,27955,19367,19365,26148,15354,14652,14568,15473,15270,13981,15515,14575,14449,13897,
                15431,13904,15312,15396,14491,14441,44977,26405,44991,27171,31040,48724,44985,47096,44967,48723,27485,27179,27338,47510,47514,47522,
                47530,47534,47538,47542,47566,47546,47518,47554,47562,47570,47578,47505,47182,47206,47186,47190,47194,47210,47214,47218,47242,47222,
                47226,47198,47238,47246,47254,46216,46097,46076,46237,46202,45984,46244,46090,46062,45963,46230,45977,46209,46223,46069,46083,26706,
                47093,31037,25988,28275,27808,27328,28262,27791,28272,27802,26400,27495,44964,44974,47091,48725,28269,19360,27164,25979,19356,28277,
                26708,38335,38380,38398,38345,38350,38410,38340,38374,38386,38422,38319,38416,38321,38330,38404,38368,47083,48728,26557,26544,44971,
                47090,48737,48738,48727,26231,26869,26380,48736,27498,27014,27644,25964,26537,31105,26139,25985,27336,44962,15358,14656,14572,15477,
                15274,13985,15519,14579,14453,13901,15435,13908,15316,15400,14495,14446,25958,44961,26874,44986,26541,31036,27325,25967,32326,32290,
                32294,32318,44973,44969,46217,46098,46077,46238,46203,45985,46245,46091,45964,46231,45978,46210,46224,46070,46084,27638,26150,26697,
                25971,44988,27482,27007,48729,44992,26135,25992,31085,31100,31093,31108,31092,31095,31099,31087,27321,44968,26384,19357,25969,44987,
                31035,19366,44963,46215,46096,46075,46236,46201,45983,46243,46089,46061,45962,46229,45976,46208,46222,46068,46082,15357,14655,14571,
                15476,15273,13984,15518,14578,14452,13900,15434,13907,15315,15399,14494,14444,25961,31034,27649,26237,47092,26693,31066,27965,44972,
                47089,41540,41504,41516,41532,41528,41480,41536,41500,41508,41488,41524,41484,41552,41544,41520,41496,25990,46219,46100,46079,46240,
                46205,45987,46247,46093,46065,45966,46233,45980,46212,46226,46072,46086,48733,25039,25079,25559,25319,25519,25399,25239,25199,25679,
                25279,25359,24999,25439,24959,25119,25599,46221,46102,46081,46242,46207,45989,46249,46095,46067,45968,46235,45982,46214,46228,46074,
                46088,19363,26552,26561,44975,27502,26854,27334,48732,46218,46099,46078,46239,46204,45986,46246,46092,46064,45965,46232,45979,46211,
                46225,46071,46085,44989,26145,27963,44979,19354,27187,47082,31106,27647,47099,27634,27641,26850,31055,29166,27798,19361,44981,26389,
                26234,44999,26152,14922,14923,14935,14929,14934,14931,14927,14926,14938,14928,14930,14921,14932,14920,14924,14936,15359,14657,15478,
                15275,13986,15520,14580,14454,13902,15436,13909,15317,15401,14496,14447,26700,27948,19359,26857,26239,19355,48734,27022,48735,19358};

        public const string JunkColor = "LightGray";
        public const string BasicColor = "Black";
        public const string FineColor = "#62A4DA";
        public const string MasterworkColor = "#1a9306";
        public const string RareColor = "#fcd00b";
        public const string ExoticColor = "#ffa405";
        public const string AscendedColor = "#Fb3e8d";
        public const string LegendaryColor = "#4C139D";

        //Color
        public const string ElementalistColor = "#b94545";
        public const string MesmerColor = "#8b178b";
        public const string NecromancerColor = "#2e735c";

        public const string RangerColor = "#73a22e";
        public const string EngineerColor = "#a27345";
        public const string ThiefColor = "#8b5c5c";

        public const string WarriorColor = "#d08b17";
        public const string RevenantColor = "#370d0d";
        public const string GuardianColor = "#45a2d0";

        //Small PNG
        public const string ElementalistSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\elementalist-small.png";
        public const string MesmerSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\mesmer-small.png";
        public const string NecromancerSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\necromancer-small.png";

        public const string RangerSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\ranger-small.png";
        public const string EngineerSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\engineer-small.png";
        public const string ThiefSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\thief-small.png";

        public const string WarriorSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\warrior-small.png";
        public const string RevenantSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\revenant-small.png";
        public const string GuardianSmallPNG = @"C:\Users\kttruedson\Desktop\GuildWars2Helper\GuildWars2Helper\Resources\Images\guardian-small.png";

        //Mouse Events
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
    }
}
