using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("type")]
    public partial class TypeResourceIdentifier : ResourceIdentifier
    {
        public TypeResourceIdentifier()
        { 
           this.TypeId = "type";
        }
    }
}
