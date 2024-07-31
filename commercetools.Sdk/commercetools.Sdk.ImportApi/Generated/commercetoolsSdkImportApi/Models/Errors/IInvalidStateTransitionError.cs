using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError))]
    public partial interface IInvalidStateTransitionError : IErrorObject
    {
        IProcessingState CurrentState { get; set; }

        IProcessingState NewState { get; set; }

    }
}
