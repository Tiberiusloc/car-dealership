using System;

//Creating namespace to hold our Car Class as well as methods
namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int Speed { get; set; }
    public int Year { get; set; }

    // Can do get and set methods different ways, if need to change values or return have to do long hand way as seen below.

      // Using "set" method to SET new value into our car class
      public void SetPrice(int newPrice)
    {
        Price = newPrice;
    }
    // Method to add sounds to our cars would have to add more code to individual cars but in this example all cars make same sound
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    //Car class that is making model, price and miles of car listed
    public Car(string makeModel, int price, int miles, int speed, int year)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Speed = speed;
      Year = year;
    }
    // Using "get" method to retrieve and display the Make Model as listed above
    public string GetMakeModel()
    {
      return MakeModel;
    }
    // Using "get" method to retrieve and display the Price as listed above
    public int GetPrice()
    {
      return Price;
    }
    // Using "get" method to retrieve and display the Miles as listed above
    public int GetMiles()
    {
      return Miles;
    }
    // using "get" method to retrieve and display the Speed as listed above
    public int GetSpeed()
    {
      return Speed;
    }
    // using "get" method to retrieve and display the Year as listed above
    public int GetYear()
    {
      return Year;
    }
    //Method using a boolean to check if the user maxPrice to spend on a car is less than or equal to the price of the listed cars
    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
    // Method that takes original price of car and discounts based of sales integer
    public double SalesPrice(double salePrice)
    {
      return (Price * salePrice);
    }
  }
}