using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.AssociateRoleKeyReference))]
    public partial interface IAssociateRoleKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
