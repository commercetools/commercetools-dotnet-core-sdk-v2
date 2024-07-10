using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewDraft : IReviewDraft
    {
        public string Key { get; set; }

        public string UniquenessValue { get; set; }

        public string Locale { get; set; }

        public string AuthorName { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public Object Target { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public int? Rating { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
