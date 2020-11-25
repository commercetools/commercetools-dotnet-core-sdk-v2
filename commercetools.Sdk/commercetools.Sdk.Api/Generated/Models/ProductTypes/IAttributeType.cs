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
    [SubTypeDiscriminator("reference", typeof(commercetools.Api.Models.ProductTypes.AttributeReferenceType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Api.Models.ProductTypes.AttributeBooleanType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Api.Models.ProductTypes.AttributeEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Api.Models.ProductTypes.AttributeTimeType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Api.Models.ProductTypes.AttributeMoneyType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Api.Models.ProductTypes.AttributeTextType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Api.Models.ProductTypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Api.Models.ProductTypes.AttributeNumberType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Api.Models.ProductTypes.AttributeDateType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Api.Models.ProductTypes.AttributeDateTimeType))]
    public partial interface IAttributeType 
    {
        string Name { get; set;}
    }
}
