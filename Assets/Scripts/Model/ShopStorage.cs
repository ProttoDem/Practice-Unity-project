using System.Collections;
using System.Collections.Generic;

namespace Scripts.Model
{
    public class ShopStorage {

        public List<IProduct> storage;
        public List<IProduct> GetStorage()
        {
            return storage;
        }
        public void AddItem(IProduct item)
        {
            storage.Add(item);
        }
        private static ShopStorage instance;

        private ShopStorage()
        {
            storage = new List<IProduct>();
        }

        public static ShopStorage getInstance()
        {
            if (instance == null)
                instance = new ShopStorage();
            return instance;
        }

    }
}