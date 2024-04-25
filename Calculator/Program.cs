using Calculator;

CalculatorMachine calculatorMachine = new();
Boolean isEnd = false;
while (!isEnd)
{
    double firstNum = calculatorMachine.getNumber("Enter First Number then press Enter: ");
    double secondNum = calculatorMachine.getNumber("Enter Second Number then press Enter: ");
    string option = "m";
    Console.WriteLine(calculatorMachine.calculate(firstNum, secondNum));
    Console.WriteLine();
}



