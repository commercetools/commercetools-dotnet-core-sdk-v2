using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl
    {
        public GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl()
        {
        }

        public static GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl Of()
        {
            return new GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl> ConflictingStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingStandalonePrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl.Of())),
                GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidFrom")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidUntil")),
            p => new CombinationQueryPredicate<GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
