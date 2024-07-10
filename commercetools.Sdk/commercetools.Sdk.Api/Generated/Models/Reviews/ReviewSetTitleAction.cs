using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetTitleAction : IReviewSetTitleAction
    {
        public string Action { get; set; }

        public string Title { get; set; }
        public ReviewSetTitleAction()
        {
            this.Action = "setTitle";
        }
    }
}
