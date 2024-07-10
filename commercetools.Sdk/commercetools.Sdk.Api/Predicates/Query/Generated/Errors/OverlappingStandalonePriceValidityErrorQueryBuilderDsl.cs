using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class OverlappingStandalonePriceValidityErrorQueryBuilderDsl
    {
        public OverlappingStandalonePriceValidityErrorQueryBuilderDsl()
        {
        }

        public static OverlappingStandalonePriceValidityErrorQueryBuilderDsl Of()
        {
            return new OverlappingStandalonePriceValidityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl> ConflictingStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingStandalonePrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl.Of())),
                OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidFrom()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidFrom")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime> ConflictingValidUntil()
        {
            return new ComparisonPredicateBuilder<OverlappingStandalonePriceValidityErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingValidUntil")),
            p => new CombinationQueryPredicate<OverlappingStandalonePriceValidityErrorQueryBuilderDsl>(p, OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
