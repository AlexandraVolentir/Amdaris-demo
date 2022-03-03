using System;
public sealed class Singleton
{
    private Singleton()
    {
    }

    // I can pass a delegate to the constructor that calls the Singleton constructor
    // which is done most easily with a lambda expression.
    // Allows me to check whether or not the instance has been created with the IsValueCreated property
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
    public static Singleton Instance
    {
        get
        {
            return lazy.Value;
        }
    }
}