using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    public partial class ImportRequest : IImportRequest
    {
        public IImportResourceType Type { get; set; }
    }
}
