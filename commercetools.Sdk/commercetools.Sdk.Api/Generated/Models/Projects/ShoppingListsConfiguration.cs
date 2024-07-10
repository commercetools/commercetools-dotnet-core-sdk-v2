using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ShoppingListsConfiguration : IShoppingListsConfiguration
    {
        public long? DeleteDaysAfterLastModification { get; set; }
    }
}
