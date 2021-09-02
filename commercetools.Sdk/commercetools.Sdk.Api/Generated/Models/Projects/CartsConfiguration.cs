using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class CartsConfiguration : ICartsConfiguration
    {
        public bool? CountryTaxRateFallbackEnabled { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }
    }
}
