using System.IO;
using System.Linq;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests;

public class AttributesTest
{
    [Fact]
    public void attributes()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization();
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/attributes.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var variant = serializerService.Deserialize<ProductVariant>(projectResponse);

        //assert
        Assert.NotEmpty(variant.Attributes);
        var attributes = variant.Attributes;
        Assert.IsType<StringAttribute>(attributes.Get("text"));
        Assert.Equal("foo", attributes.Get("text").ToStringAttribute().GetValue());
        Assert.IsType<LocalizedStringAttribute>(attributes.Get("ltext"));
        Assert.Equal("foo", attributes.Get("ltext").ToLocalizedStringAttribute().GetValue()["en"]);

        Assert.IsType<PlainEnumAttribute>(attributes.Get("enum"));
        Assert.Equal("foo", attributes.Get("enum").ToPlainEnumAttribute().GetValue().Label);
        Assert.IsType<LocalizedEnumAttribute>(attributes.Get("lenum"));
        Assert.Equal("foo", attributes.Get("lenum").ToLocalizedEnumAttribute().GetValue().Label["en"]);

        Assert.IsType<StringAttribute>(attributes.Get("date"));
        Assert.Equal("2020-01-01", attributes.Get("date").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("date-text"));
        Assert.Equal("2020-01-01T", attributes.Get("date-text").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("time"));
        Assert.Equal("13:15:00.123", attributes.Get("time").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("time-simple"));
        Assert.Equal("13:15:00", attributes.Get("time-simple").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", attributes.Get("datetime").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-simple"));
        Assert.Equal("2020-01-01T13:15:00Z", attributes.Get("datetime-simple").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-text"));
        Assert.Equal("2018-09-24T00:00:00-0400", attributes.Get("datetime-text").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-offset"));
        Assert.Equal("2018-09-24T00:00:00-04:00", attributes.Get("datetime-offset").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-no-offset"));
        Assert.Equal("2018-09-24T00:00:00", attributes.Get("datetime-no-offset").ToStringAttribute().GetValue());

        Assert.IsType<BooleanAttribute>(attributes.Get("boolean"));
        Assert.True(attributes.Get("boolean").ToBooleanAttribute().GetValue());
        Assert.IsType<LongAttribute>(attributes.Get("integer"));
        Assert.Equal(10L, attributes.Get("integer").ToLongAttribute().GetValue());
        Assert.Equal(10.0m, attributes.Get("integer").ToDecimalAttribute().GetValue());
        Assert.IsType<DecimalAttribute>(attributes.Get("double"));
        Assert.Equal(11.0m, attributes.Get("double").ToDecimalAttribute().GetValue());
        Assert.Equal(11L, attributes.Get("double").ToLongAttribute().GetValue());

        Assert.IsType<ReferenceAttribute>(attributes.Get("reference"));
        Assert.Equal("12345", attributes.Get("reference").ToReferenceAttribute().GetValue().Id);
        Assert.IsType<MoneyAttribute>(attributes.Get("money"));
        Assert.Equal("EUR", attributes.Get("money").ToMoneyAttribute().GetValue().CurrencyCode);
    }

    [Fact]
    public void attributeSets()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization();
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/attributes.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var variant = serializerService.Deserialize<ProductVariant>(projectResponse);

        //assert
        Assert.NotEmpty(variant.Attributes);
        var attributes = variant.Attributes;
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-text"));
        Assert.Equal("foo", attributes.Get("set-text").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<LocalizedString>>(attributes.Get("set-ltext"));
        Assert.Equal("foo", attributes.Get("set-ltext").ToSetLocalizedStringAttribute().GetValue().First()["en"]);

        Assert.IsType<SetAttribute<IAttributePlainEnumValue>>(attributes.Get("set-enum"));
        Assert.Equal("foo", attributes.Get("set-enum").ToSetPlainEnumAttribute().GetValue().First().Label);
        Assert.IsType<SetAttribute<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum"));
        Assert.Equal("foo", attributes.Get("set-lenum").ToSetLocalizedEnumAttribute().GetValue().First().Label["en"]);

        Assert.IsType<SetAttribute<string>>(attributes.Get("set-date"));
        Assert.Equal("2020-01-01", attributes.Get("set-date").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-time"));
        Assert.Equal("13:15:00.123", attributes.Get("set-time").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", attributes.Get("set-datetime").ToSetStringAttribute().GetValue().First());

        Assert.IsType<SetAttribute<bool>>(attributes.Get("set-boolean"));
        Assert.True(attributes.Get("set-boolean").ToSetBooleanAttribute().GetValue().First());
        Assert.IsType<SetAttribute<long>>(attributes.Get("set-integer"));
        Assert.Equal(10L, attributes.Get("set-integer").ToSetLongAttribute().GetValue().First());
        Assert.Equal(10.0m, attributes.Get("set-integer").ToSetDecimalAttribute().GetValue().First());
        Assert.IsType<SetAttribute<decimal>>(attributes.Get("set-double"));
        Assert.Equal(11.0m, attributes.Get("set-double").ToSetDecimalAttribute().GetValue().First());
        Assert.Equal(11L, attributes.Get("set-double").ToSetLongAttribute().GetValue().First());

        Assert.IsType<SetAttribute<IReference>>(attributes.Get("set-reference"));
        Assert.Equal("12345", attributes.Get("set-reference").ToSetReferenceAttribute().GetValue().First().Id);
        Assert.IsType<SetAttribute<ITypedMoney>>(attributes.Get("set-money"));
        Assert.Equal("EUR", attributes.Get("set-money").ToSetMoneyAttribute().GetValue().First().CurrencyCode);
    }

    [Fact]
    public void attributesAsDouble()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization(new SerializationConfiguration()
        {
            DeserializeNumberAttributeAsDecimalOnly = true
        });
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/attributes.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var variant = serializerService.Deserialize<ProductVariant>(projectResponse);

        //assert
        Assert.NotEmpty(variant.Attributes);
        var attributes = variant.Attributes;
        Assert.IsType<StringAttribute>(attributes.Get("text"));
        Assert.Equal("foo", attributes.Get("text").ToStringAttribute().GetValue());
        Assert.IsType<LocalizedStringAttribute>(attributes.Get("ltext"));
        Assert.Equal("foo", attributes.Get("ltext").ToLocalizedStringAttribute().GetValue()["en"]);

        Assert.IsType<PlainEnumAttribute>(attributes.Get("enum"));
        Assert.Equal("foo", attributes.Get("enum").ToPlainEnumAttribute().GetValue().Label);
        Assert.IsType<LocalizedEnumAttribute>(attributes.Get("lenum"));
        Assert.Equal("foo", attributes.Get("lenum").ToLocalizedEnumAttribute().GetValue().Label["en"]);

        Assert.IsType<StringAttribute>(attributes.Get("date"));
        Assert.Equal("2020-01-01", attributes.Get("date").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("date-text"));
        Assert.Equal("2020-01-01T", attributes.Get("date-text").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("time"));
        Assert.Equal("13:15:00.123", attributes.Get("time").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("time-simple"));
        Assert.Equal("13:15:00", attributes.Get("time-simple").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", attributes.Get("datetime").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-simple"));
        Assert.Equal("2020-01-01T13:15:00Z", attributes.Get("datetime-simple").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-text"));
        Assert.Equal("2018-09-24T00:00:00-0400", attributes.Get("datetime-text").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-offset"));
        Assert.Equal("2018-09-24T00:00:00-04:00", attributes.Get("datetime-offset").ToStringAttribute().GetValue());
        Assert.IsType<StringAttribute>(attributes.Get("datetime-no-offset"));
        Assert.Equal("2018-09-24T00:00:00", attributes.Get("datetime-no-offset").ToStringAttribute().GetValue());

        Assert.IsType<BooleanAttribute>(attributes.Get("boolean"));
        Assert.True(attributes.Get("boolean").ToBooleanAttribute().GetValue());
        Assert.IsType<DecimalAttribute>(attributes.Get("integer"));
        Assert.Equal(10.0m, attributes.Get("integer").ToDecimalAttribute().GetValue());
        Assert.Equal(10L, attributes.Get("integer").ToLongAttribute().GetValue());
        Assert.IsType<DecimalAttribute>(attributes.Get("double"));
        Assert.Equal(11.0m, attributes.Get("double").ToDecimalAttribute().GetValue());
        Assert.Equal(11L, attributes.Get("double").ToLongAttribute().GetValue());

        Assert.IsType<ReferenceAttribute>(attributes.Get("reference"));
        Assert.Equal("12345", attributes.Get("reference").ToReferenceAttribute().GetValue().Id);
        Assert.IsType<MoneyAttribute>(attributes.Get("money"));
        Assert.Equal("EUR", attributes.Get("money").ToMoneyAttribute().GetValue().CurrencyCode);
    }

    [Fact]
    public void attributeSetsAsDecimal()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization(new SerializationConfiguration()
        {
            DeserializeNumberAttributeAsDecimalOnly = true
        });
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/attributes.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var variant = serializerService.Deserialize<ProductVariant>(projectResponse);

        //assert
        Assert.NotEmpty(variant.Attributes);
        var attributes = variant.Attributes;
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-text"));
        Assert.Equal("foo", attributes.Get("set-text").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<LocalizedString>>(attributes.Get("set-ltext"));
        Assert.Equal("foo", attributes.Get("set-ltext").ToSetLocalizedStringAttribute().GetValue().First()["en"]);

        Assert.IsType<SetAttribute<IAttributePlainEnumValue>>(attributes.Get("set-enum"));
        Assert.Equal("foo", attributes.Get("set-enum").ToSetPlainEnumAttribute().GetValue().First().Label);
        Assert.IsType<SetAttribute<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum"));
        Assert.Equal("foo", attributes.Get("set-lenum").ToSetLocalizedEnumAttribute().GetValue().First().Label["en"]);

        Assert.IsType<SetAttribute<string>>(attributes.Get("set-date"));
        Assert.Equal("2020-01-01", attributes.Get("set-date").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-time"));
        Assert.Equal("13:15:00.123", attributes.Get("set-time").ToSetStringAttribute().GetValue().First());
        Assert.IsType<SetAttribute<string>>(attributes.Get("set-datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", attributes.Get("set-datetime").ToSetStringAttribute().GetValue().First());

        Assert.IsType<SetAttribute<bool>>(attributes.Get("set-boolean"));
        Assert.True(attributes.Get("set-boolean").ToSetBooleanAttribute().GetValue().First());
        Assert.IsType<SetAttribute<decimal>>(attributes.Get("set-integer"));
        Assert.Equal(10m, attributes.Get("set-integer").ToSetDecimalAttribute().GetValue().First());
        Assert.Equal(10L, attributes.Get("set-integer").ToSetLongAttribute().GetValue().First());
        Assert.IsType<SetAttribute<decimal>>(attributes.Get("set-double"));
        Assert.Equal(11.0m, attributes.Get("set-double").ToSetDecimalAttribute().GetValue().First());
        Assert.Equal(11L, attributes.Get("set-double").ToSetLongAttribute().GetValue().First());

        Assert.IsType<SetAttribute<IReference>>(attributes.Get("set-reference"));
        Assert.Equal("12345", attributes.Get("set-reference").ToSetReferenceAttribute().GetValue().First().Id);
        Assert.IsType<SetAttribute<ITypedMoney>>(attributes.Get("set-money"));
        Assert.Equal("EUR", attributes.Get("set-money").ToSetMoneyAttribute().GetValue().First().CurrencyCode);
    }
}