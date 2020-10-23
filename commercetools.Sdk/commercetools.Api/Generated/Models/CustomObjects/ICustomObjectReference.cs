using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CustomObjects
{
    public interface ICustomObjectReference : IReference
    {
        ICustomObject Obj { get; set;}
    }
}
