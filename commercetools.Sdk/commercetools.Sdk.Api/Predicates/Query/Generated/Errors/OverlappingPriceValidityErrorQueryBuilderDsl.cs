using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class OverlappingPriceValidityErrorQueryBuilderDsl
    {
        public OverlappingPriceValidityErrorQueryBuilderDsl()
        {
        }

        public static OverlappingPriceValidityErrorQueryBuilderDsl Of()
        {
            return new OverlappingPriceValidityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string> ConflictingPrice()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingPrice")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                OverlappingPriceValidityErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                OverlappingPriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidFrom()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidFrom")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidUntil()
        {
            return new ComparisonPredicateBuilder<OverlappingPriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidUntil")),
            p => new CombinationQueryPredicate<OverlappingPriceValidityErrorQueryBuilderDsl>(p, OverlappingPriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
