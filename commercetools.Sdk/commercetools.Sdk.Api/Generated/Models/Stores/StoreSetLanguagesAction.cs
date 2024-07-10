using System.Collections.Generic;
using System.Linq;


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
