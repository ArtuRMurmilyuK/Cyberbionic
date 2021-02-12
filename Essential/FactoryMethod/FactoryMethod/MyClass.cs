namespace FactoryMethod
{
    public static class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}