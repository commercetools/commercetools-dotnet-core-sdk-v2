using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantAddExternalImageActionQueryBuilderDsl
    {
        public VariantAddExternalImageActionQueryBuilderDsl()
        {
        }

        public static VariantAddExternalImageActionQueryBuilderDsl Of()
        {
            return new VariantAddExternalImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAddExternalImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantAddExternalImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantAddExternalImageActionQueryBuilderDsl>(p, VariantAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAddExternalImageActionQueryBuilderDsl> Image(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAddExternalImageActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("image"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantAddExternalImageActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantAddExternalImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantAddExternalImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantAddExternalImageActionQueryBuilderDsl>(p, VariantAddExternalImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
