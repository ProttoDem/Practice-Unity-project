using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts;
using Scripts.Model;

namespace Scripts.View

{
    public class CPUBtn1 : Btn
    {
        IProduct _product;
        public override IProduct product { get => _product; set => _product = value; }

        public void Clicked()
        {
            this.Notify();
        }


    }
}