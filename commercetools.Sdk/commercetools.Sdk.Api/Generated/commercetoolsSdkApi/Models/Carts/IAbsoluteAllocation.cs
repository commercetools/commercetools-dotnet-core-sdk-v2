using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.AbsoluteAllocation))]
    public partial interface IAbsoluteAllocation : IAllocation
    {
        IHighPrecisionMoney Amount { get; set; }

    }
}
