using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl
    {
        public GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl()
        {
        }

        public static GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl Of()
        {
            return new GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string> StoreCountries()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeCountries")),
            p => new CombinationQueryPredicate<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl>(p, GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
