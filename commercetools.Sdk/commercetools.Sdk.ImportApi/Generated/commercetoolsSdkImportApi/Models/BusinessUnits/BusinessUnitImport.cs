using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{

    public partial class BusinessUnitImport : IBusinessUnitImport
    {
        public IBusinessUnitType UnitType { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public IBusinessUnitStatus Status { get; set; }

        public string ContactEmail { get; set; }

        public IList<IAssociateDraft> Associates { get; set; }

        public IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }

        public IList<IAddress> Addresses { get; set; }

        public IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        public IList<int> ShippingAddresses { get; set; }

        public IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }

        public int? DefaultShippingAddress { get; set; }

        public IList<int> BillingAddresses { get; set; }

        public IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }

        public int? DefaultBillingAddress { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }

        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public ICustom Custom { get; set; }
    }
}
