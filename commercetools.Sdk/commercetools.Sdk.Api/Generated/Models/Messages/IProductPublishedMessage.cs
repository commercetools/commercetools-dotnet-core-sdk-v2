using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage))]
    public partial interface IProductPublishedMessage : IMessage
    {
        IList<string> RemovedImageUrls { get; set; }
        IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }


        IProductProjection ProductProjection { get; set; }

        IProductPublishScope Scope { get; set; }

    }
}
