using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeKeyReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
