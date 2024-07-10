// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class EnumValueIsUsedErrorQueryBuilderDsl
    {
        public EnumValueIsUsedErrorQueryBuilderDsl()
        {
        }

        public static EnumValueIsUsedErrorQueryBuilderDsl Of()
        {
            return new EnumValueIsUsedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EnumValueIsUsedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<EnumValueIsUsedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<EnumValueIsUsedErrorQueryBuilderDsl>(p, EnumValueIsUsedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumValueIsUsedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<EnumValueIsUsedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<EnumValueIsUsedErrorQueryBuilderDsl>(p, EnumValueIsUsedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
