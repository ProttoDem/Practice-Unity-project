using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scripts.Model;

namespace Scripts.View { 
    public class CartBtnItem : MonoBehaviour
    {
        
        [HideInInspector]
        public CartController _cartController;

        [HideInInspector]
        public IProduct item;
        public void setItem(IProduct product)
        {
            item = product;
            cartItemText.text = item.getName() + " " + item.getCode();
        }

        [SerializeField]
        Text cartItemText;

        public void OnCartButtonClick()
        {
            _cartController.OnCartBtnClick();
        }

        private void Start()
        {
            
        }
    }
}