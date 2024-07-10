using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ResourceSizeLimitExceededErrorQueryBuilderDsl
    {
        public ResourceSizeLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static ResourceSizeLimitExceededErrorQueryBuilderDsl Of()
        {
            return new ResourceSizeLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceSizeLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ResourceSizeLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ResourceSizeLimitExceededErrorQueryBuilderDsl>(p, ResourceSizeLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceSizeLimitExceededErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ResourceSizeLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ResourceSizeLimitExceededErrorQueryBuilderDsl>(p, ResourceSizeLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
