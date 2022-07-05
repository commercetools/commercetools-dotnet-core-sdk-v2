using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{

    public partial class ImportOperationPagedResponse : IImportOperationPagedResponse
    {
        public int Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long Total { get; set; }

        public List<IImportOperation> Results { get; set; }
    }
}
