using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{

    public partial class ImportContainerPagedResponse : IImportContainerPagedResponse
    {
        public int Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long Total { get; set; }

        public List<IImportContainer> Results { get; set; }
    }
}
