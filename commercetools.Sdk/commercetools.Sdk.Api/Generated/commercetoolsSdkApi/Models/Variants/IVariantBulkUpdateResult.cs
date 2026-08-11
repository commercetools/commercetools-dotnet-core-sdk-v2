using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [TypeDiscriminator(nameof(Status))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateResult))]
    [SubTypeDiscriminator("Fail", typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateFailResult))]
    [SubTypeDiscriminator("Success", typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateSuccessResult))]
    public partial interface IVariantBulkUpdateResult
    {
        string Id { get; set; }

        string Key { get; set; }

        string Status { get; set; }

        static commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateFailResult Fail(Action<commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateFailResult> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateFailResult();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateSuccessResult Success(Action<commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateSuccessResult> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateSuccessResult();
            init?.Invoke(t);
            return t;
        }
    }
}
