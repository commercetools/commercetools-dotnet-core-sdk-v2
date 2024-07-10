using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ItemShippingDetailsDraftQueryBuilderDsl
    {
        public ItemShippingDetailsDraftQueryBuilderDsl()
        {
        }

        public static ItemShippingDetailsDraftQueryBuilderDsl Of()
        {
            return new ItemShippingDetailsDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ItemShippingDetailsDraftQueryBuilderDsl> Targets(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ItemShippingDetailsDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl.Of())),
                ItemShippingDetailsDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ItemShippingDetailsDraftQueryBuilderDsl> Targets()
        {
            return new CollectionPredicateBuilder<ItemShippingDetailsDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targets")),
                    p => new CombinationQueryPredicate<ItemShippingDetailsDraftQueryBuilderDsl>(p, ItemShippingDetailsDraftQueryBuilderDsl.Of));
        }

    }
}
