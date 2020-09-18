using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicatePriceScope")]
    public class DuplicatePriceScopeError : ErrorObject
    {
        public List<Price> ConflictingPrices { get; set;}
    }
}
