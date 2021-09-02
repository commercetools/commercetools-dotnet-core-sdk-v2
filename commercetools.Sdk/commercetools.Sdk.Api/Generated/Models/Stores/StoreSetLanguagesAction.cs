using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetLanguagesAction : IStoreSetLanguagesAction
    {
        public string Action { get; set; }

        public List<string> Languages { get; set; }
        public StoreSetLanguagesAction()
        {
            this.Action = "setLanguages";
        }
    }
}
