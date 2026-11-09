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
            
        }
        public List<Asset> LoadAssets()
        {

        }
        public List<Asset> LoadStock()
        {
            // Load every Asset
        }
        public List<Asset> LoadInUse()
        {
            // Load assets Marked in use
        }
        public List<Asset> LoadAvailable()
        {
            // Load assets marked as in stock

        }
        public List<Asset> LoadRecentAsset()
        {

        }
        public List<Asset> GetAssetsByState()
        {
            
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
