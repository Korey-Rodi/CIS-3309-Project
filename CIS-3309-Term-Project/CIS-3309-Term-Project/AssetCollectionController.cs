using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class AssetCollectionController
    {
        private AssetCollection assets;
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
            return null;
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
