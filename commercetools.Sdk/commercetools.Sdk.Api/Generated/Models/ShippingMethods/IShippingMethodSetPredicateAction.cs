using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction))]
    public partial interface IShippingMethodSetPredicateAction : IShippingMethodUpdateAction
    {
        string Predicate { get; set; }
    }
}
