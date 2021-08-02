using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class CustomFieldExpandedValue : ICustomFieldExpandedValue
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
