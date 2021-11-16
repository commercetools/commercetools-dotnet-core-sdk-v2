using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsummaries.ImportSummary))]
    public partial interface IImportSummary
    {
        IOperationStates States { get; set; }

        long Total { get; set; }
    }
}
