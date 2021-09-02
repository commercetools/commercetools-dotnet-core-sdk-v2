using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewReference : IReviewReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IReview Obj { get; set; }
        public ReviewReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("review");
        }
    }
}
