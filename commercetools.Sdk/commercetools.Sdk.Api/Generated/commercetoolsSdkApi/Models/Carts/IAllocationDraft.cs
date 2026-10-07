using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.AllocationDraft))]
    [SubTypeDiscriminator("Absolute", typeof(commercetools.Sdk.Api.Models.Carts.AbsoluteAllocationDraft))]
    [SubTypeDiscriminator("Relative", typeof(commercetools.Sdk.Api.Models.Carts.RelativeAllocationDraft))]
    public partial interface IAllocationDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Carts.AbsoluteAllocationDraft Absolute(Action<commercetools.Sdk.Api.Models.Carts.AbsoluteAllocationDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.AbsoluteAllocationDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.RelativeAllocationDraft Relative(Action<commercetools.Sdk.Api.Models.Carts.RelativeAllocationDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.RelativeAllocationDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
