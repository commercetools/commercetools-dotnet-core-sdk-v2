using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests;

public class CustomFieldsTest
{

    [Fact]
    public void AsDecimalOrLong()
    {
        var fieldsStr = "{ \"number\": 91.62, \"numbers\": [91.62, 91.26, 91] }";
        IFieldContainer fields = JsonSerializer.Deserialize<FieldContainer>(fieldsStr);

        Assert.Equal(91.62m, fields.AsDecimal("number").Value);
        Assert.Equal(92, fields.AsLong("number").Value);
        Assert.Equal(91.62m, fields.AsSetDecimal("numbers")[0]);
        Assert.Equal(92, fields.AsSetLong("numbers")[0]);
        Assert.Equal(91.26m, fields.AsSetDecimal("numbers")[1]);
        Assert.Equal(91, fields.AsSetLong("numbers")[1]);
        Assert.Equal(91.0m, fields.AsSetDecimal("numbers")[2]);
        Assert.Equal(91, fields.AsSetLong("numbers")[2]);

    }

    [Fact]
    public void fields()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization();
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/customfields.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var custom = serializerService.Deserialize<ICustomFields>(projectResponse);

        //assert
        Assert.NotEmpty(custom.Fields);
        var fields = custom.Fields;
        Assert.IsType<string>(fields.AsString("text"));
        Assert.Equal("foo", fields.AsString("text"));
        Assert.IsType<LocalizedString>(fields.AsLocalizedString("ltext"));
        Assert.Equal("foo", fields.AsLocalizedString("ltext")["en"]);

        Assert.IsType<CustomFieldEnumValue>(fields.AsPlainEnum("enum"));
        Assert.Equal("foo", fields.AsPlainEnum("enum").Label);
        Assert.IsType<CustomFieldLocalizedEnumValue>(fields.AsLocalizedEnum("lenum"));
        Assert.Equal("foo", fields.AsLocalizedEnum("lenum").Label["en"]);

        Assert.IsType<string>(fields.AsString("date"));
        Assert.Equal("2020-01-01", fields.AsString("date"));
        Assert.IsType<string>(fields.AsString("date-text"));
        Assert.Equal("2020-01-01T", fields.AsString("date-text"));
        Assert.IsType<string>(fields.AsString("time"));
        Assert.Equal("13:15:00.123", fields.AsString("time"));
        Assert.IsType<string>(fields.AsString("time-simple"));
        Assert.Equal("13:15:00", fields.AsString("time-simple"));
        Assert.IsType<string>(fields.AsString("datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", fields.AsString("datetime"));
        Assert.IsType<string>(fields.AsString("datetime-simple"));
        Assert.Equal("2020-01-01T13:15:00Z", fields.AsString("datetime-simple"));
        Assert.IsType<string>(fields.AsString("datetime-text"));
        Assert.Equal("2020-01-01T13:15:00-0400", fields.AsString("datetime-text"));
        Assert.IsType<string>(fields.AsString("datetime-offset"));
        Assert.Equal("2020-01-01T13:15:00-04:00", fields.AsString("datetime-offset"));
        Assert.IsType<string>(fields.AsString("datetime-no-offset"));
        Assert.Equal("2020-01-01T13:15:00", fields.AsString("datetime-no-offset"));

        Assert.IsType<bool>(fields.AsBoolean("boolean"));
        Assert.True(fields.AsBoolean("boolean"));
        Assert.IsType<long>(fields.AsLong("integer"));
        Assert.Equal(10L, fields.AsLong("integer"));
        Assert.Equal(10.0m, fields.AsDecimal("integer"));
        Assert.IsType<decimal>(fields.AsDecimal("double"));
        Assert.Equal(11.0m, fields.AsDecimal("double"));
        Assert.Equal(11L, fields.AsLong("double"));

        Assert.IsType<ProductReference>(fields.AsReference("reference"));
        Assert.Equal("12345", fields.AsReference("reference").Id);
        Assert.IsType<TypedMoney>(fields.AsMoney("money"));
        Assert.Equal("EUR", fields.AsMoney("money").CurrencyCode);

        Assert.Null(fields.AsLong("null"));
        Assert.Null(fields.AsDecimal("null"));
    }

    [Fact]
    public void attributeSets()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsApiSerialization();
        var p = s.BuildServiceProvider();

        var projectResponse = File.ReadAllText("Resources/customfields.json");
        var serializerService = p.GetService<IApiSerializerService>();

        var custom = serializerService.Deserialize<ICustomFields>(projectResponse);

        //assert
        Assert.NotEmpty(custom.Fields);
        var fields = custom.Fields;
        Assert.IsType<List<string>>(fields.AsSetString("set-text"));
        Assert.Equal("foo", fields.AsSetString("set-text").First());
        Assert.IsType<List<LocalizedString>>(fields.AsSetLocalizedString("set-ltext"));
        Assert.Equal("foo", fields.AsSetLocalizedString("set-ltext").First()["en"]);

        Assert.IsType<List<ICustomFieldEnumValue>>(fields.AsSetPlainEnum("set-enum"));
        Assert.Equal("foo", fields.AsSetPlainEnum("set-enum").First().Label);
        Assert.IsType<List<ICustomFieldLocalizedEnumValue>>(fields.AsSetLocalizedEnum("set-lenum"));
        Assert.Equal("foo", fields.AsSetLocalizedEnum("set-lenum").First().Label["en"]);

        Assert.IsType<List<string>>(fields.AsSetString("set-date"));
        Assert.Equal("2020-01-01", fields.AsSetString("set-date").First());
        Assert.IsType<List<string>>(fields.AsSetString("set-time"));
        Assert.Equal("13:15:00.123", fields.AsSetString("set-time").First());
        Assert.IsType<List<string>>(fields.AsSetString("set-datetime"));
        Assert.Equal("2020-01-01T13:15:00.123Z", fields.AsSetString("set-datetime").First());

        Assert.IsType<List<bool>>(fields.AsSetBoolean("set-boolean"));
        Assert.True(fields.AsSetBoolean("set-boolean").First());
        Assert.IsType<List<long>>(fields.AsSetLong("set-integer"));
        Assert.Equal(10L, fields.AsSetLong("set-integer").First());
        Assert.Equal(10.0m, fields.AsSetDecimal("set-integer").First());
        Assert.IsType<List<decimal>>(fields.AsSetDecimal("set-double"));
        Assert.Equal(11.0m, fields.AsSetDecimal("set-double").First());
        Assert.Equal(11L, fields.AsSetLong("set-double").First());

        Assert.IsType<List<IReference>>(fields.AsSetReference("set-reference"));
        Assert.Equal("12345", fields.AsSetReference("set-reference").First().Id);
        Assert.IsType<List<ITypedMoney>>(fields.AsSetMoney("set-money"));
        Assert.Equal("EUR", fields.AsSetMoney("set-money").First().CurrencyCode);
    }
}