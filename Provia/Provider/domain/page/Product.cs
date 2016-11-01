﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.domain.page
{
    class Product
    {
        private int ID;
        private double price;
        private DateTime delverytime;
        private String productinfomation;
        private String productname; 
        /// <summary>
        /// The constructor to a product
        /// Make sure that the price isnt negativ
        /// </summary>
        /// <param name="ID">ID for this product</param>
        /// <param name="price">Price for this</param>
        /// <param name="productinfomation">Information about product</param>
        /// <param name="productname">The name of the product</param>
        /// <param name="delverytime">The estimated time for a delvery</param>
        public Product(int ID, double price, String productinfomation, String productname, DateTime delverytime)
        {
            this.ID = ID;
            this.price = price;
            this.productinfomation = productinfomation;
            this.productname = productname;
            this.delverytime = delverytime;
        }
        /// <summary>
        /// The constructor to a product 
        /// Make sure that the price isnt negativ
        /// </summary>
        /// <param name="ID">ID for this product</param>
        /// <param name="price">Price for this</param>
        /// <param name="productinfomation">Information about product</param>
        /// <param name="productname">The name of the product</param>
        public Product(int ID, double price, String productinfomation, String productname) : 
            this(ID, price, productinfomation, productname, default(DateTime)){ }
    }
}