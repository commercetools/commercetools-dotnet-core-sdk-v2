using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [SubTypeDiscriminator("category", typeof(commercetools.Ml.Models.Common.CategoryReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Ml.Models.Common.ProductReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Ml.Models.Common.ProductTypeReference))]
    public partial interface IReference 
    {
        IReferenceTypeId TypeId { get; set;}
        
        string Id { get; set;}
    }
}
