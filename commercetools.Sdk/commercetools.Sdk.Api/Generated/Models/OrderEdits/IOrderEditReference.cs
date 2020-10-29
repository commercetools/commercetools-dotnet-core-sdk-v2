using commercetools.Api.Models.Common;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditReference))]
    public interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set;}
    }
}
