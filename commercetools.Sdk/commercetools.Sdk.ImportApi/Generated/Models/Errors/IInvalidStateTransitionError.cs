using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidStateTransitionError))]
    public partial interface IInvalidStateTransitionError : IErrorObject
    {
        IProcessingState CurrentState { get; set; }

        IProcessingState NewState { get; set; }
    }
}
