 // -----------------------------WRONG-------------------------------------
class Program
{
    static void Main(string[] args)
    {
        Fiction fiction = new Biography();
        Console.WriteLine(fiction.GetGenre());
    }
}
public class Fiction
{
    public virtual string GetGenre()
    {
        return "FICTION";
    }
}
public class Biography : Fiction
{
    public override string GetGenre()
    {
        return "BIOGRAPHY";
    }
}

// ---------------------------RIGHT----------------------------------

class Program
{
    static void Main(string[] args)
    {
        Book book = new Fiction();
        Console.WriteLine(book.GetGenre());
        book = new Biography();
        Console.WriteLine(book.GetGenre());
    }
}
public abstract class Book
{
    public abstract string GetGenre();
}
public class Fiction : Book
{
    public override string GetGenre()
    {
        return "FICTION";
    }
}
public class Biography : Book
{
    public override string GetGenre()
    {
        return "BIOGRAPHY";
    }
}
