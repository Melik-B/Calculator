//calculator

//ALGORITHM

//1.1 Start.
//1.2 The user is prompted for the first number.
//1.3 The user is prompted for the second number.
//1.4 The action the user wants to take is prompted, eg:(+, -, *, /).
//1.5 The calculation is based on the inputs made by the user.
//1.6 The calculation result is printed on the screen.


//hesap makinesi

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcıdan ilk sayı istenir.
//1.3 Kullanıcıdan ikinci sayı istenir.
//1.4 Kullanıcıdan yapılması istenen işlem istenir, örn: (+, -, *, /).
//1.5 Kullanıcının yaptığı girişlere göre hesaplama işlemi yapılır.
//1.6 Hesap sonucu ekrana yazdırılır.



using calculator;

Logo.WriteLogo();

Console.Write("Number 1 (Exit => 0): "); // Sayı 1
double number1 = Convert.ToDouble(Console.ReadLine());

while (number1 != 0) //Another method(Diğer Yöntem) => if(number1 != "00")
{
    Console.Write("Number 2: "); // Sayı 2
    double number2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Process eg:(+, -, *, /): "); // İşlem örn:(+, -, *, /)
    string process = Convert.ToString(Console.ReadLine());

    double result; // Sonuç

    #region made using switch
    //switch (process)
    //{
    //    case "+":
    //        result = number1 + number2;
    //        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    //        break;
    //    case "-":
    //        result = number1 - number2;
    //        //Another method(Diğer Yöntem) => Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    //        Console.WriteLine("{0} {1} {2} = {3}", number1, process, number2, result);
    //        break;
    //    case "*":
    //        result = number1 * number2;
    //        //Another method(Diğer Yöntem) => Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    //        Console.WriteLine($"{number1} {process} {number2} = {result}");
    //        break;
    //    case "/":
    //        result = number1 / number2;
    //        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    //        break;
    //    default:
    //        Console.WriteLine("Please select a transaction!"); //Lütfen bir işlem seçin!
    //        break;
    //}
    #endregion

    #region made using if
    if (process == "+")
    {
        result = number1 + number2;
        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    }
    else if (process == "-")
    {
        result = number1 - number2;
        //Another method(Diğer Yöntem) => Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    }
    else if (process == "*")
    {
        result = number1 * number2;
        //Another method(Diğer Yöntem) => Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    }
    else if (process == "/")
    {
        result = number1 / number2;
        Console.WriteLine(number1 + " " + process + " " + number2 + " = " + result);
    }
    else
    {
        Console.WriteLine("Please select a transaction!"); //Lütfen bir işlem seçin!
    }
    #endregion


    Console.Write("Number 1: "); // Sayı 1
    number1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Number 2: "); // Sayı 2
    number2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Process eg:(+, -, *, /): "); // İşlem örn:(+, -, *, /)
    process = Convert.ToString(Console.ReadLine());
}