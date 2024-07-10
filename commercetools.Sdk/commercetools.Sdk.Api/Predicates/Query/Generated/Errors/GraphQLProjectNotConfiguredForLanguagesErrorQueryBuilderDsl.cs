using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl
    {
        public GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl()
        {
        }

        public static GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl Of()
        {
            return new GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>(p, GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>(p, GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
