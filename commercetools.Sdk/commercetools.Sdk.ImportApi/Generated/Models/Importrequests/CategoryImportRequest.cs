using commercetools.ImportApi.Models.Categories;
using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
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
