using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupResourceIdentifier))]
    public partial interface IDiscountGroupResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
