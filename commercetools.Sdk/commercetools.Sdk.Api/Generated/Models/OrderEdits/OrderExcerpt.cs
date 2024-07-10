using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderExcerpt : IOrderExcerpt
    {
        public ITypedMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public long Version { get; set; }
    }
}
