using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set;}
    }
}
