using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLocaleAction))]
    public partial interface IOrderSetLocaleAction : IOrderUpdateAction
    {
        string Locale { get; set; }

    }
}
