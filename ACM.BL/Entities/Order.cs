﻿using ACM.BL.Entities;
using Acme.Commom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public string Log() => 
            $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.ToString()}";
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
