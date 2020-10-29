using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumValue))]
    public interface ICustomFieldLocalizedEnumValue 
    {
        string Key { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
