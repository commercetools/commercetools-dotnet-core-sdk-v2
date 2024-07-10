using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
