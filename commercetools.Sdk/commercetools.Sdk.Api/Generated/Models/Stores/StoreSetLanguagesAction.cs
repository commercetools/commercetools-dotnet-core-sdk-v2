using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetLanguagesAction : IStoreSetLanguagesAction
    {
        public string Action { get; set; }

        public IList<string> Languages { get; set; }
        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

        public StoreSetLanguagesAction()
        {
            this.Action = "setLanguages";
        }
    }
}
