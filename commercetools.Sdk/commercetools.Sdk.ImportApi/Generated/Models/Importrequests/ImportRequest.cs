using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ImportRequest : IImportRequest
    {
        public IImportResourceType Type { get; set;}
    }
}
