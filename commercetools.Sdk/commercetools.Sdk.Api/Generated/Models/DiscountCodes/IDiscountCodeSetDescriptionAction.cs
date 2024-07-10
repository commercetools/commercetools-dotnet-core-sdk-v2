using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    public partial interface IDiscountCodeSetDescriptionAction : IDiscountCodeUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
