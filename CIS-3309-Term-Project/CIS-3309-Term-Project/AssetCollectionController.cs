using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    public class AssetCollectionController
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        private AssetCollection assetCollection = new AssetCollection();
        public AssetCollectionController()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Asset.accdb;");
        }
        //returns dataset info so we don't have to rewrite this on every sql involved method
        private DataSet AssetRunQuery(string strSQL)
        {
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("AssetTable");
            myDataAdapter.Fill(myDataSet, "AssetTable");

            return myDataSet;
        }
        private void UserExecuteQuery(String strSQL)
        {
            // This works for Update, Insert and Delete statements
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public bool AddAsset(Asset asset)
        {
            //C# int unassigned = 0, while db does "NULL" which inserts it as blank.
            String userAssignedIdValue = "NULL";
            if (asset.AssignedUserId != 0)
            {
                userAssignedIdValue = asset.AssignedUserId.ToString();
            }

            UserExecuteQuery("INSERT INTO Assets (Make, Model, DateLastStateChange, State, Location, PictureAsset, CPU, RAM, OS, Storage, AssignedUserID) VALUES ('"
            + asset.Make + "', '" + asset.Model + "', '" + asset.Date.ToString("yyyy-MM-dd") + "', '" + asset.AssetState.ToString() + "', '" + asset.Location + "', '" + asset.AssetImage + "', '" +
            asset.CPU + "', '" + asset.Ram + "', '" + asset.OS + "', '" + asset.Storage + "', " + userAssignedIdValue + ");");
            LoadAssets();
            return true;
        }
        public bool DeleteAsset(Asset asset)
        {
            String assetId = asset.AssetID.ToString();
            UserExecuteQuery("DELETE FROM Assets WHERE AssetID = " + assetId + ";");
            LoadAssets();
            return true;
        }
        public bool EditAsset(Asset asset)
        {
            String id = asset.AssetID.ToString();

            //C# int unassigned = 0, while db does "NULL" which inserts it as blank.
            String userAssignedIdValue = "NULL";
            if (asset.AssignedUserId != 0)
            {
                userAssignedIdValue = asset.AssignedUserId.ToString();
            }

            UserExecuteQuery("UPDATE Assets SET " + "Make = '" + asset.Make + "', " + "Model = '" + asset.Model + "', " + "DateLastStateChange = '" + asset.Date.ToString("yyyy-MM-dd") + "', " +
            "State = '" + asset.AssetState.ToString() + "', " + "Location = '" + asset.Location + "', " + "PictureAsset = '" + asset.AssetImage + "', " + "CPU = '" + asset.CPU + "', " +
            "RAM = '" + asset.Ram + "', " + "OS = '" + asset.OS + "', " + "Storage = '" + asset.Storage + "', " +
            "AssignedUserID = " + userAssignedIdValue + " " + "WHERE AssetID = " + id + ";");
            LoadAssets();
            return true;
        }
        public bool CheckInAsset(Asset asset)
        {
            int AssetID = asset.AssetID;
            // We need to pass the user and set assign the assigned user to the this asset
            UserExecuteQuery("UPDATE Assets SET State = 'In_Stock', AssignedUserID =  NULL " + "WHERE AssetID = " + AssetID + ";");
            return true;
        }
        public bool CheckOutAsset(Asset asset, User user)
        {
            int AssetID = asset.AssetID;
            int UserID = user.UserID;
            // We need to pass the user and set assign the assigned user to the this asset
            UserExecuteQuery("UPDATE Assets SET State = 'In_Use', AssignedUserID = " + UserID + " WHERE AssetID = " + AssetID + ";");
            return true;
        }
        public List<Asset> LoadAssets()
        {
            myDataSet = AssetRunQuery("SELECT * FROM Assets ORDER BY AssetID");

            assetCollection = new AssetCollection();

            foreach (DataRow record in myDataSet.Tables["AssetTable"].Rows)
            {

                int assetId = int.Parse(record["AssetID"].ToString());

                DateTime date = DateTime.Parse(record["DateLastStateChange"].ToString());

                //handling the possibilities for the enum
                Asset.State assetState;
                if (record["State"].ToString() == "Retired")
                {
                    assetState = Asset.State.Retired;
                }
                else if (record["State"].ToString() == "Broken")
                {
                    assetState = Asset.State.Broken;
                }
                else if (record["State"].ToString() == "In_Use")
                {
                    assetState = Asset.State.In_Use;
                }
                else
                {
                    assetState = Asset.State.In_Stock;
                }

                //blank unassigned user = 0
                int assignedUserId = 0;
                if (record["AssignedUserID"].ToString() != "")
                {
                    assignedUserId = int.Parse(record["AssignedUserID"].ToString());
                }

                //building the asset for dgv
                Asset asset = new Asset(
                    assetId,
                    record["Make"].ToString(),
                    record["Model"].ToString(),
                    date,
                    assetState,
                    record["Location"].ToString(),
                    record["PictureAsset"].ToString(),
                    record["CPU"].ToString(),
                    record["RAM"].ToString(),
                    record["OS"].ToString(),
                    record["Storage"].ToString(),
                    assignedUserId);

                assetCollection.Assets.Add(asset);

            }
            return assetCollection.Assets;
        }
        public List<Asset> LoadInUse()
        {
            List<Asset> assets = new List<Asset>();
            foreach (Asset asset in assetCollection.Assets)
            {
                if (asset.AssetState == Asset.State.In_Use)
                {
                    assets.Add(asset);
                }
            }
            // Load assets Marked in use
            return assets;
        }
        public List<Asset> LoadAvailable()
        {
            List<Asset> assets = new List<Asset>();
            foreach (Asset asset in assetCollection.Assets)
            {
                if (asset.AssetState == Asset.State.In_Stock)
                {
                    assets.Add(asset);
                }
            }
            // Load assets marked as in stock
            return assets;

        }
        public List<Asset> LoadRecentAsset()
        {
            DateTime today = DateTime.Today;
            DateTime cutoff = today.AddDays(-14);
            List<Asset> assets = new List<Asset>();
            foreach(Asset asset in assetCollection.Assets)
            {
                //assets whose state changed in the last 14 days
                if (asset.Date >= cutoff)
                {
                    assets.Add(asset);
                }
            }
            return assets;
        }
        public Dictionary<String, int> GetAssetsByState()
        {
            Dictionary<String,int> AssetsByState = new Dictionary<string, int>();
            foreach(Asset asset in assetCollection.Assets)
            {
                if (!AssetsByState.ContainsKey(asset.AssetState.ToString()))
                {
                    AssetsByState.Add(asset.AssetState.ToString(),1);
                } else
                {
                    AssetsByState[asset.AssetState.ToString()]++;
                }
            }
            return AssetsByState;
        }
        public int GetAssetCount()
        {
            return assetCollection.Assets.Count;
        }
        public List<Asset> LoadMyDevices(User currentUser)
        {
            List<Asset> assets = new List<Asset>();
            foreach (Asset asset in assetCollection.Assets)
            {
                if (asset.AssignedUserId == currentUser.UserID)
                {
                    assets.Add(asset);
                }
            }
            return assets;
        }
        // Asset Search Interface
        public interface ISearch
        {
            List<Asset> Search(String search, AssetCollection assetCollection);
        }
        public class SearchByID : ISearch
        {
            private AssetCollection assetCollection = new AssetCollection();
            public List<Asset> Search(String search,AssetCollection assetCollection)
            {
                List<Asset> results = new List<Asset>();
                foreach(Asset asset in assetCollection.Assets)
                {
                    if(asset.AssetID.ToString() == search)
                    {
                        results.Add(asset);
                    }
                }
                return results;
            }
        }
        public class SearchByMake : ISearch
        {
            public List<Asset> Search(String search, AssetCollection assetCollection)
            {
                List<Asset> results = new List<Asset>();
                foreach(Asset asset in assetCollection.Assets)
                {
                    if(asset.Make == search)
                    {
                        results.Add(asset);
                    }
                }
                return results;
            }
        }
        public class SearchByModel : ISearch
        {
            public List<Asset> Search(String search, AssetCollection assetCollection)
            {
                List<Asset> results = new List<Asset>();
                foreach(Asset asset in assetCollection.Assets)
                {
                    if(asset.Model == search)
                    {
                        results.Add(asset);
                    }
                }
                return results;
            }
        }
    }
}
