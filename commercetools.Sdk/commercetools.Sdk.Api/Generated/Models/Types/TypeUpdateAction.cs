using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeUpdateAction : ITypeUpdateAction
    {
        public string Action { get; set;}
    }
}
