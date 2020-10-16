using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("EnumValueIsUsed")]
    public partial class EnumValueIsUsedError : ErrorObject
    {
        public EnumValueIsUsedError()
        { 
           this.Code = "EnumValueIsUsed";
        }
    }
}
