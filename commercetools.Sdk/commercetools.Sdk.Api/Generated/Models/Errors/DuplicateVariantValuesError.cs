using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateVariantValues")]
    public partial class DuplicateVariantValuesError : ErrorObject
    {
        public VariantValues VariantValues { get; set;}
        public DuplicateVariantValuesError()
        { 
           this.Code = "DuplicateVariantValues";
        }
    }
}
