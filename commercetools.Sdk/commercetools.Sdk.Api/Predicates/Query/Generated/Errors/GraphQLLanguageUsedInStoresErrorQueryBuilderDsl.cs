using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLLanguageUsedInStoresErrorQueryBuilderDsl
    {
        public GraphQLLanguageUsedInStoresErrorQueryBuilderDsl()
        {
        }

        public static GraphQLLanguageUsedInStoresErrorQueryBuilderDsl Of()
        {
            return new GraphQLLanguageUsedInStoresErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLLanguageUsedInStoresErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLLanguageUsedInStoresErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLLanguageUsedInStoresErrorQueryBuilderDsl>(p, GraphQLLanguageUsedInStoresErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
