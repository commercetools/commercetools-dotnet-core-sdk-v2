using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodRemoveStoreActionQueryBuilderDsl
    {
        public ShippingMethodRemoveStoreActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodRemoveStoreActionQueryBuilderDsl Of()
        {
            return new ShippingMethodRemoveStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodRemoveStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodRemoveStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodRemoveStoreActionQueryBuilderDsl>(p, ShippingMethodRemoveStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodRemoveStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodRemoveStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodRemoveStoreActionQueryBuilderDsl.Of);
        }


    }
}
