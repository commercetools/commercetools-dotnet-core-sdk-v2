using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setName")]
    public class StoreSetNameAction : StoreUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
