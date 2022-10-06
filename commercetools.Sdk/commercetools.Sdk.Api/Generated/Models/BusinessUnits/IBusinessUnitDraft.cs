using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IStoreKeyReference> Stores { get; set; }

        IBusinessUnitStoreMode StoreMode { get; set; }

        IBusinessUnitType UnitType { get; set; }

        string Name { get; set; }

        string ContactEmail { get; set; }

        List<IAssociateDraft> Associates { get; set; }

        List<IBaseAddress> Addresses { get; set; }

        List<int> ShippingAddresses { get; set; }

        int? DefaultShipingAddress { get; set; }

        List<int> BillingAddresses { get; set; }

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
