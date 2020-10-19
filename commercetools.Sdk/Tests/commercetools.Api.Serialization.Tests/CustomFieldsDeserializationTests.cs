using System.IO;
using commercetools.Api.Models.Categories;
using commercetools.Base.Serialization;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class CustomFieldsDeserializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public CustomFieldsDeserializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void CustomFieldsString()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomFields/String.json");
            Category deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<string>(deserialized.Custom.Fields["string"]);
        }

        [Fact]
        public void CustomFieldsNumber()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomFields/Number.json");
            Category deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<double>(deserialized.Custom.Fields["number"]);
        }
/*
        [Fact]
        public void CustomFieldsEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomFields/Enum.json");
            Category deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<CustomFieldEnumValue>(deserialized.Custom.Fields["enum"]);
        }

        [Fact]
        public void CustomFieldsSetEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomFields/SetEnum.json");
            Category deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<FieldSet<EnumValue>>(deserialized.Custom.Fields["enum"]);
        }

        [Fact]
        public void CustomFieldsList()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomFields/List.json");
            Category deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.Equal(3, deserialized.Custom.Fields.Count);
        }
        */
    }
}