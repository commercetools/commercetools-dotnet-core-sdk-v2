using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference))]
    public partial interface IDiscountCodeReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IDiscountCode Obj { get; set; }

        new string Id { get; set; }

    }
}
