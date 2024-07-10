using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeReferenceQueryBuilderDsl
    {
        public DiscountCodeReferenceQueryBuilderDsl()
        {
        }

        public static DiscountCodeReferenceQueryBuilderDsl Of()
        {
            return new DiscountCodeReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<DiscountCodeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<DiscountCodeReferenceQueryBuilderDsl>(p, DiscountCodeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountCodeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountCodeReferenceQueryBuilderDsl>(p, DiscountCodeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl.Of())),
                DiscountCodeReferenceQueryBuilderDsl.Of);
        }


    }
}
