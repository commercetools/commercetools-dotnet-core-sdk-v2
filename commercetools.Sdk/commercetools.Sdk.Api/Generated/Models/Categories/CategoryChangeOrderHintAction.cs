using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeOrderHintAction : ICategoryChangeOrderHintAction
    {
        public string Action { get; set; }

        public string OrderHint { get; set; }
        public CategoryChangeOrderHintAction()
        {
            this.Action = "changeOrderHint";
        }
    }
}
