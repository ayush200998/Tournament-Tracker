using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class PrizeModel
    {
        public int id { get; set; }


        public int position { get; set; }

   
        public String positionName { get; set; }


        public decimal prizeAmount { get; set; }


        public double prizePercentage { get; set; }

        public PrizeModel(string placename, string placenumber,string prizeamount, string prizepercentage)
        {
            this.positionName = placename;
            int placeNumberValue = 0;
            int.TryParse(placenumber, out placeNumberValue);
            position = placeNumberValue;

            decimal prizeamountvalue = 0;
            decimal.TryParse(prizeamount, out prizeamountvalue);
            prizeAmount = prizeamountvalue;
            double prizepercentagevalue = 0;
            double.TryParse(prizepercentage, out prizepercentagevalue);
            prizePercentage = prizepercentagevalue;
            
        }

    }
}
