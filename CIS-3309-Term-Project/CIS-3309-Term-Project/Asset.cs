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
        public String CPU {get; set;}
        public String Ram {get; set;}
        public String OS {get; set;}
        public String Storage {get; set;}

        public Asset(String assetID,String make, String Model, DateTime date, State assetState, String location, String assetImage,
            String cpu, String ram, String os, String storage)
        {
            this.AssetID = assetID;
            this.Make = make;
            this.Model = Model;
            this.Date = date;
            this.AssetState = assetState;
            this.Location = location;
            this.AssetImage = assetImage;
            this.CPU = cpu;
            this.Ram = ram;
            this.OS = os;
            this.Storage = storage;
        }

    }
}
