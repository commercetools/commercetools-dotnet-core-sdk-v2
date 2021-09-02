using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewSetLocaleAction : IReviewSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public ReviewSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
