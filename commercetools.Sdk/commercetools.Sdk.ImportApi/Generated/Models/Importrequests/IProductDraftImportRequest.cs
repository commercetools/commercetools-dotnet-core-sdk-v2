using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Productdrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    public partial interface IProductDraftImportRequest : IImportRequest
    {
        IList<IProductDraftImport> Resources { get; set; }
        IEnumerable<IProductDraftImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
