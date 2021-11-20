namespace DesignPatterns.Creational.Builder.Faceted;

public class Person
{
    // Address info
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    // Employment info
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public int AnnualIncome { get; set; }

    public override string ToString() => $"Address Information:\nStreet: {Street}\nPostal Code: {PostalCode}\nCity: {City}" +
            $"\n\nEmployment Information:\nCompany: {CompanyName}\nPosition: {Position}\nAnnual Income: {AnnualIncome}";
}
