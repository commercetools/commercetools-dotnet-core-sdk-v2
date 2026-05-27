using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateReference))]
    public partial interface IStateReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IState Obj { get; set; }

        new string Id { get; set; }

    }
}
