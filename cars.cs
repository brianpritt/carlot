using System;
using System.Collections.Generic;

class Car
{
  private string _make;
  private string _model;
  private int _price;
  private int _miles;
  private string _color;
  private bool _forSale;
  private string _notes;


  public void SetMake(string newMake)
  {
    _make = newMake;
  }
  public string GetMake()
  {
    return _make;
  }

  public void SetModel(string newModel)
  {
    _model = newModel;
  }
  public string GetModel()
  {
    return _model;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetColor(string newColor)
  {
    _color = newColor;
  }
  public string GetColor()
  {
    return _color;
  }

  public void SetSale(bool newSale)
  {
    _forSale =  newSale;
  }
  public bool GetSale()
  {
    return _forSale;
  }
  public void SetNotes(string newNotes)
  {
    _notes = newNotes;
  }
  public string GetNotes()
  {
    return _notes;
  }
}


public class Program
{
  public static void Main()
  {
    Car firstCar = new Car();
    firstCar.SetMake("Ford");
    firstCar.SetModel("F-150");
    firstCar.SetPrice(35000);
    firstCar.SetMiles(12000);
    firstCar.SetSale(false);
    firstCar.SetNotes("Flood Damage.");

    Car secondCar = new Car();
    secondCar.SetMake("Honda");
    secondCar.SetModel("Civic");
    secondCar.SetPrice(15000);
    secondCar.SetMiles(112000);
    secondCar.SetSale(false);
    secondCar.SetNotes("Only one owner.");

    Car thirdCar = new Car();
    thirdCar.SetMake("Mercedes");
    thirdCar.SetModel("CLS300");
    thirdCar.SetPrice(135000);
    thirdCar.SetMiles(12000);
    thirdCar.SetSale(true);
    thirdCar.SetNotes("HOT BUY!!!!.");

    Car fourthCar = new Car();
    fourthCar.SetMake("Fiat");
    fourthCar.SetModel("Garbage");
    fourthCar.SetPrice(5000);
    fourthCar.SetMiles(32000);
    fourthCar.SetSale(true);
    fourthCar.SetNotes("This car is a total POS, but worth the money!.");

    Car fifthCar = new Car();
    fifthCar.SetMake("Chevy");
    fifthCar.SetModel("Malibu");
    fifthCar.SetPrice(25000);
    fifthCar.SetMiles(72000);
    fifthCar.SetSale(false);
    fifthCar.SetNotes("This car is a total POS, don't buy it.");



    List<Car> Cars = new List<Car>() {firstCar, secondCar, thirdCar, fourthCar, fifthCar};

    int carCounter = 0;
    Console.WriteLine("Enter your Price: ");
    string userPrice = Console.ReadLine();
    int priceLookup = int.Parse(userPrice);

    foreach (Car carLot in Cars)
    {
      carLot.GetPrice();
      if(carLot.GetPrice() <=priceLookup )
      {
        Console.WriteLine(carLot.GetMake());
        Console.WriteLine(carLot.GetPrice());
        carCounter += 1;
      }
    }
    if (carCounter == 0)
    {
      Console.WriteLine("No cars meet your criteria.");
    }
  }
}
