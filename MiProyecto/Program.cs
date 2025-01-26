var corona = new Beer("corona");

System.Console.WriteLine(ToUpper(corona).Name);
System.Console.WriteLine(corona.Name);

Beer ToUpper(Beer beer)
{
    var beer2 = new Beer(beer.Name.ToUpper());
    return beer2;
}

class Beer
{
    public string Name { get; set; }

    public Beer(string name)
    {
        this.Name = name;
    }
}
