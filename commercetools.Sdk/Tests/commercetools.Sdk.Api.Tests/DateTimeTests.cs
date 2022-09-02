using System;
using System.IO;
using commercetools.Base.Models;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Projects;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class DateTimeTests
    {
        private SerializerService getSerializerService()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            var serializerService = p.GetService<SerializerService>();
            return serializerService;
        }
        
        
        [Fact]
        public void DeserializeProjectDates()
        {
            var projectResponse = File.ReadAllText("Resources/project.json");
            var serializerService = getSerializerService();

            var project = serializerService.Deserialize<Project>(projectResponse);

            Assert.Equal(new DateTime(2019,1,9,10,41,27,308, DateTimeKind.Utc), project.CreatedAt);

            var d = new Project()
            {
                CreatedAt = project.CreatedAt
            };
            var serialized = serializerService.Serialize(d);
            Assert.Equal("{\"version\":0,\"createdAt\":\"2019-01-09T10:41:27.308Z\"}", serialized);
        }

        [Fact]
        public void CustomerBirthday()
        {
            var serializerService = getSerializerService();
            var c = "{\"dateOfBirth\": \"2019-02-01\"}";

            var customer = serializerService.Deserialize<Customer>(c);
            
            Assert.IsType<Date>(customer.DateOfBirth);
            
            Assert.True(customer.DateOfBirth == new DateTime(2019, 2, 1));

            customer.DateOfBirth = DateTime.Today.ToDate();
            Assert.Equal(Date.Today, customer.DateOfBirth);

            customer.DateOfBirth = new DateTime(2019, 2, 1).ToDate();
            DateTime d = customer.DateOfBirth.Value;
            Assert.Equal(new DateTime(2019, 2, 1), d);
        }
    }
}