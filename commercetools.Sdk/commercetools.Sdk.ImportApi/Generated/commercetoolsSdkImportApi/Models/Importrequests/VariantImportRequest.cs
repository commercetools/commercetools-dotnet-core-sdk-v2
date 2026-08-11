using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Variants;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class VariantImportRequest : IVariantImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IVariantImport> Resources { get; set; }

        public IEnumerable<IVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public VariantImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("variant");
        }
    }
}
