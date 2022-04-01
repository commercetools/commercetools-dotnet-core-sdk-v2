using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreSetCustomTypeAction : IStoreSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StoreSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
