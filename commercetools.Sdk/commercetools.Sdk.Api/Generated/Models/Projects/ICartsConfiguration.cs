using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartsConfiguration))]
    public partial interface ICartsConfiguration 
    {
        bool? CountryTaxRateFallbackEnabled { get; set;}
    }
}
