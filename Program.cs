using System;
using System.Collections.Generic;
using System.Linq;
using Dealership.Models;

// Creating a name space to hold our class and methods
namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      //Class to hold Cars MakeModel, Price, and Miles
      Car volkswagen = new Car("Volkswagen Thing", 1100, 368792, 100, 1974);
      Car yugo = new Car("Yugo Koral", 700, 56000, 120, 1980);
      Car ford = new Car("Ford Country Squire", 1400, 239001, 140, 1988);
      Car amc = new Car("AMC Pacer", 400, 198000, 80, 1976);

      //Creating "dictionary" holding cars
      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

        // Setting new prices
        //yugo.SetPrice(300);


      // Getting the user maximum price for car
      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      List<Car> CarsForSalesEvent = new List<Car>(0);
      
      //Creates a list based on the previous list on line 20 that will check the value of speed and order it by descending
      List<Car> CarsSpeedSorted = Cars.OrderByDescending(o=>o.Speed).ToList();

      // Loop to check buyers budget to price of cars listed using "methods" or in javascript "prototypes"
      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      //Cars.Sort();
      // Loop to check if the car matching their budget is displayed using "get" method
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
      // Loop to check if car is about certain price and adding it to CarsForSalesEvent list
      foreach (Car automobile in Cars) 
      {
        if (automobile.GetPrice() > 800)
        {
          CarsForSalesEvent.Add(automobile);
        }
      } 
      // Loop to get the make model, miles, and regular price of automobiles in CarsForSalesEvent and then using SalesPrice() to show discounted price
      foreach (Car automobile in CarsForSalesEvent)
      {
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine("Sales Price is $" + automobile.SalesPrice(0.75));
      }

      // Loops that gets the year of every car in list and using if to determine the price based on year and using a "set" method to determine price
      foreach (Car automobile in Cars) 
      {
        if (automobile.GetYear() >= 1976 && automobile.GetYear() <= 1979) 
        {
          automobile.SetPrice(200);
        } else if (automobile.GetYear() >= 1980 && automobile.GetYear() <= 1984) {
          automobile.SetPrice(400);
        } else if (automobile.GetYear() >= 1985) {
          automobile.SetPrice(600);
        }
        Console.WriteLine("The new sale by year price is $" + amc.Price);
      }
      // For each that will get all information from the automobile post sorting method on line 36
      foreach (Car automobile in CarsSpeedSorted)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine(automobile.GetSpeed());
      }
    }
  }
}