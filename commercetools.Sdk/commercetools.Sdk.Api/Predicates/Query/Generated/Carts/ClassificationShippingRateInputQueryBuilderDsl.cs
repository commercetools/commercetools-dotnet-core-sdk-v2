using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ClassificationShippingRateInputQueryBuilderDsl
    {
        public ClassificationShippingRateInputQueryBuilderDsl()
        {
        }

        public static ClassificationShippingRateInputQueryBuilderDsl Of()
        {
            return new ClassificationShippingRateInputQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ClassificationShippingRateInputQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ClassificationShippingRateInputQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ClassificationShippingRateInputQueryBuilderDsl>(p, ClassificationShippingRateInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ClassificationShippingRateInputQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ClassificationShippingRateInputQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ClassificationShippingRateInputQueryBuilderDsl>(p, ClassificationShippingRateInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ClassificationShippingRateInputQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ClassificationShippingRateInputQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ClassificationShippingRateInputQueryBuilderDsl.Of);
        }


    }
}
