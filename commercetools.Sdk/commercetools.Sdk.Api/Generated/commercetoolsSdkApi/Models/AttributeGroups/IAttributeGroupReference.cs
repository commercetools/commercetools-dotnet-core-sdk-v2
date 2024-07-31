using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference))]
    public partial interface IAttributeGroupReference : IReference
    {
        IAttributeGroup Obj { get; set; }

        new string Id { get; set; }

    }
}
