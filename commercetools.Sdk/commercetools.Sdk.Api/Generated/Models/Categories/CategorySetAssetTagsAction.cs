using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetTagsAction : ICategorySetAssetTagsAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public List<string> Tags { get; set; }
        public CategorySetAssetTagsAction()
        {
            this.Action = "setAssetTags";
        }
    }
}
