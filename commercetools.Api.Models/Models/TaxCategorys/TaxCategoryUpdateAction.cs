using commercetools.Api.Models.TaxCategorys;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryAddTaxRateAction), "addTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryRemoveTaxRateAction), "removeTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryReplaceTaxRateAction), "replaceTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategorySetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategorySetKeyAction), "setKey")]
    public abstract class TaxCategoryUpdateAction 
    {
        public string Action { get; set;}
    }
}
