using PetShopLibrary;
using System;



public enum AnimalType
{
    Bird,
    Cat,
    Dog,
    Snake,
    Fish,
    Turtle,
    Rat
}


public enum PetStatus
{
    OK,
    Unhealthy,
    Recovering
}


public interface IPet
{
    FoodType FoodType { get; set; }
    PetStatus HealthStatus { get; set; }
    AnimalType AnimalType { get; set; }
    string Breed { get; set; }



}

public class Pet : Product, IPet 
{
    public FoodType FoodType { get; set; }
    public PetStatus HealthStatus { get; set; }
    public AnimalType AnimalType { get; set; }
    public string Breed { get; set; }
    public Transaction Transaction { get; set; }


    public Pet()
	{
    }
}

