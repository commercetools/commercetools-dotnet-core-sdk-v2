

namespace commercetools.Sdk.ImportApi.Models.Importsummaries
{

    public partial class ImportSummary : IImportSummary
    {
        public IOperationStates States { get; set; }

        public long Total { get; set; }
    }
}
