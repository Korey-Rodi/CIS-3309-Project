using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class Asset
    {
        public string AssetID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Date { get; set; }
        public enum State
        {
            // when creating an asset convert the enum with ToString()
            // before writing it to the database
            Retired,Broken, In_Use, In_Stock
        }
        public State AssetState {get; set;}
        public String Location { get; set; }
        public String AssetImage { get; set; }
        public List<String> MachineSpecs {  get; set; }

        public Asset(String assetID,String make, String Model, DateTime date, State assetState, String location, String assetImage,
            List<String> machineSpecs)
        {
            this.AssetID = assetID;
            this.Make = make;
            this.Model = Model;
            this.Date = date;
            this.AssetState = assetState;
            this.Location = location;
            this.AssetImage = assetImage;
            this.MachineSpecs = machineSpecs;
        }

    }
}
