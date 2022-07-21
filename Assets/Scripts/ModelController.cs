using System;
using Scripts.Model;
using UnityEngine;


namespace Scripts
{
    class ModelController : MonoBehaviour, IObserver
    {
        
        public void Start()
        {
            IntelComponents intel = new IntelComponents();
            var generator = new ShopStorageGenerator(intel);
            generator.GenerateModelSeries(3);
            AMDComponents amd = new AMDComponents();
            generator.ChangeFactory(amd);
            generator.GenerateModelSeries(4);
            
        }

        public bool dropToCart(IProduct _product)
        {
            _product.getName();
            IProduct _item;
            foreach (IProduct item in ShopStorage.getInstance().GetStorage())
            {

                if (item.getName() == _product.getName())
                {
                    _item = item;
                    ShopStorage.getInstance().GetStorage().Remove(_item);

                }
                else
                {
                    return false;
                }
                
            }
            return true;


        }
       
        public void UpdateObserver(ISubject subject)
        {
            /*switch (subject.)
            {
                case 0:
                    

                    break;
            }*/
            
        }
    }
}
