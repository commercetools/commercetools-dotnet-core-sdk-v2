using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("set", typeof(commercetools.Api.Models.ProductTypes.AttributeSetType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Api.Models.ProductTypes.AttributeBooleanType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Api.Models.ProductTypes.AttributeNestedType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Api.Models.ProductTypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Api.Models.ProductTypes.AttributeEnumType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Api.Models.ProductTypes.AttributeDateType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Api.Models.ProductTypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Api.Models.ProductTypes.AttributeTimeType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Api.Models.ProductTypes.AttributeMoneyType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Api.Models.ProductTypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Api.Models.ProductTypes.AttributeReferenceType))]
    public interface IAttributeType 
    {
        string Name { get; set;}
    }
}
