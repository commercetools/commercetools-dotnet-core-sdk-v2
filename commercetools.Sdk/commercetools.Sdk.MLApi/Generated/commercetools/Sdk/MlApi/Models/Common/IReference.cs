using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.MLApi.Models.Common.Reference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.MLApi.Models.Common.CategoryReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.MLApi.Models.Common.ProductReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.MLApi.Models.Common.ProductTypeReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        static commercetools.Sdk.MLApi.Models.Common.CategoryReference Category(Action<commercetools.Sdk.MLApi.Models.Common.CategoryReference> init = null)
        {
            var t = new commercetools.Sdk.MLApi.Models.Common.CategoryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.MLApi.Models.Common.ProductReference Product(Action<commercetools.Sdk.MLApi.Models.Common.ProductReference> init = null)
        {
            var t = new commercetools.Sdk.MLApi.Models.Common.ProductReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.MLApi.Models.Common.ProductTypeReference ProductType(Action<commercetools.Sdk.MLApi.Models.Common.ProductTypeReference> init = null)
        {
            var t = new commercetools.Sdk.MLApi.Models.Common.ProductTypeReference();
            init?.Invoke(t);
            return t;
        }
    }
}
