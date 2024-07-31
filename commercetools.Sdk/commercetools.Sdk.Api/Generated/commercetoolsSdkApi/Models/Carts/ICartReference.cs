using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartReference))]
    public partial interface ICartReference : IReference
    {
        ICart Obj { get; set; }

        new string Id { get; set; }

    }
}
