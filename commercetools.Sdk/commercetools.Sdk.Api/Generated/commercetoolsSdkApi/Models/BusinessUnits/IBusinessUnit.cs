using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [TypeDiscriminator(nameof(UnitType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnit))]
    [SubTypeDiscriminator("Company", typeof(commercetools.Sdk.Api.Models.BusinessUnits.Company))]
    [SubTypeDiscriminator("Division", typeof(commercetools.Sdk.Api.Models.BusinessUnits.Division))]
    public partial interface IBusinessUnit : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IBusinessUnitStatus Status { get; set; }

        IList<IStoreKeyReference> Stores { get; set; }

        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        IBusinessUnitStoreMode StoreMode { get; set; }

        IBusinessUnitType UnitType { get; set; }

        string Name { get; set; }

        string ContactEmail { get; set; }

        ICustomFields Custom { get; set; }

        IList<IAddress> Addresses { get; set; }

        IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        IList<string> ShippingAddressIds { get; set; }

        IEnumerable<string> ShippingAddressIdsEnumerable { set => ShippingAddressIds = value.ToList(); }

        string DefaultShippingAddressId { get; set; }

        IList<string> BillingAddressIds { get; set; }

        IEnumerable<string> BillingAddressIdsEnumerable { set => BillingAddressIds = value.ToList(); }

        string DefaultBillingAddressId { get; set; }

        IBusinessUnitAssociateMode AssociateMode { get; set; }

        IList<IAssociate> Associates { get; set; }

        IEnumerable<IAssociate> AssociatesEnumerable { set => Associates = value.ToList(); }

        IList<IInheritedAssociate> InheritedAssociates { get; set; }

        IEnumerable<IInheritedAssociate> InheritedAssociatesEnumerable { set => InheritedAssociates = value.ToList(); }

        IBusinessUnitKeyReference ParentUnit { get; set; }

        IBusinessUnitKeyReference TopLevelUnit { get; set; }

        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        static commercetools.Sdk.Api.Models.BusinessUnits.Company Company(Action<commercetools.Sdk.Api.Models.BusinessUnits.Company> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.Company();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.Division Division(Action<commercetools.Sdk.Api.Models.BusinessUnits.Division> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.Division();
            init?.Invoke(t);
            return t;
        }
    }
}
