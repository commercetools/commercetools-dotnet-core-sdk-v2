using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.Review))]
    public partial interface IReview : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        string UniquenessValue { get; set; }

        string Locale { get; set; }

        string AuthorName { get; set; }

        string Title { get; set; }

        string Text { get; set; }

        Object Target { get; set; }

        bool IncludedInStatistics { get; set; }

        int? Rating { get; set; }

        IStateReference State { get; set; }

        ICustomerReference Customer { get; set; }

        ICustomFields Custom { get; set; }
    }
}
