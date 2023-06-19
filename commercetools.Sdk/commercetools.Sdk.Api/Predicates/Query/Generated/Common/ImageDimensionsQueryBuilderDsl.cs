// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class ImageDimensionsQueryBuilderDsl
    {
        public ImageDimensionsQueryBuilderDsl()
        {
        }

        public static ImageDimensionsQueryBuilderDsl Of()
        {
            return new ImageDimensionsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImageDimensionsQueryBuilderDsl, long> W()
        {
            return new ComparisonPredicateBuilder<ImageDimensionsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("w")),
            p => new CombinationQueryPredicate<ImageDimensionsQueryBuilderDsl>(p, ImageDimensionsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImageDimensionsQueryBuilderDsl, long> H()
        {
            return new ComparisonPredicateBuilder<ImageDimensionsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("h")),
            p => new CombinationQueryPredicate<ImageDimensionsQueryBuilderDsl>(p, ImageDimensionsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
