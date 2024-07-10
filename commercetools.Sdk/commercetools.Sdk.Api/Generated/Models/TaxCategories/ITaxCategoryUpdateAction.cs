using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdateAction))]
    [SubTypeDiscriminator("addTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction))]
    [SubTypeDiscriminator("removeTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    [SubTypeDiscriminator("replaceTaxRate", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategoryUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction AddTaxRate(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction RemoveTaxRate(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction ReplaceTaxRate(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction();
            init?.Invoke(t);
            return t;
        }
    }
}
