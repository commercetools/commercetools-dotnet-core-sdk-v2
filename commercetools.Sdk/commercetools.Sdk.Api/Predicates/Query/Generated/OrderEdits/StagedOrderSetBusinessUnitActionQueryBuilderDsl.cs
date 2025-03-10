using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetBusinessUnitActionQueryBuilderDsl
    {
        public StagedOrderSetBusinessUnitActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetBusinessUnitActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetBusinessUnitActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetBusinessUnitActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetBusinessUnitActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetBusinessUnitActionQueryBuilderDsl>(p, StagedOrderSetBusinessUnitActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetBusinessUnitActionQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetBusinessUnitActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetBusinessUnitActionQueryBuilderDsl.Of);
        }


    }
}
