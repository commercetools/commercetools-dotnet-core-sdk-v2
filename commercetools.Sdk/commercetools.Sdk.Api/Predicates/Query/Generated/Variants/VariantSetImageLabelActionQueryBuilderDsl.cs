// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetImageLabelActionQueryBuilderDsl
    {
        public VariantSetImageLabelActionQueryBuilderDsl()
        {
        }

        public static VariantSetImageLabelActionQueryBuilderDsl Of()
        {
            return new VariantSetImageLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetImageLabelActionQueryBuilderDsl>(p, VariantSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<VariantSetImageLabelActionQueryBuilderDsl>(p, VariantSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<VariantSetImageLabelActionQueryBuilderDsl>(p, VariantSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetImageLabelActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetImageLabelActionQueryBuilderDsl>(p, VariantSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
