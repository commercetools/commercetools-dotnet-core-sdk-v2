using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCompanyDraft : IMyCompanyDraft
    {
        public string Key { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public ICustomFields Custom { get; set; }

        public IList<IBaseAddress> Addresses { get; set; }
        public IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public IList<int> ShippingAddresses { get; set; }
        public IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        public int? DefaultShippingAddress { get; set; }

        public IList<int> BillingAddresses { get; set; }
        public IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        public int? DefaultBillingAddress { get; set; }
        public MyCompanyDraft()
        {
            this.UnitType = IBusinessUnitType.FindEnum("Company");
        }
    }
}
