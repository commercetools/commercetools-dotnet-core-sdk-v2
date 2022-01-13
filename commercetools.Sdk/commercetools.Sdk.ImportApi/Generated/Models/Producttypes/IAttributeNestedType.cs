using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeNestedType))]
    public partial interface IAttributeNestedType : IAttributeType
    {
        IProductTypeKeyReference TypeReference { get; set; }
    }
}
