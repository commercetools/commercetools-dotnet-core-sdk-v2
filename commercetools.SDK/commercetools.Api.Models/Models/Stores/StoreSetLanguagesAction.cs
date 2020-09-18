using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setLanguages")]
    public class StoreSetLanguagesAction : StoreUpdateAction
    {
        public List<string> Languages { get; set;}
    }
}
