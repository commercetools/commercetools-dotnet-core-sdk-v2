using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


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

        public List<IStoreKeyReference> Stores { get; set; }

        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public string Name { get; set; }

        public string ContactEmail { get; set; }

        public ICustomFields Custom { get; set; }

        public List<IAddress> Addresses { get; set; }

        public List<string> ShippingAddressIds { get; set; }

        public string DefaultShipingAddressId { get; set; }

        public List<string> BillingAddressIds { get; set; }

        public string DefaultBillingAddressId { get; set; }

        public List<IAssociate> Associates { get; set; }

        public IBusinessUnitKeyReference ParentUnit { get; set; }

        public IBusinessUnitKeyReference TopLevelUnit { get; set; }
        public Company()
        {
            this.UnitType = IBusinessUnitType.FindEnum("Company");
        }
    }
}
