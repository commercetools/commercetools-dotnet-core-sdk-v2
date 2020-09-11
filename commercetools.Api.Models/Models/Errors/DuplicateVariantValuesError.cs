using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class DuplicateVariantValuesError : ErrorObject
    {
        public VariantValues VariantValues { get; set;}
    }
}
