using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicatePriceScope")]
    public partial class DuplicatePriceScopeError : ErrorObject
    {
        public List<Price> ConflictingPrices { get; set;}
        public DuplicatePriceScopeError()
        { 
           this.Code = "DuplicatePriceScope";
        }
    }
}
