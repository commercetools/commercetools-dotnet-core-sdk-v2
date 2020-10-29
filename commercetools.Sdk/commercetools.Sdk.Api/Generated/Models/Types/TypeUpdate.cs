using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeUpdate : ITypeUpdate
    {
        public long Version { get; set;}
        
        public List<ITypeUpdateAction> Actions { get; set;}
    }
}
