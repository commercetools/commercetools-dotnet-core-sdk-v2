using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObjectReference))]
    public partial interface ICustomObjectReference : IReference
    {
        ICustomObject Obj { get; set; }
    }
}
