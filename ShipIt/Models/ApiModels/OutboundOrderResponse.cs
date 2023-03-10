﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse : Response
    {
        public int TruckId { get; set; }
        public StockAlteration StockAlteration { get; set;}
        
        public OutboundOrderResponse(int truckId , StockAlteration stockAlteration)
        {
            TruckId = truckId;
            StockAlteration = stockAlteration;
        }
    }
}