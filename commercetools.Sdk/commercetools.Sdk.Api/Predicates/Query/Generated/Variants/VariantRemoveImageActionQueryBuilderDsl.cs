// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantRemoveImageActionQueryBuilderDsl
    {
        public VariantRemoveImageActionQueryBuilderDsl()
        {
        }

        public static VariantRemoveImageActionQueryBuilderDsl Of()
        {
            return new VariantRemoveImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantRemoveImageActionQueryBuilderDsl>(p, VariantRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<VariantRemoveImageActionQueryBuilderDsl>(p, VariantRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantRemoveImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantRemoveImageActionQueryBuilderDsl>(p, VariantRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
