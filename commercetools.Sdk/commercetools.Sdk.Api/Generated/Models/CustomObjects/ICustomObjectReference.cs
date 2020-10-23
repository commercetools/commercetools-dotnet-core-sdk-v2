using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObjectReference))]
    public interface ICustomObjectReference : IReference
    {
        ICustomObject Obj { get; set;}
    }
}
