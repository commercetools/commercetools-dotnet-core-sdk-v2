using commercetools.Base.Models;
using commercetools.Sdk.ImportApi.Models.Customers;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests;

public class CustomerTests
{
    [Fact]
    public void Test_Serialize_Date()
    {
        var s = new ServiceCollection();
        s.UseCommercetoolsImportApiSerialization();

        var p = s.BuildServiceProvider();
        var serializerService = p.GetService<IImportSerializerService>();

        var customerImport = new CustomerImport()
        {
            DateOfBirth = new Date(1980, 01, 01),
        };

        var t = serializerService.Serialize(customerImport);

        Assert.Equal("{\"dateOfBirth\":\"1980-01-01\"}", t);
    }
}