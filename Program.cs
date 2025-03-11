public class Car
{
  //Attributes go here
  private string colour;

  //Constructor to make a new object of class Car..
  public Car(string aColour){
    colour = aColour;
  }

  public string GetColour(){
    return colour;
  }

  
}
public class Program{
  //Main runs automatically when the Program is run

  static void Main(string[] args)
  {
    //Calling the constructor of the Car class to make a new Car object
    Car myObj = new Car("Black");
    Car myObj2 = new Car("Yellow");

    //Printing an attribute
    Console.WriteLine(myObj.GetColour());
    Console.WriteLine(myObj2.GetColour());
  }
}