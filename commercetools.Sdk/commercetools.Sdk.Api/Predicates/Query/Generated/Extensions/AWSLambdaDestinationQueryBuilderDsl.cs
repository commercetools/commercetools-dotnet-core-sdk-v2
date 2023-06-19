// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class AWSLambdaDestinationQueryBuilderDsl
    {
        public AWSLambdaDestinationQueryBuilderDsl()
        {
        }

        public static AWSLambdaDestinationQueryBuilderDsl Of()
        {
            return new AWSLambdaDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AWSLambdaDestinationQueryBuilderDsl>(p, AWSLambdaDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string> Arn()
        {
            return new ComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("arn")),
            p => new CombinationQueryPredicate<AWSLambdaDestinationQueryBuilderDsl>(p, AWSLambdaDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string> AccessKey()
        {
            return new ComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessKey")),
            p => new CombinationQueryPredicate<AWSLambdaDestinationQueryBuilderDsl>(p, AWSLambdaDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string> AccessSecret()
        {
            return new ComparisonPredicateBuilder<AWSLambdaDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessSecret")),
            p => new CombinationQueryPredicate<AWSLambdaDestinationQueryBuilderDsl>(p, AWSLambdaDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
