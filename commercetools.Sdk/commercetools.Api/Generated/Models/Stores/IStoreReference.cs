using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Stores
{
    public interface IStoreReference : IReference
    {
        IStore Obj { get; set;}
    }
}
