using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using commercetools.Base;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class CustomFieldsTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture _serializationFixture;

        public CustomFieldsTests(SerializationFixture serializationFixture)
        {
            this._serializationFixture = serializationFixture;
        }
        
        [Fact]
        public void CustomFieldsListDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/CustomFields/List.json");
            var deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<string>(deserialized.Custom.Fields["string"]);
            Assert.IsType<long>(deserialized.Custom.Fields["integer"]);
            Assert.Equal(10L, deserialized.Custom.Fields["integer"]);
            Assert.IsType<double>(deserialized.Custom.Fields["double"]);
            Assert.Equal(11.0, deserialized.Custom.Fields["double"]);
            Assert.IsType<bool>(deserialized.Custom.Fields["boolean"]);
            Assert.IsType<string>(deserialized.Custom.Fields["date"]);
            Assert.IsType<string>(deserialized.Custom.Fields["date-time"]);
            Assert.IsType<string>(deserialized.Custom.Fields["time"]);
            Assert.IsType<string>(deserialized.Custom.Fields["enum"]);
            Assert.IsType<string>(deserialized.Custom.Fields["localized-enum"]);
            Assert.IsType<CategoryReference>(deserialized.Custom.Fields["reference"]);
            Assert.IsType<CentPrecisionMoney>(deserialized.Custom.Fields["money"]);
            Assert.IsType<LocalizedString>(deserialized.Custom.Fields["localized-string"]);
            
            Assert.IsType<List<Object>>(deserialized.Custom.Fields["set-empty"]);
            Assert.IsType<List<bool>>(deserialized.Custom.Fields["set-boolean"]);
            Assert.IsType<List<long>>(deserialized.Custom.Fields["set-integer"]);
            Assert.Equal(10, (deserialized.Custom.Fields["set-integer"] as List<long>).First());
            Assert.IsType<List<double>>(deserialized.Custom.Fields["set-double"]);
            Assert.Equal(11.0, (deserialized.Custom.Fields["set-double"] as List<Double>).First());
            Assert.IsType<List<LocalizedString>>(deserialized.Custom.Fields["set-ltext"]);
            Assert.IsType<List<IReference>>(deserialized.Custom.Fields["set-reference"]);
            Assert.IsType<List<ITypedMoney>>(deserialized.Custom.Fields["set-money"]);
            Assert.IsType<List<string>>(deserialized.Custom.Fields["set-text"]);
            
            var date = ((string) deserialized.Custom.Fields["date"]).AsDate();
            var dateTime = ((string) deserialized.Custom.Fields["date-time"]).AsDateTime();
            Assert.Equal(date, dateTime.Date);
            
        }
        [Fact]
        public void CustomFieldsSerialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var fieldContainer = new FieldContainer
            {
                {"int", 13}, {"double", 13.0m}, {"double2", 13.2}, {"double3", 13.0d}
            };
            var result = serializerService.Serialize(fieldContainer);
            var expectedResult = "{\"int\":13,\"double\":13.0,\"double2\":13.2,\"double3\":13}";
            Assert.Equal(expectedResult, result);
        }
    }
}