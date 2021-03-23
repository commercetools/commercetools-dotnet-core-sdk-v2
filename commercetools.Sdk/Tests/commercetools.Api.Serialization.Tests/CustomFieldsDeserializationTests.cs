using System;
using System.Collections.Generic;
using System.IO;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Base;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class CustomFieldsDeserializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture _serializationFixture;

        public CustomFieldsDeserializationTests(SerializationFixture serializationFixture)
        {
            this._serializationFixture = serializationFixture;
        }
        
        [Fact]
        public void CustomFieldsList()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/CustomFields/List.json");
            var deserialized = serializerService.Deserialize<Category>(serialized);
            Assert.IsType<string>(deserialized.Custom.Fields["string"]);
            Assert.IsType<double>(deserialized.Custom.Fields["number"]);
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
            Assert.IsType<List<double>>(deserialized.Custom.Fields["set-double"]);
            Assert.IsType<List<double>>(deserialized.Custom.Fields["set-integer"]);
            Assert.IsType<List<LocalizedString>>(deserialized.Custom.Fields["set-ltext"]);
            Assert.IsType<List<IReference>>(deserialized.Custom.Fields["set-reference"]);
            Assert.IsType<List<ITypedMoney>>(deserialized.Custom.Fields["set-money"]);
            Assert.IsType<List<string>>(deserialized.Custom.Fields["set-text"]);
            
            var date = ((string) deserialized.Custom.Fields["date"]).AsDate();
            var dateTime = ((string) deserialized.Custom.Fields["date-time"]).AsDateTime();
            Assert.Equal(date, dateTime.Date);
            
        }
        
    }
}