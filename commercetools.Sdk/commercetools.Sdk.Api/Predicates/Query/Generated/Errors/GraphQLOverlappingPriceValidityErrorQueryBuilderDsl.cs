using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLOverlappingPriceValidityErrorQueryBuilderDsl
    {
        public GraphQLOverlappingPriceValidityErrorQueryBuilderDsl()
        {
        }

        public static GraphQLOverlappingPriceValidityErrorQueryBuilderDsl Of()
        {
            return new GraphQLOverlappingPriceValidityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string> ConflictingPrice()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingPrice")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidFrom")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidUntil")),
            p => new CombinationQueryPredicate<GraphQLOverlappingPriceValidityErrorQueryBuilderDsl>(p, GraphQLOverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
