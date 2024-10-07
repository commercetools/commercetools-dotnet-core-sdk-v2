using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction))]
    public partial interface IShippingMethodSetPredicateAction : IShippingMethodUpdateAction
    {
        string Predicate { get; set; }

    }
}
