﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse : Response
    {
        public List<Truck> Trucks { get; set; }
        public OutboundOrderResponse(List<Truck> trucks)
        {
            Trucks = trucks;
        }
    }
}