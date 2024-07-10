using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest))]
    public partial interface ITypeImportRequest : IImportRequest
    {
        IList<ITypeImport> Resources { get; set; }
        IEnumerable<ITypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
