using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetStoreAction))]
    public partial interface IOrderSetStoreAction : IOrderUpdateAction
    {
        IStoreResourceIdentifier Store { get; set;}
    }
}
