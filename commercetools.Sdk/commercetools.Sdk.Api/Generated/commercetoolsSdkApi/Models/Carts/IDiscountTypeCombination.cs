using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.DiscountTypeCombination))]
    [SubTypeDiscriminator("BestDeal", typeof(commercetools.Sdk.Api.Models.Carts.BestDeal))]
    [SubTypeDiscriminator("Stacking", typeof(commercetools.Sdk.Api.Models.Carts.Stacking))]
    public partial interface IDiscountTypeCombination
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Carts.BestDeal BestDeal(Action<commercetools.Sdk.Api.Models.Carts.BestDeal> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.BestDeal();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.Stacking Stacking(Action<commercetools.Sdk.Api.Models.Carts.Stacking> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.Stacking();
            init?.Invoke(t);
            return t;
        }
    }
}
