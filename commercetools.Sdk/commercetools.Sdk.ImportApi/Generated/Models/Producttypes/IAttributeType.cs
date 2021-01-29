using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.ImportApi.Models.Producttypes.AttributeBooleanType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.ImportApi.Models.Producttypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("date", typeof(commercetools.ImportApi.Models.Producttypes.AttributeDateType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.ImportApi.Models.Producttypes.AttributeEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.ImportApi.Models.Producttypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.ImportApi.Models.Producttypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("money", typeof(commercetools.ImportApi.Models.Producttypes.AttributeMoneyType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.ImportApi.Models.Producttypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.ImportApi.Models.Producttypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.ImportApi.Models.Producttypes.AttributeReferenceType))]
    [SubTypeDiscriminator("set", typeof(commercetools.ImportApi.Models.Producttypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.ImportApi.Models.Producttypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.ImportApi.Models.Producttypes.AttributeTimeType))]
    public partial interface IAttributeType 
    {
        string Name { get; set;}
    }
}
