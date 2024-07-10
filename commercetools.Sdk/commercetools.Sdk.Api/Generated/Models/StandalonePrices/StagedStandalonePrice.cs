using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StagedStandalonePrice : IStagedStandalonePrice
    {
        public ITypedMoney Value { get; set; }

        public IDiscountedPrice Discounted { get; set; }
    }
}
