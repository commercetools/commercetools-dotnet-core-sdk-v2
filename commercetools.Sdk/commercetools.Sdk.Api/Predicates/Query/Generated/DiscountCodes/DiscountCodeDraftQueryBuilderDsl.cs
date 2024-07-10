using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeDraftQueryBuilderDsl
    {
        public DiscountCodeDraftQueryBuilderDsl()
        {
        }

        public static DiscountCodeDraftQueryBuilderDsl Of()
        {
            return new DiscountCodeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountCodeDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountCodeDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl> CartDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cartDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl.Of())),
                DiscountCodeDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodeDraftQueryBuilderDsl> CartDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountCodeDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartDiscounts")),
                    p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, long> MaxApplications()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplications")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, long> MaxApplicationsPerCustomer()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplicationsPerCustomer")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                DiscountCodeDraftQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string> Groups()
        {
            return new ComparableCollectionPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("groups")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DiscountCodeDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DiscountCodeDraftQueryBuilderDsl>(p, DiscountCodeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
