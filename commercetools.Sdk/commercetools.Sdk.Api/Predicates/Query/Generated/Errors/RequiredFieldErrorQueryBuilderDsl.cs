// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class RequiredFieldErrorQueryBuilderDsl
    {
        public RequiredFieldErrorQueryBuilderDsl()
        {
        }

        public static RequiredFieldErrorQueryBuilderDsl Of()
        {
            return new RequiredFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<RequiredFieldErrorQueryBuilderDsl>(p, RequiredFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<RequiredFieldErrorQueryBuilderDsl>(p, RequiredFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<RequiredFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<RequiredFieldErrorQueryBuilderDsl>(p, RequiredFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
