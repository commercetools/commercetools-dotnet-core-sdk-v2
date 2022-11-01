using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IStoreKeyReference> Stores { get; set; }

        IBusinessUnitStoreMode StoreMode { get; set; }

        IBusinessUnitType UnitType { get; set; }

        string Name { get; set; }

        string ContactEmail { get; set; }

        ICustomFields Custom { get; set; }

        List<IAddress> Addresses { get; set; }

        List<string> ShippingAddressIds { get; set; }

        string DefaultShipingAddressId { get; set; }

        List<string> BillingAddressIds { get; set; }

        string DefaultBillingAddressId { get; set; }

        List<IAssociate> Associates { get; set; }

        IBusinessUnitKeyReference ParentUnit { get; set; }

        IBusinessUnitKeyReference TopLevelUnit { get; set; }

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
