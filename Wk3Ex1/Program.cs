
//declares variable for starting currecny
int currencyA;

//declare varibale for ending currecny
int currencyB;

//decalres variable for currecny
double convertcurrency;

//decalres variable for currency
double convertcurrency2 = 0.0;

//promt user input to ask what currecny they are starting with
Console.WriteLine(" What currency are you wanting to convert: ");
Console.WriteLine("1:USD, 2:Euro, 3:Japanese Yen ");

//collects user input for frist currency
currencyA = Convert.ToInt32(Console.ReadLine());

//promt user input for the second currency that they want to convert too
Console.WriteLine(" Which currency are you wanting to convert into: ");
Console.WriteLine("1:USD, 2:Euro, 3:Japanese Yen ");

//collects user input for second currency
currencyB = Convert.ToInt32(Console.ReadLine());

//promts user to input the amout they want to convert
Console.WriteLine(" how much do you want to convert ");

//collects user input for amount of currency
convertcurrency = Convert.ToDouble(Console.ReadLine());

//caluates the converting of the currency that the user inputs
//conerts usd into other currencys
if (currencyA == 1)
{
    //converts usd into usd
    if (currencyB == 1)
    {
        convertcurrency2 = convertcurrency;
    }
    //converts usd into Canadian Dollar
    else if (currencyB == 2)
    {
        convertcurrency2 = convertcurrency * 0.96;
    }
    //conerts usd into japanese yen
    else if (currencyB == 3)
    {
        convertcurrency2 = convertcurrency * 155.18;
    }

   

}
//converts Canadian Dollar into other currencys
else if (currencyA == 2)
{
    //converts Canadian Dollar into usd
    if (currencyB == 1)
    {
        convertcurrency2 = convertcurrency * 1.04;
    }
    // converts Canadian Dollar into Canadian Dollar
    else if (currencyB == 2)
    {
        convertcurrency2 = convertcurrency;
    }
    //converts Canadian Dollar into yen
    else if (currencyB == 3)
    {
        convertcurrency2 = convertcurrency * 160.81;
    }



}
//converts yeb into other currecny
else if (currencyA == 3)
{
    // converts yen into usd
    if (currencyB == 1)
    {
        convertcurrency2 = convertcurrency * 0.0064;
    }
    //converts yen into Canadian Dollar
    else if (currencyB == 2)
    {
        convertcurrency2 = convertcurrency * 0.0062;
    }
    //converts yen into yen
    else if (currencyB == 3)
    {
        convertcurrency2 = convertcurrency;
    }



}




//outputs the results
Console.WriteLine(" your converted " + convertcurrency );
Console.WriteLine(" into " + convertcurrency2  );
Console.ReadLine();