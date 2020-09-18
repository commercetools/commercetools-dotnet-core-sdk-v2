using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeKey")]
    public class TypeChangeKeyAction : TypeUpdateAction
    {
        public string Key { get; set;}
    }
}
