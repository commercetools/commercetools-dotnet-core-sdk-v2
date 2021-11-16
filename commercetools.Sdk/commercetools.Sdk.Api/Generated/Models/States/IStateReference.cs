using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateReference))]
    public partial interface IStateReference : IReference
    {
        IState Obj { get; set;}
    }
}
