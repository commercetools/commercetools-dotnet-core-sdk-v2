using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ShippingMethodTaxAmountChangeValue : IShippingMethodTaxAmountChangeValue
    {
        public ITaxedPrice TaxedPrice { get; set; }

        public ITaxRate TaxRate { get; set; }
    }
}
