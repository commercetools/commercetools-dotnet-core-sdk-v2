using commercetools.Sdk.ImportApi.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest))]
    public partial interface ITypeImportRequest : IImportRequest
    {
        IList<ITypeImport> Resources { get; set; }
        IEnumerable<ITypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
