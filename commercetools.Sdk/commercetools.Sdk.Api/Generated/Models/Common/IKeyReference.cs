using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.KeyReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreKeyReference))]
    public partial interface IKeyReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Key { get; set; }
    }
}
