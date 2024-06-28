using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class Company : ICompany
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IBusinessUnitStatus Status { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public ICustomFields Custom { get; set; }

        public IList<IAddress> Addresses { get; set; }
        public IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public IList<string> ShippingAddressIds { get; set; }
        public IEnumerable<string> ShippingAddressIdsEnumerable { set => ShippingAddressIds = value.ToList(); }


        public string DefaultShippingAddressId { get; set; }

        public IList<string> BillingAddressIds { get; set; }
        public IEnumerable<string> BillingAddressIdsEnumerable { set => BillingAddressIds = value.ToList(); }


        public string DefaultBillingAddressId { get; set; }

        public IBusinessUnitAssociateMode AssociateMode { get; set; }

        public IList<IAssociate> Associates { get; set; }
        public IEnumerable<IAssociate> AssociatesEnumerable { set => Associates = value.ToList(); }


        public IList<IInheritedAssociate> InheritedAssociates { get; set; }
        public IEnumerable<IInheritedAssociate> InheritedAssociatesEnumerable { set => InheritedAssociates = value.ToList(); }


        public IBusinessUnitKeyReference ParentUnit { get; set; }

        public IBusinessUnitKeyReference TopLevelUnit { get; set; }

        public IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }
        public Company()
        {
            this.UnitType = IBusinessUnitType.FindEnum("Company");
        }
    }
}
