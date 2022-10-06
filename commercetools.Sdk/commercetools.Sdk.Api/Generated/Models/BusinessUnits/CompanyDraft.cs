using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class CompanyDraft : ICompanyDraft
    {
        public string Key { get; set; }

        public IBusinessUnitStatus Status { get; set; }

        public List<IStoreKeyReference> Stores { get; set; }

        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public List<IAssociateDraft> Associates { get; set; }

        public List<IBaseAddress> Addresses { get; set; }

        public List<int> ShippingAddresses { get; set; }

        public int? DefaultShipingAddress { get; set; }

        public List<int> BillingAddresses { get; set; }

        public int? DefaultBillingAddress { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
        public CompanyDraft()
        {
            this.UnitType = IBusinessUnitType.FindEnum("Company");
        }
    }
}
