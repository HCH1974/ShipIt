﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class ProductWeight
    {
        public int ProductId { get; set; }
        public double TotalWeight { get; set; }
        public int Quantity { get; set; }

        public ProductWeight(int productId , double totalWeight, int quantity)
        {
            ProductId = productId;
            TotalWeight = totalWeight;
            Quantity = quantity;
        }
    }
}