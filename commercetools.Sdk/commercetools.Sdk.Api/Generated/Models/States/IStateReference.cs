using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateReference))]
    public partial interface IStateReference : IReference
    {
        IState Obj { get; set; }

        new string Id { get; set; }

    }
}
