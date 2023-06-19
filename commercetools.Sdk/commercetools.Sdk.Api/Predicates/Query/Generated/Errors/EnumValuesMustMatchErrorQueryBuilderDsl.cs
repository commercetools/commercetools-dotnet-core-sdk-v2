// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class EnumValuesMustMatchErrorQueryBuilderDsl
    {
        public EnumValuesMustMatchErrorQueryBuilderDsl()
        {
        }

        public static EnumValuesMustMatchErrorQueryBuilderDsl Of()
        {
            return new EnumValuesMustMatchErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EnumValuesMustMatchErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<EnumValuesMustMatchErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<EnumValuesMustMatchErrorQueryBuilderDsl>(p, EnumValuesMustMatchErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumValuesMustMatchErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<EnumValuesMustMatchErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<EnumValuesMustMatchErrorQueryBuilderDsl>(p, EnumValuesMustMatchErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
