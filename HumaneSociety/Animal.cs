using System;

public abstract class Animal
{   
    static int numOfAnimals = 0;

    int id;
    public int Id
    {
        get { return id; }
    }

    string name;
    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    bool hasShots;
    public bool HasShots
    {
        set { hasShots = value; }
        get { return hasShots; }
    }
    int? cageNumber;
    public int? CageNumber
    {
        set { cageNumber = value; }
        get { return cageNumber; }
    }
    int? amountOfFood;
    public int? AmountOfFood
    {
        set { amountOfFood = value; }
        get { return amountOfFood; }
    }

    double priceToAdopt;
    public double PriceToAdopt
    {
        set { priceToAdopt = value; }
        get { return priceToAdopt; }
    }

    public Animal()
    {
        id = ++numOfAnimals;
        hasShots = false;
    }

    public void GiveShot()
    {
        hasShots = true;
    }

}
