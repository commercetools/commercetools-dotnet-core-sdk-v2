using System;
using commercetools.Sdk.ImportApi.Models.DiscountCodes;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests;

public class DiscountCodeTests
{
    [Fact]
    public void Test_Serialize_Date()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsImportApiSerialization();

        var p = s.BuildServiceProvider();
        var serializerService = p.GetService<IImportSerializerService>();

        var discountCodeImport = new DiscountCodeImport
        {
            ValidFrom = DateTime.Parse("2026-01-01T12:00:00.230+01:00"),
            ValidUntil = DateTime.Parse("2026-01-31T12:00:00+00:00"),
        };
        var t = serializerService.Serialize(discountCodeImport);

        Assert.Equal("{\"isActive\":false,\"validFrom\":\"2026-01-01T11:00:00.23Z\",\"validUntil\":\"2026-01-31T12:00:00Z\"}", t);
    }
}