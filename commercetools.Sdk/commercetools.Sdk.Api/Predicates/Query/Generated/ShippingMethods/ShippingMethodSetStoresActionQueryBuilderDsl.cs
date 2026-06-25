using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetStoresActionQueryBuilderDsl
    {
        public ShippingMethodSetStoresActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetStoresActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetStoresActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetStoresActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetStoresActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetStoresActionQueryBuilderDsl>(p, ShippingMethodSetStoresActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodSetStoresActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodSetStoresActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodSetStoresActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingMethodSetStoresActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<ShippingMethodSetStoresActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<ShippingMethodSetStoresActionQueryBuilderDsl>(p, ShippingMethodSetStoresActionQueryBuilderDsl.Of));
        }

    }
}
