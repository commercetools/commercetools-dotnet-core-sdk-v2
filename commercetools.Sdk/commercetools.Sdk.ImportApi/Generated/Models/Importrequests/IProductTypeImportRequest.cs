using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    public partial interface IProductTypeImportRequest : IImportRequest
    {
        IList<IProductTypeImport> Resources { get; set; }
        IEnumerable<IProductTypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
