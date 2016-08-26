using System;

abstract class Animal
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
    int? amtFood;
    public int? AmtFood
    {
        set { amtFood = value; }
        get { return amtFood; }
    }

    //double? weight;
    //public double? weight
    //{
    //    set { weight = value; }
    //    get { return weight; }
    //}

    decimal? priceToAdopt;
    public decimal? PriceToAdopt
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
