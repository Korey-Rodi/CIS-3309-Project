using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class AssetCollectionController
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        private AssetCollection assetCollection = new AssetCollection();
        internal AssetCollectionController()
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
        public bool AddAsset()
        {
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
            return null;
        }
        public List<Asset> LoadInUse()
        {
            // Load assets Marked in use
            return null;
        }
        public List<Asset> LoadAvailable()
        {
            // Load assets marked as in stock
            return null;

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
            // Place Holder code
            return 0;
        }
        // Search Interface
        public interface ISearch
        {
            List<Asset> Search(String search);
        }
        public class SearchByID : ISearch
        {
            public List<Asset> Search(String search)
            {
                List<Asset> Results = new List<Asset>();
                return new List<Asset>();
            }
        }
    }
}
