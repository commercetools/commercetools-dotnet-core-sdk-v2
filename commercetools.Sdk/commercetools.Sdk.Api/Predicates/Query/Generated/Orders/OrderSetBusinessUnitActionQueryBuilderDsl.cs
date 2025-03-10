using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetBusinessUnitActionQueryBuilderDsl
    {
        public OrderSetBusinessUnitActionQueryBuilderDsl()
        {
        }

        public static OrderSetBusinessUnitActionQueryBuilderDsl Of()
        {
            return new OrderSetBusinessUnitActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetBusinessUnitActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetBusinessUnitActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetBusinessUnitActionQueryBuilderDsl>(p, OrderSetBusinessUnitActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetBusinessUnitActionQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetBusinessUnitActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetBusinessUnitActionQueryBuilderDsl.Of);
        }


    }
}
