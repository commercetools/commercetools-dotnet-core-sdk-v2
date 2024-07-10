using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.KeyReference))]
    [SubTypeDiscriminator("associate-role", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleKeyReference))]
    [SubTypeDiscriminator("business-unit", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitKeyReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.Api.Models.Stores.StoreKeyReference))]
    public partial interface IKeyReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Key { get; set; }

        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleKeyReference AssociateRole(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleKeyReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitKeyReference BusinessUnit(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitKeyReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreKeyReference Store(Action<commercetools.Sdk.Api.Models.Stores.StoreKeyReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreKeyReference();
            init?.Invoke(t);
            return t;
        }
    }
}
