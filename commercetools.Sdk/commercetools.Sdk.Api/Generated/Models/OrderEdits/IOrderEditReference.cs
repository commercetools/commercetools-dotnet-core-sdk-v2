using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference))]
    public partial interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set; }

        new string Id { get; set; }
    }
}
