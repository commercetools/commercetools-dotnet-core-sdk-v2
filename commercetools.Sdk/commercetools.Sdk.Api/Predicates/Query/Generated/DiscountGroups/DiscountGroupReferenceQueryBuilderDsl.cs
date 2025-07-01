using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupReferenceQueryBuilderDsl
    {
        public DiscountGroupReferenceQueryBuilderDsl()
        {
        }

        public static DiscountGroupReferenceQueryBuilderDsl Of()
        {
            return new DiscountGroupReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<DiscountGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<DiscountGroupReferenceQueryBuilderDsl>(p, DiscountGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountGroupReferenceQueryBuilderDsl>(p, DiscountGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl.Of())),
                DiscountGroupReferenceQueryBuilderDsl.Of);
        }


    }
}
