using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetNameAction))]
    public partial interface IDiscountGroupSetNameAction : IDiscountGroupUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
