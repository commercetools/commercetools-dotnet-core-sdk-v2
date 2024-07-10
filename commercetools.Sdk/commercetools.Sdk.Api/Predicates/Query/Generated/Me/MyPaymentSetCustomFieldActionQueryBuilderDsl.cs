// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetCustomFieldActionQueryBuilderDsl
    {
        public MyPaymentSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyPaymentSetCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyPaymentSetCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
