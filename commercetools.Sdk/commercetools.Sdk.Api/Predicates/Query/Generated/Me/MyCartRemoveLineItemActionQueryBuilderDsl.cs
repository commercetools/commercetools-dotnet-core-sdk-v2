using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartRemoveLineItemActionQueryBuilderDsl
    {
        public MyCartRemoveLineItemActionQueryBuilderDsl()
        {
        }

        public static MyCartRemoveLineItemActionQueryBuilderDsl Of()
        {
            return new MyCartRemoveLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(p, MyCartRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(p, MyCartRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(p, MyCartRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(p, MyCartRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl> ExternalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                MyCartRemoveLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                MyCartRemoveLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl> ShippingDetailsToRemove(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartRemoveLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetailsToRemove"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                MyCartRemoveLineItemActionQueryBuilderDsl.Of);
        }


    }
}
