using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction))]
    public partial interface IStagedOrderSetCustomShippingMethodAction : IStagedOrderUpdateAction
    {
        string ShippingMethodName { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
