abstract class RentalEquipment
{
    public int RentalDays { get; set; }
    public bool HasInsurance { get; set; }

    public abstract double GetPricePerDay();

    public double calculateTotalPrice()
    {
        double price = RentalDays * GetPricePerDay();
        if (HasInsurance)
        {
            price += RentalDays * 100;
        }
        return price;
    }
}