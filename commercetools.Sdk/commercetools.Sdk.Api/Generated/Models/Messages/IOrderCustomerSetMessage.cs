using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage))]
    public partial interface IOrderCustomerSetMessage : IOrderMessage
    {
        ICustomerReference Customer { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerReference OldCustomer { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }

    }
}
