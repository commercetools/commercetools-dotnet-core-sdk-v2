using System;

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetCustomFieldAction : IStoreSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StoreSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
