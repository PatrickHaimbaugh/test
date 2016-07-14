using System;

public class Customer
{
    //1
    public enum Gender { Unknown, Male, Female};
    public string Name { get; set; }
    public string Purchase { get; set; }
    public Gender Gendercust { get; set; }
    //2
    public Customer(string name, Gender gender, string purchase)
    {
        Name = name;
        Gendercust = gender;
        Purchase = purchase;
        
    }
    //3
    public void Thanks()
    {
        Console.WriteLine(
            $"Hello {Name}, thank you for purchasing the {Purchase}. We hope you enjoy it!"
            );
    }
    //4
    
    public void SendSaleNotice(string date)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale coming up on {date}");
    }
    public void SendSaleNotice(string date, string product)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale on {product} coming up on {date}");
    }
    //9
    public override string ToString()
    {
        Console.WriteLine( $"{Name} - {Purchase} - {Customer.Gender.Male}.");
        return $"{Name} - {Purchase} - {Customer.Gender.Male}.";
    }
}

//5
public sealed class InactiveCustomer : Customer
{
    //6
    public InactiveCustomer(
        int monthsinactive,
        PossibleReasonInactive reasoninacive,
        string name,
        Gender gender,
        string purchase)
        : base(name, gender, purchase)
    {
        MonthsInactive = monthsinactive;
        ResonInactive = reasoninacive;
    }
    public int MonthsInactive { get; set; }
    //7
    public void InactiveMessage()
    {
        Console.WriteLine($"Thanks for shopping with us {Name}. We saw that you purchased {Purchase} from us {MonthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals!");
    }
    //10
    public enum PossibleReasonInactive { Irate, Moved, Uninsterested};
    //11
    public PossibleReasonInactive ResonInactive { get; set; }
    //12
    public override string ToString()
    {
        Console.WriteLine( $"{Name} - {Purchase} - {Customer.Gender.Male} - {MonthsInactive} - {ResonInactive}");
        return $"{Name} - {Purchase} - {Customer.Gender.Male} - {MonthsInactive} - {ResonInactive}";
    }

}
//from 7
var ina = new InactiveCustomer(4, InactiveCustomer.PossibleReasonInactive.Moved, "Sam", Customer.Gender.Male, "ipod");
ina.InactiveMessage();
//from 3
var pat = new Customer("pat", Customer.Gender.Male, "cat");
pat.Thanks();
//from 4
pat.SendSaleNotice("02/17/2017", "Phones");
pat.SendSaleNotice("02/17/2017");
//from 9
pat.ToString();
//from 12()
ina.ToString()

