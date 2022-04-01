using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Categories
{
    public partial class CategoryUpdate : ICategoryUpdate
    {
        public long Version { get; set; }

        public List<ICategoryUpdateAction> Actions { get; set; }
    }
}
