using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("LanguageUsedInStores")]
    public partial class LanguageUsedInStoresError : ErrorObject
    {
        public LanguageUsedInStoresError()
        { 
           this.Code = "LanguageUsedInStores";
        }
    }
}
