using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction))]
    public partial interface IStagedOrderSetShippingAddressAndCustomShippingMethodAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

        string ShippingMethodName { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
