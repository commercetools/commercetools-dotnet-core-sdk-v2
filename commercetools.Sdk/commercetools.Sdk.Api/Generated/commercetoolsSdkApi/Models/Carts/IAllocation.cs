using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.Allocation))]
    [SubTypeDiscriminator("Absolute", typeof(commercetools.Sdk.Api.Models.Carts.AbsoluteAllocation))]
    [SubTypeDiscriminator("Relative", typeof(commercetools.Sdk.Api.Models.Carts.RelativeAllocation))]
    public partial interface IAllocation
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Carts.AbsoluteAllocation Absolute(Action<commercetools.Sdk.Api.Models.Carts.AbsoluteAllocation> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.AbsoluteAllocation();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.RelativeAllocation Relative(Action<commercetools.Sdk.Api.Models.Carts.RelativeAllocation> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.RelativeAllocation();
            init?.Invoke(t);
            return t;
        }
    }
}
