using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetTagsAction : ICategorySetAssetTagsAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<string> Tags { get; set; }
        public IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }

        public CategorySetAssetTagsAction()
        {
            this.Action = "setAssetTags";
        }
    }
}
