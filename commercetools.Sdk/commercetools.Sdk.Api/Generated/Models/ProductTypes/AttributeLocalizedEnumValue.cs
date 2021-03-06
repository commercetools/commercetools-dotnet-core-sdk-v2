using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
