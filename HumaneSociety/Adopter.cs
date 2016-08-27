using System;

public class Adopter
{
    static int numOfAdopters = 0;

    int id;
    public int Id
    {
        get { return id; }
    }

    string firstName;
    public string FirstName
    {
        set { firstName = value; }
        get { return firstName; }
    }


    string lastName;
    public string LastName
    {
        set { lastName = value; }
        get { return lastName; }
    }

    string address;
    public string Address
    {
        set { address = value; }
        get { return address; }
    }

    string city;
    public string City
    {
        set { city = value; }
        get { return city; }
    }

    string state;
    public string State
    {
        set { state = value; }
        get { return state; }
    }

    string zipCode;
    public string ZipCode
    {
        set { zipCode = value; }
        get { return zipCode; }
    }

    string phoneNumber;
    public string PhoneNumber
    {
        set { phoneNumber = value; }
        get { return phoneNumber; }
    }

    int? petId;
    public int? PetId
    {
        set { petId = value; }
        get { return petId; }
    }

    double? amountPaid;
    public double? AmountPaid
    {
        set { amountPaid = value; }
        get { return amountPaid; }
    }

    public Adopter()
    {
        id = ++numOfAdopters;
    }

    public void PayAdoptionFee(double price)
    {

    }
}
