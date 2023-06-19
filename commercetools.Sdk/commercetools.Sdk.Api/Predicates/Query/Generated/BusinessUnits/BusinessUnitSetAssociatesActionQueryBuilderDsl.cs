using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetAssociatesActionQueryBuilderDsl
    {
        public BusinessUnitSetAssociatesActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetAssociatesActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetAssociatesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetAssociatesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetAssociatesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetAssociatesActionQueryBuilderDsl>(p, BusinessUnitSetAssociatesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetAssociatesActionQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetAssociatesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                BusinessUnitSetAssociatesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitSetAssociatesActionQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<BusinessUnitSetAssociatesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<BusinessUnitSetAssociatesActionQueryBuilderDsl>(p, BusinessUnitSetAssociatesActionQueryBuilderDsl.Of));
        }

    }
}
