using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class PriceTier : IPriceTier
    {
        public long MinimumQuantity { get; set; }

        public ITypedMoney Value { get; set; }
    }
}
