using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeReference : IAttributeReference
    {
        public string Key { get; set; }
    }
}
