using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

     private void createprizebutton_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                TrackerLibrary.PrizeModel model = new PrizeModel
                    (
                    placenamevalue.Text, 
                    placenumbervalue.Text, 
                    prizeamountvalue.Text,
                    prizepercentagevalue.Text
                    );
                foreach(TrackerLibrary.IDataConnection db in TrackerLibrary.GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                    
                }
            }
            else
            {
                MessageBox.Show("Please check the form , Invalid Inormation");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;

            //checks whether the value is valid or not and return the output to placeNumber .
            bool isPlaceNumbervalid = int.TryParse(placenumbervalue.Text, out placeNumber);

            if(!isPlaceNumbervalid)
            {
                output = false;
            }
            if(placeNumber < 1)
            {
                output = false;
            }

            if(placenamevalue.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool isPrizeAmountValid = decimal.TryParse(prizeamountvalue.Text, out prizeAmount);
            bool isPrizePercentageValid = double.TryParse(prizepercentagevalue.Text, out prizePercentage);

            if(isPrizeAmountValid == false || isPrizePercentageValid == false)
            {
                output = false;
            }
            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
