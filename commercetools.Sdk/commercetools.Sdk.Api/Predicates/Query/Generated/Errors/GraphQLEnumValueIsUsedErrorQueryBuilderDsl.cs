using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLEnumValueIsUsedErrorQueryBuilderDsl
    {
        public GraphQLEnumValueIsUsedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLEnumValueIsUsedErrorQueryBuilderDsl Of()
        {
            return new GraphQLEnumValueIsUsedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLEnumValueIsUsedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLEnumValueIsUsedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLEnumValueIsUsedErrorQueryBuilderDsl>(p, GraphQLEnumValueIsUsedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
