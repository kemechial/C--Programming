try
{
    Console.Write("Input an integer: ");
    int num = Convert.ToInt32(Console.ReadLine());

    var result = 5 /num;

    if(num>5)
      throw new Exception("number greater than 5!");
}
catch (FormatException)
{
    
    Console.WriteLine("invalid!");
}

//catch (DivideByZeroException)
catch (Exception ex)
{
    Console.WriteLine("number cannot be zero!");
    Console.WriteLine(ex.Message);
}
