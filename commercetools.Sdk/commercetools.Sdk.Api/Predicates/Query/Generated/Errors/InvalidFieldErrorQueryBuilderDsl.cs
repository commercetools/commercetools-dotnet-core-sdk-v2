// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidFieldErrorQueryBuilderDsl
    {
        public InvalidFieldErrorQueryBuilderDsl()
        {
        }

        public static InvalidFieldErrorQueryBuilderDsl Of()
        {
            return new InvalidFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidFieldErrorQueryBuilderDsl>(p, InvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidFieldErrorQueryBuilderDsl>(p, InvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<InvalidFieldErrorQueryBuilderDsl>(p, InvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string> InvalidValue()
        {
            return new ComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidValue")),
            p => new CombinationQueryPredicate<InvalidFieldErrorQueryBuilderDsl>(p, InvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string> AllowedValues()
        {
            return new ComparisonPredicateBuilder<InvalidFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("allowedValues")),
            p => new CombinationQueryPredicate<InvalidFieldErrorQueryBuilderDsl>(p, InvalidFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
