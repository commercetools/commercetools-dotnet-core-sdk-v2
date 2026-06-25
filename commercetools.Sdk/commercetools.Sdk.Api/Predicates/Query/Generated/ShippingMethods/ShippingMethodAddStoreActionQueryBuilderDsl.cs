using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodAddStoreActionQueryBuilderDsl
    {
        public ShippingMethodAddStoreActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodAddStoreActionQueryBuilderDsl Of()
        {
            return new ShippingMethodAddStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodAddStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodAddStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodAddStoreActionQueryBuilderDsl>(p, ShippingMethodAddStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodAddStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodAddStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodAddStoreActionQueryBuilderDsl.Of);
        }


    }
}
