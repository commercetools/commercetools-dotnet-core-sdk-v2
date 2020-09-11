using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoreSetNameAction : StoreUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
