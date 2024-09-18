// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class ImageProcessingOngoingWarningQueryBuilderDsl
    {
        public ImageProcessingOngoingWarningQueryBuilderDsl()
        {
        }

        public static ImageProcessingOngoingWarningQueryBuilderDsl Of()
        {
            return new ImageProcessingOngoingWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImageProcessingOngoingWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ImageProcessingOngoingWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ImageProcessingOngoingWarningQueryBuilderDsl>(p, ImageProcessingOngoingWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImageProcessingOngoingWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ImageProcessingOngoingWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ImageProcessingOngoingWarningQueryBuilderDsl>(p, ImageProcessingOngoingWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
