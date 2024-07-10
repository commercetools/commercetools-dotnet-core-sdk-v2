using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload))]
    public partial interface ICategoryCreatedMessagePayload : IMessagePayload
    {
        ICategory Category { get; set; }

    }
}
