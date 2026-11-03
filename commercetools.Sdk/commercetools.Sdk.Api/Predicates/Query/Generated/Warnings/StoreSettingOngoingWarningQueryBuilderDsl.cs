// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class StoreSettingOngoingWarningQueryBuilderDsl
    {
        public StoreSettingOngoingWarningQueryBuilderDsl()
        {
        }

        public static StoreSettingOngoingWarningQueryBuilderDsl Of()
        {
            return new StoreSettingOngoingWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSettingOngoingWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<StoreSettingOngoingWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<StoreSettingOngoingWarningQueryBuilderDsl>(p, StoreSettingOngoingWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSettingOngoingWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<StoreSettingOngoingWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<StoreSettingOngoingWarningQueryBuilderDsl>(p, StoreSettingOngoingWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
