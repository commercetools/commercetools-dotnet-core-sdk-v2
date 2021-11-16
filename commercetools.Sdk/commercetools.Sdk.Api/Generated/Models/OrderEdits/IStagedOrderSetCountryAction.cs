using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCountryAction))]
    public partial interface IStagedOrderSetCountryAction : IStagedOrderUpdateAction
    {
        string Country { get; set; }
    }
}
