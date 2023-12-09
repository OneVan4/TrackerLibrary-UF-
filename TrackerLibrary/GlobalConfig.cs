using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataconnectioncs> Connections { get; private set;  }


        public static void InitializeConnecetions (bool database, bool textfiles)
        {
            if (database)
            {
                SQLconnector sql = new SQLconnector();
                Connections.Add(sql);
            }


            if ( textfiles)
            {
                SQLconnector text = new SQLconnector();
                    Connections.Add (text);

            }
        }
    }
}
