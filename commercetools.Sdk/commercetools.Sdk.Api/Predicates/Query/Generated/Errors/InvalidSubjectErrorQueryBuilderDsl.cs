// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidSubjectErrorQueryBuilderDsl
    {
        public InvalidSubjectErrorQueryBuilderDsl()
        {
        }

        public static InvalidSubjectErrorQueryBuilderDsl Of()
        {
            return new InvalidSubjectErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidSubjectErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidSubjectErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidSubjectErrorQueryBuilderDsl>(p, InvalidSubjectErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidSubjectErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidSubjectErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidSubjectErrorQueryBuilderDsl>(p, InvalidSubjectErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
