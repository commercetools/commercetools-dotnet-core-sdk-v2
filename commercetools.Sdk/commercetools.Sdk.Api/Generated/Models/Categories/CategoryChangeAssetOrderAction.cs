using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryChangeAssetOrderAction : ICategoryChangeAssetOrderAction
    {
        public string Action { get; set; }

        public List<string> AssetOrder { get; set; }
        public CategoryChangeAssetOrderAction()
        {
            this.Action = "changeAssetOrder";
        }
    }
}
