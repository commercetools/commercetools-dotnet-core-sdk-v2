using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Api.Models.ProductTypes.AttributeNestedType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Api.Models.ProductTypes.AttributeTimeType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Api.Models.ProductTypes.AttributeBooleanType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Api.Models.ProductTypes.AttributeNumberType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Api.Models.ProductTypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("set", typeof(commercetools.Api.Models.ProductTypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Api.Models.ProductTypes.AttributeTextType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Api.Models.ProductTypes.AttributeEnumType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Api.Models.ProductTypes.AttributeDateType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Api.Models.ProductTypes.AttributeMoneyType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Api.Models.ProductTypes.AttributeReferenceType))]
    public partial interface IAttributeType 
    {
        string Name { get; set;}
    }
}
