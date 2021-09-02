using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class TaxedPrice : ITaxedPrice
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }

        public List<ITaxPortion> TaxPortions { get; set; }
    }
}
