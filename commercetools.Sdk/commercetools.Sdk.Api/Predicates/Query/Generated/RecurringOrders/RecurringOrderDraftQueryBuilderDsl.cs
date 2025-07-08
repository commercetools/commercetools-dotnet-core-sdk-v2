using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderDraftQueryBuilderDsl
    {
        public RecurringOrderDraftQueryBuilderDsl()
        {
        }

        public static RecurringOrderDraftQueryBuilderDsl Of()
        {
            return new RecurringOrderDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(p, RecurringOrderDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                RecurringOrderDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, long> CartVersion()
        {
            return new ComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartVersion")),
            p => new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(p, RecurringOrderDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, DateTime> StartsAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("startsAt")),
            p => new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(p, RecurringOrderDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                RecurringOrderDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                RecurringOrderDraftQueryBuilderDsl.Of);
        }


    }
}
