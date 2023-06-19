using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetLineItemShippingDetailsActionQueryBuilderDsl
    {
        public MyCartSetLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static MyCartSetLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new MyCartSetLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl>(p, MyCartSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl>(p, MyCartSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                MyCartSetLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
