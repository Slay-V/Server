using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace GVRP
{
    public class wrongScale : Script
    {
        [RemoteEvent("wrongScreenScale")]
        public void antiHS(Player p)
        {
            p.SendNotification("du dummer hs darfst kein 5:4 oder 4:3 haben oder so.", false);
            p.Kick("");
        }
    }
}
