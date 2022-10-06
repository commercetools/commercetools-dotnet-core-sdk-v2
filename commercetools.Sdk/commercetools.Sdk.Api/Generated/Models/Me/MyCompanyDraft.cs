using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCompanyDraft : IMyCompanyDraft
    {
        public string Key { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public ICustomFields Custom { get; set; }

        public List<IBaseAddress> Addresses { get; set; }

        public List<int> ShippingAddresses { get; set; }

        public int? DefaultShipingAddress { get; set; }

        public List<int> BillingAddresses { get; set; }

        public int? DefaultBillingAddress { get; set; }
        public MyCompanyDraft()
        {
            this.UnitType = IBusinessUnitType.FindEnum("Company");
        }
    }
}
