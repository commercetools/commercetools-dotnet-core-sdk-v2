using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetBusinessUnitActionQueryBuilderDsl
    {
        public CartSetBusinessUnitActionQueryBuilderDsl()
        {
        }

        public static CartSetBusinessUnitActionQueryBuilderDsl Of()
        {
            return new CartSetBusinessUnitActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetBusinessUnitActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetBusinessUnitActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetBusinessUnitActionQueryBuilderDsl>(p, CartSetBusinessUnitActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetBusinessUnitActionQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetBusinessUnitActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                CartSetBusinessUnitActionQueryBuilderDsl.Of);
        }


    }
}
