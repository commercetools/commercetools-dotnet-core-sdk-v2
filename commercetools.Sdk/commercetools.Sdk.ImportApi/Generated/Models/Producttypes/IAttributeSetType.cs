using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeSetType))]
    public partial interface IAttributeSetType : IAttributeType
    {
        IAttributeType ElementType { get; set; }

    }
}
