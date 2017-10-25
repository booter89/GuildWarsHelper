using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2Helper.Routines
{
    public class Automation
    {
        public static void Test()
        {
            int num = 0;

            Process p = Process.GetProcessesByName("Gw2-64").FirstOrDefault();
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                Utilities.GuildWars.SetForegroundWindow(h);
                System.Threading.Thread.Sleep(1000);
                Utilities.Mouse.LeftMouseClick(-1604, 711, 500);
                System.Windows.Forms.SendKeys.SendWait("k" + num.ToString());
                num++;
                System.Threading.Thread.Sleep(1000);
                Utilities.Mouse.LeftMouseClick(-1087, 544, 500);
                System.Threading.Thread.Sleep(1000);
                System.Windows.Forms.SendKeys.SendWait("k" + num.ToString());
            }            
        }

        public static void PlaceBuyOrder(string Quantity)
        {
            //Click Home Tab
            Utilities.Mouse.LeftMouseClick(385, 95, 100);

            //Click Buy Tab
            Utilities.Mouse.LeftMouseClick(550, 95, 100);

            //Remove Filter
            Utilities.Mouse.LeftMouseClick(445, 165, 100);

            //Click Into Search
            Utilities.Mouse.LeftMouseClick(70, 165, 100);

            //Click First Result
            Utilities.Mouse.LeftMouseClick(625, 245, 100);

            //Click Quantity Text Box
            Utilities.Mouse.LeftMouseClick(385, 240, 100);

            //Delete Default Amount
            System.Windows.Forms.SendKeys.SendWait("Backspace");
            System.Windows.Forms.SendKeys.SendWait("Backspace");

            //Enter Buy Quantity
            System.Windows.Forms.SendKeys.SendWait(Quantity);

            //Click First "Current Buyer" check box
            Utilities.Mouse.LeftMouseClick(240, 500, 100);

            //Click Max. Price Copper and Increase By One
            Utilities.Mouse.LeftMouseClick(580, 275, 100);

            //Click Place Order
            Utilities.Mouse.LeftMouseClick(425, 375, 100);

            //Close Item Panel
            Utilities.Mouse.LeftMouseClick(760, 125, 100);
        }

        public static void PlaceSellOrder()
        {

        }

        public static void RemovedAllOrders()
        {

        }
    }
}
