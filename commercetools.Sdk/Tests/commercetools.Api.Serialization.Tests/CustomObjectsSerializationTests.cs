using System.IO;
using System.Text.Json;
using commercetools.Api.Models.CustomObjects;
using commercetools.Base.Serialization;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class CustomObjectsSerializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public CustomObjectsSerializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }


        [Fact]
        public void SerializeCustomObjectDraft()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var customObjectDraft = new CustomObjectDraft
            {
                Key = "key1",
                Container = "container1",
                Value =  new CustomFooBar
                {
                    Foo = "Bar"
                },
                Version = 1
            };
            string result = serializerService.Serialize(customObjectDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/CustomObjects/FooBarCustomObject.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void CustomObjectDeserialize()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/CustomObjects/FooBarCustomObject.json");
            var customFooBarObject = serializerService.Deserialize<CustomObject>(serialized);
            Assert.NotNull(customFooBarObject);
            if (customFooBarObject.Value is JsonElement jsonElement)
            {
                var customFooBar = jsonElement.ToObject<CustomFooBar>(serializerService);
                Assert.NotNull(customFooBar);
                Assert.Equal("Bar", customFooBar.Foo);
            }
        }

    }

    public class CustomFooBar
    {
        public string Foo { get; set; }
    }
    
}