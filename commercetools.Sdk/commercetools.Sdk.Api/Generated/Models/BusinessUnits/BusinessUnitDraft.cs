using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitDraft : IBusinessUnitDraft
    {
        public string Key { get; set; }

        public IBusinessUnitStatus Status { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public IList<IAssociateDraft> Associates { get; set; }
        public IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }


        public IList<IBaseAddress> Addresses { get; set; }
        public IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public IList<int> ShippingAddresses { get; set; }
        public IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        public int? DefaultShippingAddress { get; set; }

        public IList<int> BillingAddresses { get; set; }
        public IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        public int? DefaultBillingAddress { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
