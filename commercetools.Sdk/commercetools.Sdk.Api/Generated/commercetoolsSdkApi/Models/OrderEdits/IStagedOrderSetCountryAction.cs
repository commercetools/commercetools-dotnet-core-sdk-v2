using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCountryAction))]
    public partial interface IStagedOrderSetCountryAction : IStagedOrderUpdateAction
    {
        string Country { get; set; }

    }
}
