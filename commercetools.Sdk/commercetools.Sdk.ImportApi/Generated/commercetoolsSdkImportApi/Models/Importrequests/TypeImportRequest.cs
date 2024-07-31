using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class TypeImportRequest : ITypeImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<ITypeImport> Resources { get; set; }

        public IEnumerable<ITypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public TypeImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("type");
        }
    }
}
