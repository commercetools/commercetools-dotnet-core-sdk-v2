using System.Collections.Generic;


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
