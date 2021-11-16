using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditReference))]
    public partial interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set;}
    }
}
