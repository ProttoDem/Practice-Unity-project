using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Model {
    public class Cart /*: MonoBehaviour*/
    {
        List<IProduct> _cart = new List<IProduct>();

        private static Cart instance;

        private Cart()
        {
            _cart = new List<IProduct>();
        }

        public static Cart getInstance()
        {
            if (instance == null)
                instance = new Cart();
            return instance;
        }

        public void AddToCart(IProduct product)
        {
            _cart.Add(product);
        }
    }
}