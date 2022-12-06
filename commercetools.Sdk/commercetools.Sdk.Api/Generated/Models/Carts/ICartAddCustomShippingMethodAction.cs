using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction))]
    public partial interface ICartAddCustomShippingMethodAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        string ShippingMethodName { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        string ExternalTaxRate { get; set; }

        IList<IDelivery> Deliveries { get; set; }
        IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        string Custom { get; set; }

    }
}
