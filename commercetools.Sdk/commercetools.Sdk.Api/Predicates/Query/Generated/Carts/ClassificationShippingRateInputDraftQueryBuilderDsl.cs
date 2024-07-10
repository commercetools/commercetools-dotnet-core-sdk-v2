// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ClassificationShippingRateInputDraftQueryBuilderDsl
    {
        public ClassificationShippingRateInputDraftQueryBuilderDsl()
        {
        }

        public static ClassificationShippingRateInputDraftQueryBuilderDsl Of()
        {
            return new ClassificationShippingRateInputDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ClassificationShippingRateInputDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ClassificationShippingRateInputDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ClassificationShippingRateInputDraftQueryBuilderDsl>(p, ClassificationShippingRateInputDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ClassificationShippingRateInputDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ClassificationShippingRateInputDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ClassificationShippingRateInputDraftQueryBuilderDsl>(p, ClassificationShippingRateInputDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
