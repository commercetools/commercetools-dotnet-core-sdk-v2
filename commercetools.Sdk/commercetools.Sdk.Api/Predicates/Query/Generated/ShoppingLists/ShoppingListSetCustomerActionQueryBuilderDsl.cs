using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetCustomerActionQueryBuilderDsl
    {
        public ShoppingListSetCustomerActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetCustomerActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetCustomerActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetCustomerActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetCustomerActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetCustomerActionQueryBuilderDsl>(p, ShoppingListSetCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetCustomerActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetCustomerActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListSetCustomerActionQueryBuilderDsl.Of);
        }


    }
}
