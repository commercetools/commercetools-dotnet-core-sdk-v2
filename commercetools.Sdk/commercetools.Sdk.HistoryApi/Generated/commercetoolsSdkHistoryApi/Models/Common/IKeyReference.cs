using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Common.KeyReference))]
    [SubTypeDiscriminator("associate-role", typeof(commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleKeyReference))]
    [SubTypeDiscriminator("business-unit", typeof(commercetools.Sdk.HistoryApi.Models.Common.BusinessUnitKeyReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.HistoryApi.Models.Common.StoreKeyReference))]
    public partial interface IKeyReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Key { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleKeyReference AssociateRole(Action<commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleKeyReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.BusinessUnitKeyReference BusinessUnit(Action<commercetools.Sdk.HistoryApi.Models.Common.BusinessUnitKeyReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.BusinessUnitKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.StoreKeyReference Store(Action<commercetools.Sdk.HistoryApi.Models.Common.StoreKeyReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.StoreKeyReference();
            init?.Invoke(t);
            return t;
        }
    }
}
