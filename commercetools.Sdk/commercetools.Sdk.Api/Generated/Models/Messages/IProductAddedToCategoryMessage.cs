using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductAddedToCategoryMessage))]
    public partial interface IProductAddedToCategoryMessage : IMessage
    {
        ICategoryReference Category { get; set; }

        bool Staged { get; set; }
    }
}
