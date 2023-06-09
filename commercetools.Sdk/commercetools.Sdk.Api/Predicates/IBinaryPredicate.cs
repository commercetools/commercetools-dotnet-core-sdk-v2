namespace commercetools.Sdk.Api.Predicates
{
    public interface IBinaryPredicate<out T>: IPredicate where T: IPredicate 
    {
        public T Left();

        public T Right();

        public string Operator();
    }
}