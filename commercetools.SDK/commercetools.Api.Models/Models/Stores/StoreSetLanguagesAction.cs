using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setLanguages")]
    public partial class StoreSetLanguagesAction : StoreUpdateAction
    {
        public List<string> Languages { get; set;}
        public StoreSetLanguagesAction()
        { 
           this.Action = "setLanguages";
        }
    }
}
