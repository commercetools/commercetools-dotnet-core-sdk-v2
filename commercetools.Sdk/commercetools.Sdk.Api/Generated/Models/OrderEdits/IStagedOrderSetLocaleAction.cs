using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLocaleAction))]
    public partial interface IStagedOrderSetLocaleAction : IStagedOrderUpdateAction
    {
        string Locale { get; set; }

    }
}
