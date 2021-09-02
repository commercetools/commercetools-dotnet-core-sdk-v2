using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.GraphQl;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Projects;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Models.Importsummaries;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;
using JsonException = System.Text.Json.JsonException;

namespace commercetools.Api.Serialization.Tests
{
    public class ImportApiDeserializationTests : IClassFixture<ImportApiSerializationFixture>
    {
        private readonly ImportApiSerializationFixture serializationFixture;

        public ImportApiDeserializationTests(ImportApiSerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }
        
        // [Fact]
        public void TestOperationStatesDeserialization()
        {
            //arrange
            var response = File.ReadAllText("Resources/ImportApi/OperationStates.json");
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            //act
            var operationStates = serializerService.Deserialize<IOperationStates>(response);

            //assert
            Assert.NotNull(operationStates);
            Assert.Equal(10,operationStates.Imported);
            Assert.Equal(3,operationStates.Rejected);
            Assert.Equal(4,operationStates.WaitForMasterVariant);
            Assert.Equal(2,operationStates.Unresolved);
            Assert.Equal(1,operationStates.ValidationFailed);
        }
        

    }
}