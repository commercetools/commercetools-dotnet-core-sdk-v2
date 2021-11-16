using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeSetType))]
    public partial interface IAttributeSetType : IAttributeType
    {
        IAttributeType ElementType { get; set; }
    }
}
