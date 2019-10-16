using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class SqlConnector : IDataConnection
    {
        // Make the create prize method actually saves the database.
        /// <summary>
        /// Creates the prize and returns it
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
           
            model.id = 1;
            return model;
        }
    }
}
