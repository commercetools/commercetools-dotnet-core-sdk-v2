using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetNameAction))]
    public partial interface IStoreSetNameAction : IStoreUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
