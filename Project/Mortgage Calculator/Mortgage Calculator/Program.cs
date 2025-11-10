using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double salary = 0f;
        double creditscore = 0f;
        bool criminalrecord = false;

        
        while (true)
        {
            Console.Write("Enter your salary: ");
            string salaryinput = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(salaryinput, out salary))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
            }
        }

        
        while (true)
        {
            Console.Write("Enter your credit score: ");
            string creditscoreinput = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(creditscoreinput, out creditscore))
            {
                if (creditscore >= 0 && creditscore <= 500)
                {
                    if (creditscore >= 300 && creditscore <= 500)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Sorry! you are not eligible for loan..");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Credit score must be between 0 and 500.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
            }
        }

        
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string criminlrecords = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (criminlrecords == "false")
            {
                Console.WriteLine("You are eligible for loan!");
                break;
            }
            else if (criminlrecords == "true")
            {
                Console.WriteLine("Sorry! You are not eligible due to criminal record.");
                return;
            }
            else
            {
                Console.WriteLine("Please write true/false");
            }
        }

       
        Console.Write("Enter loan amount: ");
        double loanamount = double.Parse(Console.ReadLine().Trim());

        if (loanamount <= (2 * salary))
        {
            Console.Write("Enter annual interest rate (in %): ");
            double interestrate = double.Parse(Console.ReadLine().Trim()) / 100;

            Console.Write("Enter loan term (in years): ");
            int loanterm = int.Parse(Console.ReadLine().Trim()) * 12;

            double monthlypayment = (loanamount * (interestrate / 12) * Math.Pow(1 + (interestrate / 12), loanterm))
                                    / (Math.Pow(1 + (interestrate / 12), loanterm) - 1);

            double totalpaid = monthlypayment * loanterm;
            double totalinterest = totalpaid - loanamount;

            CultureInfo bdCulture = new CultureInfo("bn-BD");

            Console.WriteLine("\n===== MORTGAGE DETAILS =====");
            Console.WriteLine("Monthly Payment: " + monthlypayment.ToString("C", bdCulture));
            Console.WriteLine("Total Paid: " + totalpaid.ToString("C", bdCulture));
            Console.WriteLine("Total Interest: " + totalinterest.ToString("C", bdCulture));
            Console.WriteLine("\nThank you for using the Mortgage Calculator!");
        }
        else
        {
            Console.WriteLine("Your loan must be within twice your salary.");
            Console.WriteLine("Sorry! You are not eligible for this amount.");
        }
    }
}
