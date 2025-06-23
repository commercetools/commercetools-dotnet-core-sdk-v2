using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupReference))]
    public partial interface IDiscountGroupReference : IReference
    {
        new string Id { get; set; }

        IDiscountGroup Obj { get; set; }

    }
}
