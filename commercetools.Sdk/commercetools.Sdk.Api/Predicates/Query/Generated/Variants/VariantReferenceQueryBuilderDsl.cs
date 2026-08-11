using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantReferenceQueryBuilderDsl
    {
        public VariantReferenceQueryBuilderDsl()
        {
        }

        public static VariantReferenceQueryBuilderDsl Of()
        {
            return new VariantReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<VariantReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<VariantReferenceQueryBuilderDsl>(p, VariantReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantReferenceQueryBuilderDsl>(p, VariantReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl.Of())),
                VariantReferenceQueryBuilderDsl.Of);
        }


    }
}
