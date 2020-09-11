using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoreSetLanguagesAction : StoreUpdateAction
    {
        public List<string> Languages { get; set;}
    }
}
