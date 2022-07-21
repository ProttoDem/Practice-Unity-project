using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Model;
using Scripts.View;

namespace Scripts {
    public class CartController : MonoBehaviour
    {
        [SerializeField] int numberOfItems;
        [SerializeField] GameObject cartBtnPref;
        [SerializeField] Transform cartBtnParent;


        public void LoadCartButton(IProduct _product)
        {

            GameObject cartBtnObj = Instantiate(cartBtnPref, cartBtnParent) as GameObject;
            cartBtnObj.GetComponent<CartBtnItem>()._cartController = this;
            cartBtnObj.GetComponent<CartBtnItem>().item = _product;
        }

        public void OnCartBtnClick()
        {
            
        }
    }
}
