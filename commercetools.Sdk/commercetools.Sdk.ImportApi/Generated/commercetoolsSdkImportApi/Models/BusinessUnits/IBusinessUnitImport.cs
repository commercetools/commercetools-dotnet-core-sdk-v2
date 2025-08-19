using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{
    [TypeDiscriminator(nameof(UnitType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.BusinessUnitImport))]
    [SubTypeDiscriminator("Company", typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.CompanyBusinessUnitImport))]
    [SubTypeDiscriminator("Division", typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.DivisionBusinessUnitImport))]
    public partial interface IBusinessUnitImport
    {
        IBusinessUnitType UnitType { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        IBusinessUnitStatus Status { get; set; }

        string ContactEmail { get; set; }

        IList<IAssociateDraft> Associates { get; set; }

        IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }

        IList<IAddress> Addresses { get; set; }

        IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        IList<int> ShippingAddresses { get; set; }

        IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }

        int? DefaultShippingAddress { get; set; }

        IList<int> BillingAddresses { get; set; }

        IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }

        int? DefaultBillingAddress { get; set; }

        IList<IStoreKeyReference> Stores { get; set; }

        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        ICustom Custom { get; set; }

        static commercetools.Sdk.ImportApi.Models.BusinessUnits.CompanyBusinessUnitImport Company(Action<commercetools.Sdk.ImportApi.Models.BusinessUnits.CompanyBusinessUnitImport> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.BusinessUnits.CompanyBusinessUnitImport();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.BusinessUnits.DivisionBusinessUnitImport Division(Action<commercetools.Sdk.ImportApi.Models.BusinessUnits.DivisionBusinessUnitImport> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.BusinessUnits.DivisionBusinessUnitImport();
            init?.Invoke(t);
            return t;
        }
    }
}
