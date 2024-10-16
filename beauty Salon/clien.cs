class Client
{
    public string Name { get; set; }
    public string Services { get; set; }
    public int Amount { get; set; }

    public Client(string name, string services, int amount)
    {
        Name = name;
        Services = services;
        Amount = amount;
    }
}