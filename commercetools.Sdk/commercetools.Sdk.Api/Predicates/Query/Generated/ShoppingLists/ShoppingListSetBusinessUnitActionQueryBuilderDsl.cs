using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetBusinessUnitActionQueryBuilderDsl
    {
        public ShoppingListSetBusinessUnitActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetBusinessUnitActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetBusinessUnitActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetBusinessUnitActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetBusinessUnitActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetBusinessUnitActionQueryBuilderDsl>(p, ShoppingListSetBusinessUnitActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetBusinessUnitActionQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetBusinessUnitActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListSetBusinessUnitActionQueryBuilderDsl.Of);
        }


    }
}
