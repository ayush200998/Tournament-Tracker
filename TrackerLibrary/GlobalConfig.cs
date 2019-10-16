using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections = new List<IDataConnection>();



        public static void InitializeComponents(bool database, bool textfile)
        {
            if (database)
            {
                // TODO - Create the SQL Connection. 
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textfile)
            {
                //TODO - Create the textfile Connection. 
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
