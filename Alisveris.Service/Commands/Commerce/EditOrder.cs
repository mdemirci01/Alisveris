﻿using Alisveris.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Update, "Sipariş güncellendi.")]
    public class EditOrder : Command
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DemandDate { get; set; }
        public string OrderCode { get; set; }
        public int Quantity { get; set; }
        public Address DeliveryAddress { get; set; }
        public Address InvoiceAddress { get; set; }
        public string DeliveryAddressId { get; set; }
        public string InvoiceAddressId { get; set; }
        public int Total { get; set; }
        public string StoreId { get; set; }
        public Store Store { get; set; }
    }
}
