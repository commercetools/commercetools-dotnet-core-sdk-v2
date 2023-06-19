using commercetools.Sdk.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductsTaskStatus))]
    public partial interface ISimilarProductsTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime? Expires { get; set; }

        ISimilarProductsPagedQueryResult Result { get; set; }

    }
}
