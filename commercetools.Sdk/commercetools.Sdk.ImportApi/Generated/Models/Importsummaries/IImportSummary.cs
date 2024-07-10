using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsummaries.ImportSummary))]
    public partial interface IImportSummary
    {
        IOperationStates States { get; set; }

        long Total { get; set; }

    }
}
