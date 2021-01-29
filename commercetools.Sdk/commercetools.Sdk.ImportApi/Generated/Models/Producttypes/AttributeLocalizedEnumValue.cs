using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
