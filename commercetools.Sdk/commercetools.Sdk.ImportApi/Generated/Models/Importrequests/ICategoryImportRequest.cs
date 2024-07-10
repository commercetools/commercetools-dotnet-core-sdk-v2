using commercetools.Sdk.ImportApi.Models.Categories;
using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest))]
    public partial interface ICategoryImportRequest : IImportRequest
    {
        IList<ICategoryImport> Resources { get; set; }
        IEnumerable<ICategoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
