using System.ComponentModel;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public enum PredicateOperator
    {
        [Description("=")]
        IsEqual,
        [Description("!=")]
        IsNotEqual,
        [Description("<>")]
        IsNot,
        [Description("<")]
        IsLessThan,
        [Description("<=")]
        IsLessThanOrEqual,
        [Description(">")]
        IsGreaterThan,
        [Description(">=")]
        IsGreaterThanOrEqual,
        [Description("in")]
        IsIn,

        [Description("is")]
        Is,

        [Description("contains")]
        Contains,
        [Description("within")]
        Within
        
    }
}