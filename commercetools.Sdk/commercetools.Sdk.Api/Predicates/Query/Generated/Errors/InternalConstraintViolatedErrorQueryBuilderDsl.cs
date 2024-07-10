// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InternalConstraintViolatedErrorQueryBuilderDsl
    {
        public InternalConstraintViolatedErrorQueryBuilderDsl()
        {
        }

        public static InternalConstraintViolatedErrorQueryBuilderDsl Of()
        {
            return new InternalConstraintViolatedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InternalConstraintViolatedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InternalConstraintViolatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InternalConstraintViolatedErrorQueryBuilderDsl>(p, InternalConstraintViolatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InternalConstraintViolatedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InternalConstraintViolatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InternalConstraintViolatedErrorQueryBuilderDsl>(p, InternalConstraintViolatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
