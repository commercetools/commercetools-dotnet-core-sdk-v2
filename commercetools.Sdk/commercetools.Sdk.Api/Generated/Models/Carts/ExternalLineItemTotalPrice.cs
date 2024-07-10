using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ExternalLineItemTotalPrice : IExternalLineItemTotalPrice
    {
        public IMoney Price { get; set; }

        public IMoney TotalPrice { get; set; }
    }
}
