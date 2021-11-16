using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetNameAction : IStoreSetNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public StoreSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}
