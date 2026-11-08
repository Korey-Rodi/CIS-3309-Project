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
        public void LoadAssets()
        {

        }
        public void LoadStock()
        {

        }
        public void LoadInUse()
        {

        }
        public void LoadRecentAsset()
        {

        }
        public Asset GetAsset()
        {
            // Place Holder Code
            Asset asset = null;
            return asset;
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
