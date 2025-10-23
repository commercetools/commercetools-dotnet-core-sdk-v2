using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleKeyReference))]
    public partial interface IAssociateRoleKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
