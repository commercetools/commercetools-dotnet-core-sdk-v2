using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartDraft))]
    public partial interface IMyCartDraft
    {
        string Currency { get; set; }

        string CustomerEmail { get; set; }

        string Country { get; set; }

        IInventoryMode InventoryMode { get; set; }

        List<IMyLineItemDraft> LineItems { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IBaseAddress BillingAddress { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        ITaxMode TaxMode { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        List<IBaseAddress> ItemShippingAddresses { get; set; }

        IStoreKeyReference Store { get; set; }

        List<string> DiscountCodes { get; set; }

    }
}
