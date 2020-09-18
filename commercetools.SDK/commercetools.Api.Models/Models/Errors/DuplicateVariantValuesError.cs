using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateVariantValues")]
    public class DuplicateVariantValuesError : ErrorObject
    {
        public VariantValues VariantValues { get; set;}
    }
}
