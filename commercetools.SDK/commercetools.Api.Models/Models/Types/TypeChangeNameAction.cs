using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeName")]
    public partial class TypeChangeNameAction : TypeUpdateAction
    {
        public LocalizedString Name { get; set;}
        public TypeChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
