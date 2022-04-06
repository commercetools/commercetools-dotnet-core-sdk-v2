using System.IO;
using System.Linq;
using commercetools.Sdk.ImportApi.Models.Importoperations;
using commercetools.Sdk.ImportApi.Models.Importsummaries;
using Xunit;
using Attribute = commercetools.Sdk.ImportApi.Models.Productvariants.Attribute;
using DuplicateAttributeValueError = commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError;

namespace commercetools.Api.Serialization.Tests
{
    public class ImportApiDeserializationTests : IClassFixture<ImportApiSerializationFixture>
    {
        private readonly ImportApiSerializationFixture serializationFixture;

        public ImportApiDeserializationTests(ImportApiSerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void TestOperationStatesDeserialization()
        {
            //arrange
            var response = File.ReadAllText("Resources/ImportApi/OperationStates.json");
            var serializerService = this.serializationFixture.SerializerService;

            //act
            var operationStates = serializerService.Deserialize<IOperationStates>(response);

            //assert
            Assert.NotNull(operationStates);
            Assert.Equal(8, operationStates.Processing);
            Assert.Equal(10, operationStates.Imported);
            Assert.Equal(3, operationStates.Rejected);
            Assert.Equal(4, operationStates.WaitForMasterVariant);
            Assert.Equal(2, operationStates.Unresolved);
            Assert.Equal(1, operationStates.ValidationFailed);
        }

        [Fact]
        public void TestImportOperationDeserialization()
        {
            //arrange
            var response = File.ReadAllText("Resources/ImportApi/ImportOperation.json");
            var serializerService = this.serializationFixture.SerializerService;

            //act
            var importOperation = serializerService.Deserialize<IImportOperation>(response);

            //assert
            Assert.NotNull(importOperation);
            Assert.Single(importOperation.Errors);
            var error = importOperation.Errors.FirstOrDefault() as DuplicateAttributeValueError;
            Assert.NotNull(error);
            Assert.NotNull(error.Attribute);
            Assert.IsType<Attribute>(error.Attribute);//default attribute
        }


    }
}