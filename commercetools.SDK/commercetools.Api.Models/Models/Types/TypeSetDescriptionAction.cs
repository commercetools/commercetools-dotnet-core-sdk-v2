using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("setDescription")]
    public partial class TypeSetDescriptionAction : TypeUpdateAction
    {
        public LocalizedString Description { get; set;}
        public TypeSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
