﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class Truck
    {
        public int TruckId { get; set; }
        public List<StockAlteration> StockAlterations{ get; set; }

        public Truck(int truckId , List<StockAlteration> stockAlterations)
        {
            TruckId = truckId;
            StockAlterations = stockAlterations;
        }
    }
}