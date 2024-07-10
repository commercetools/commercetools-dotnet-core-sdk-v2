using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewTransitionStateAction : IReviewTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public ReviewTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
