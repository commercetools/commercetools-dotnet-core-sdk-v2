using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.Reviews
{
    public partial class Review : IReview
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string UniquenessValue { get; set; }

        public string Locale { get; set; }

        public string AuthorName { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public Object Target { get; set; }

        public bool IncludedInStatistics { get; set; }

        public int? Rating { get; set; }

        public IStateReference State { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
