using commercetools.Sdk.ImportApi.Models.Categories;
using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    public partial class CategoryImportRequest : ICategoryImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<ICategoryImport> Resources { get; set; }
        public CategoryImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("category");
        }
    }
}
