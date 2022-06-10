using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.App
{
    public class DelegateList
    {
        public delegate void PopulateGrid(string a= null);
        public delegate void InventoryPopulateGrid(string a = null);
        public delegate void CompanyFill();
    }
}
