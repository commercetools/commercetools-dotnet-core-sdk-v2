using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetKeyAction))]
    public partial interface IDiscountGroupSetKeyAction : IDiscountGroupUpdateAction
    {
        string Key { get; set; }

    }
}
