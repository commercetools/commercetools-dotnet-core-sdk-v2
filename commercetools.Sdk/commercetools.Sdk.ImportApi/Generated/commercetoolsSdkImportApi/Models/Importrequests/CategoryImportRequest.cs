using commercetools.Sdk.ImportApi.Models.Categories;
using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class CategoryImportRequest : ICategoryImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<ICategoryImport> Resources { get; set; }

        public IEnumerable<ICategoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public CategoryImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("category");
        }
    }
}
