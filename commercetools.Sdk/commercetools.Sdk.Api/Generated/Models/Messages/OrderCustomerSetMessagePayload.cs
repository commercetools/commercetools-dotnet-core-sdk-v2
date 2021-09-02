using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderCustomerSetMessagePayload : IOrderCustomerSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public ICustomerReference OldCustomer { get; set; }

        public ICustomerGroupReference OldCustomerGroup { get; set; }
        public OrderCustomerSetMessagePayload()
        {
            this.Type = "OrderCustomerSet";
        }
    }
}
