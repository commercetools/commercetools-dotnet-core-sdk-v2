using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartDraft))]
    public partial interface IMyCartDraft
    {
        string Currency { get; set; }

        string CustomerEmail { get; set; }

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        IStoreResourceIdentifier Store { get; set; }

        IList<IMyLineItemDraft> LineItems { get; set; }

        IEnumerable<IMyLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        ITaxMode TaxMode { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IBaseAddress BillingAddress { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IList<IBaseAddress> ItemShippingAddresses { get; set; }

        IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }

        IShippingMode ShippingMode { get; set; }

        IList<string> DiscountCodes { get; set; }

        IEnumerable<string> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }

        string Country { get; set; }

        string Locale { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
