using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLocaleAction))]
    public partial interface IStagedOrderSetLocaleAction : IStagedOrderUpdateAction
    {
        string Locale { get; set; }
    }
}
