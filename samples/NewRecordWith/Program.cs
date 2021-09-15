Console.WriteLine("New record-specific 'with' mechanism");

var oli = new Person("Oli", "Sturm");

Console.WriteLine(oli);

var olisFather = oli with { FirstName = "Klaus" };

Console.WriteLine(olisFather);


// Side note: what on earth is the reason that C# requires me to include this
// type declaration **after** its use in the top-level statements above?!??!

public record Person(string FirstName, string Name);
