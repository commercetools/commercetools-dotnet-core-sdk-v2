using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateStandalonePriceScopeErrorQueryBuilderDsl
    {
        public DuplicateStandalonePriceScopeErrorQueryBuilderDsl()
        {
        }

        public static DuplicateStandalonePriceScopeErrorQueryBuilderDsl Of()
        {
            return new DuplicateStandalonePriceScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl> ConflictingStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingStandalonePrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl.Of())),
                DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DuplicateStandalonePriceScopeErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DuplicateStandalonePriceScopeErrorQueryBuilderDsl>(p, DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
