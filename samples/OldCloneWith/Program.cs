using OldCloneWith;

Action<Person> outputPerson = p => {
  Console.WriteLine($"Person {p.FirstName} {p.Name}");
};

Console.WriteLine("Old CloneWith helper");

var oli = new Person("Oli", "Sturm");

outputPerson(oli);

var olisFather = oli.CloneWith(new Dictionary<string, object> {
  { "FirstName", "Klaus" }
});

outputPerson(olisFather);
