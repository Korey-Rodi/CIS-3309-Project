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
        public bool DeleteAsset()
        {
            return true;
        }
        public bool EditAsset()
        {
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
        public List<Asset> LoadStock()
        {
            // Load every Asset
            // This is redundant
            return null;
        }
        public List<Asset> LoadInUse()
        {
            List<Asset> assets = new List<Asset>();
            foreach (Asset asset in assetCollection.Assets)
            {
                if (asset.AssetState.Equals(Asset.State.In_Use.ToString()))
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
                if (asset.AssetState.Equals(Asset.State.In_Stock.ToString()))
                {
                    assets.Add(asset);
                }
            }
            // Load assets marked as in stock
            return assets;

        }
        public List<Asset> LoadRecentAsset()
        {
            return null;
        }
        public List<Asset> GetAssetsByState()
        {
            return null;
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
            List<Asset> Search(String search);
        }
        public class SearchByID : ISearch
        {
            public List<Asset> Search(String search)
            {
                List<Asset> results = new List<Asset>();
                return results;
            }
        }
        public class SearchByMake : ISearch
        {
            public List<Asset> Search(String search)
            {
                List<Asset> results = new List<Asset>();
                return results;
            }
        }
        public class SearchByModel : ISearch
        {
            public List<Asset> Search(String search)
            {
                List<Asset> results = new List<Asset>();
                return results;
            }
        }
    }
}
