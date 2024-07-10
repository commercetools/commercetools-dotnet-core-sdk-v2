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
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitDraft))]
    [SubTypeDiscriminator("Company", typeof(commercetools.Sdk.Api.Models.BusinessUnits.CompanyDraft))]
    [SubTypeDiscriminator("Division", typeof(commercetools.Sdk.Api.Models.BusinessUnits.DivisionDraft))]
    public partial interface IBusinessUnitDraft
    {
        string Key { get; set; }

        IBusinessUnitStatus Status { get; set; }

        IList<IStoreResourceIdentifier> Stores { get; set; }
        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }


        IBusinessUnitStoreMode StoreMode { get; set; }

        IBusinessUnitType UnitType { get; set; }

        string Name { get; set; }

        string ContactEmail { get; set; }

        IBusinessUnitAssociateMode AssociateMode { get; set; }

        IList<IAssociateDraft> Associates { get; set; }
        IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }


        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        IList<IBaseAddress> Addresses { get; set; }
        IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        IList<int> ShippingAddresses { get; set; }
        IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        int? DefaultShippingAddress { get; set; }

        IList<int> BillingAddresses { get; set; }
        IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        int? DefaultBillingAddress { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        static commercetools.Sdk.Api.Models.BusinessUnits.CompanyDraft Company(Action<commercetools.Sdk.Api.Models.BusinessUnits.CompanyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.CompanyDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.DivisionDraft Division(Action<commercetools.Sdk.Api.Models.BusinessUnits.DivisionDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.DivisionDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
