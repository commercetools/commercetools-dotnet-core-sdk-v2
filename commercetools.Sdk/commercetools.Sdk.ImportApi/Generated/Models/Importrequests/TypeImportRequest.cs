using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
