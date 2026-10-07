using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.AbsoluteAllocationDraft))]
    public partial interface IAbsoluteAllocationDraft : IAllocationDraft
    {
        IHighPrecisionMoneyDraft Amount { get; set; }

    }
}
