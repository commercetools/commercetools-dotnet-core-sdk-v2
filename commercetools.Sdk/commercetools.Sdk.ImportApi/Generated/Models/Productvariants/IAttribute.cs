using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.ImportApi.Models.Productvariants.BooleanAttribute))]
    [SubTypeDiscriminator("boolean-set", typeof(commercetools.ImportApi.Models.Productvariants.BooleanSetAttribute))]
    [SubTypeDiscriminator("date", typeof(commercetools.ImportApi.Models.Productvariants.DateAttribute))]
    [SubTypeDiscriminator("date-set", typeof(commercetools.ImportApi.Models.Productvariants.DateSetAttribute))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.ImportApi.Models.Productvariants.DateTimeAttribute))]
    [SubTypeDiscriminator("datetime-set", typeof(commercetools.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    [SubTypeDiscriminator("enum", typeof(commercetools.ImportApi.Models.Productvariants.EnumAttribute))]
    [SubTypeDiscriminator("enum-set", typeof(commercetools.ImportApi.Models.Productvariants.EnumSetAttribute))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.ImportApi.Models.Productvariants.LocalizableEnumAttribute))]
    [SubTypeDiscriminator("lenum-set", typeof(commercetools.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.ImportApi.Models.Productvariants.LocalizableTextAttribute))]
    [SubTypeDiscriminator("ltext-set", typeof(commercetools.ImportApi.Models.Productvariants.LocalizableTextSetAttribute))]
    [SubTypeDiscriminator("money", typeof(commercetools.ImportApi.Models.Productvariants.MoneyAttribute))]
    [SubTypeDiscriminator("money-set", typeof(commercetools.ImportApi.Models.Productvariants.MoneySetAttribute))]
    [SubTypeDiscriminator("number", typeof(commercetools.ImportApi.Models.Productvariants.NumberAttribute))]
    [SubTypeDiscriminator("number-set", typeof(commercetools.ImportApi.Models.Productvariants.NumberSetAttribute))]
    [SubTypeDiscriminator("reference", typeof(commercetools.ImportApi.Models.Productvariants.ReferenceAttribute))]
    [SubTypeDiscriminator("reference-set", typeof(commercetools.ImportApi.Models.Productvariants.ReferenceSetAttribute))]
    [SubTypeDiscriminator("text", typeof(commercetools.ImportApi.Models.Productvariants.TextAttribute))]
    [SubTypeDiscriminator("text-set", typeof(commercetools.ImportApi.Models.Productvariants.TextSetAttribute))]
    [SubTypeDiscriminator("time", typeof(commercetools.ImportApi.Models.Productvariants.TimeAttribute))]
    [SubTypeDiscriminator("time-set", typeof(commercetools.ImportApi.Models.Productvariants.TimeSetAttribute))]
    public partial interface IAttribute 
    {
        string Name { get; set;}
        
        string Type { get; set;}
    }
}
