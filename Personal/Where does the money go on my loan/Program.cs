/*Calculate how much of your money goes as downpayment and how much as rent*/

decimal loanAmount =  0m;
decimal interestRate = 0m;
var input = "";
bool validInput = false;
int months = 0;
int paymentPerMonth = 0;
decimal paymentTowardsLoan = 0m;
decimal interestRateSum = 0m;
decimal towardsLoan = 0m;
decimal currentMonthInterest = 0m;

do
{
    Console.WriteLine("What is the loan amount?");
    input = Console.ReadLine();
    if (input != null)
        validInput = decimal.TryParse(input, out loanAmount);
} while (loanAmount <= 0 || validInput == false);

do
{
    Console.WriteLine("\nWhat is the interest rate?");
    input = Console.ReadLine();
    if (input != null)
        validInput = decimal.TryParse(input, out interestRate);
} while (interestRate <= 0 || validInput == false);

do
{
    Console.WriteLine("\nWhat is the monthly payment?");
    input = Console.ReadLine();
    if (input != null)
        validInput = Int32.TryParse(input, out paymentPerMonth);
} while (paymentPerMonth <= 0 || validInput == false);

/*do
{
    Console.WriteLine("\nHow many months should the statistics be for?");
    input = Console.ReadLine();
    if (input != null)
        validInput = Int32.TryParse(input, out months);
} while (months <= 0 || validInput == false);*/

Console.WriteLine("Months \t\t Loan Amount \t\t Towars Loan \t\t Interest \t\t Total Interest");
for (int i = 0; loanAmount > 0; i++)
{
    currentMonthInterest = (loanAmount * interestRate / 12);
    interestRateSum += currentMonthInterest;
    towardsLoan = paymentPerMonth - (loanAmount * interestRate / 12);
    paymentTowardsLoan += towardsLoan;
    loanAmount *= 1 + (interestRate / 12);
    loanAmount -= paymentPerMonth;
    if (i == 35)
    {
        interestRate = 0.0856m;
        paymentPerMonth = 5909+1000;
    }
        Console.WriteLine($"{i + 1}\t\t | {loanAmount:N2}\t\t | {towardsLoan:N2}\t\t | {currentMonthInterest:N2}\t\t | {interestRateSum:N2}");
}

/*Console.WriteLine($"\nAfter {months} months, you will have paid {interestRateSum:N2} NOK in interest \nand {paymentTowardsLoan:N2} NOK in loan.");
Console.WriteLine($"Leaving you with a loan of {loanAmount:N2} NOK");*/