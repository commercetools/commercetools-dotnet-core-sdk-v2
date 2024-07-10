using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartsConfiguration : ICartsConfiguration
    {
        public long? DeleteDaysAfterLastModification { get; set; }

        public bool? CountryTaxRateFallbackEnabled { get; set; }
    }
}
