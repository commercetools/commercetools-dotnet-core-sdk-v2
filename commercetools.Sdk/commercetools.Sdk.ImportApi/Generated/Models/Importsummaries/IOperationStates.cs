using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsummaries.OperationStates))]
    public partial interface IOperationStates
    {
        long Processing { get; set; }

        long ValidationFailed { get; set; }

        long Unresolved { get; set; }

        long WaitForMasterVariant { get; set; }

        long Imported { get; set; }

        long Rejected { get; set; }

    }
}
