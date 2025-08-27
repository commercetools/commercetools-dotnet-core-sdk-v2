using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetIsActiveAction))]
    public partial interface IDiscountGroupSetIsActiveAction : IDiscountGroupUpdateAction
    {
        bool IsActive { get; set; }

    }
}
