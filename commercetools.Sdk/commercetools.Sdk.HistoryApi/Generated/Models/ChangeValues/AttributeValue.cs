using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class AttributeValue : IAttributeValue
    {
        public string Name { get; set; }

        public Object Value { get; set; }
    }
}
