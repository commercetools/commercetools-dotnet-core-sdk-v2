using System.Collections.Generic;
using System.IO;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class FieldTypeDeserializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public FieldTypeDeserializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void DeserializeStringFieldType()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/FieldTypes/String.json");
            Type deserialized = serializerService.Deserialize<Type>(serialized);
            Assert.NotNull(deserialized.ResourceTypeIdsAsEnum);
            Assert.Equal(2,deserialized.ResourceTypeIdsAsEnum.Count);
            Assert.Equal(ResourceTypeId.Category, deserialized.ResourceTypeIdsAsEnum[0]);
            Assert.Equal(ResourceTypeId.CustomLineItem, deserialized.ResourceTypeIdsAsEnum[1]);
            Assert.IsType<CustomFieldStringType>(deserialized.FieldDefinitions[0].Type);
        }

        [Fact]
        public void SerializeStringFieldType()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            TypeDraft typeDraft = new TypeDraft
            {
                Key = "new-key",
                ResourceTypeIds = new List<string>
                {
                    ResourceTypeId.Category.GetDescription(), 
                    ResourceTypeId.CustomLineItem.GetDescription()
                }
            };
            FieldDefinition fieldDefinition = new FieldDefinition();
            fieldDefinition.Name = "string-field";
            fieldDefinition.Required = true;
            fieldDefinition.Label = new LocalizedString
            {
                {"en", "string description"}
            };
            fieldDefinition.InputHint = TextInputHint.SingleLine.GetDescription();
            fieldDefinition.Type = new CustomFieldStringType();
            typeDraft.FieldDefinitions = new List<FieldDefinition>
            {
                fieldDefinition
            };
            string result = serializerService.Serialize(typeDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/FieldTypes/Serialized.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void SerializeCustomField()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var customFieldsDraft = new CustomFieldsDraft() {
                Fields = new FieldContainer
                {
                    {"foo", "bar"},
                    {"Fooz", "Bars"},
                    {"Bar", new CustomFieldEnumValue { Key = "BarKey", Label = "BarLabel"} }
                }
            };
            string result1 = serializerService.Serialize(customFieldsDraft);

            JToken resultFormatted = JValue.Parse(result1);
            string serialized = File.ReadAllText("Resources/CustomFields/CustomFieldsDraft.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);

            var draft = new FieldContainer
            {
                {"foo", "bar"},
                {"Fooz", "Bars"},
                {"Bar", new CustomFieldEnumValue { Key = "BarKey", Label = "BarLabel"} }
            };

            string result2 = serializerService.Serialize(draft);

            resultFormatted = JValue.Parse(result2);
            serialized = File.ReadAllText("Resources/CustomFields/Fields.json");
            serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

    }
}