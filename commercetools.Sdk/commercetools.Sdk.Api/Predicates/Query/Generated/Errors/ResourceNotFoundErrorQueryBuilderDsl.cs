using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ResourceNotFoundErrorQueryBuilderDsl
    {
        public ResourceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static ResourceNotFoundErrorQueryBuilderDsl Of()
        {
            return new ResourceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ResourceNotFoundErrorQueryBuilderDsl>(p, ResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ResourceNotFoundErrorQueryBuilderDsl>(p, ResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
