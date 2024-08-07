using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNestedType))]
    public partial interface IAttributeNestedType : IAttributeType
    {
        IProductTypeKeyReference TypeReference { get; set; }

    }
}
