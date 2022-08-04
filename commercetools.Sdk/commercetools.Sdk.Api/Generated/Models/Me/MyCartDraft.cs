using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartDraft : IMyCartDraft
    {
        public string Currency { get; set; }

        public string CustomerEmail { get; set; }

        public string Country { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public List<IMyLineItemDraft> LineItems { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IBaseAddress BillingAddress { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public ITaxMode TaxMode { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public List<IBaseAddress> ItemShippingAddresses { get; set; }

        public IStoreKeyReference Store { get; set; }

        public List<string> DiscountCodes { get; set; }
    }
}
