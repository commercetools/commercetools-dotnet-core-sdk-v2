using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class DuplicatePriceScopeError : ErrorObject
    {
        public List<Price> ConflictingPrices { get; set;}
    }
}
