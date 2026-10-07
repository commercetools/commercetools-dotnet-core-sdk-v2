using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.RelativeAllocationDraft))]
    public partial interface IRelativeAllocationDraft : IAllocationDraft
    {
        int Percentage { get; set; }

    }
}
