using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference))]
    public partial interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set; }

        new string Id { get; set; }

    }
}
