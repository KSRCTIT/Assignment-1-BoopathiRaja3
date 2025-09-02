using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Section 1: Literals and Data Types =====");

        // 1.i) Temperature check
        float temperature = 36.6f;
        Console.WriteLine(temperature > 37.0f ? "Fever" : "Normal");

        // 1.ii) Voting eligibility
        int age = 18;
        Console.WriteLine(age >= 18 ? "Eligible to Vote" : "Not Eligible");

        // 1.iii) Gender check
        char gender = 'M';
        if (gender == 'M') Console.WriteLine("Male");
        else if (gender == 'F') Console.WriteLine("Female");
        else Console.WriteLine("Other");

        // 1.iv) Price and discount
        double price = 1000.0;
        double discount = 10.0;
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: ₹" + finalPrice);

        // 1.v) Login success
        bool loginSuccess = true;
        Console.WriteLine(loginSuccess ? "Login successful" : "Access denied");

        // 1.vi) Display literals and their types
        int age2 = 25;
        float temperature2 = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"age: {age2}, Type: {age2.GetType()}");
        Console.WriteLine($"temperature: {temperature2}, Type: {temperature2.GetType()}");
        Console.WriteLine($"grade: {grade}, Type: {grade.GetType()}");
        Console.WriteLine($"isPassed: {isPassed}, Type: {isPassed.GetType()}");

        Console.WriteLine("\n===== Section 2: Operators and Logic =====");

        // 2.i) Kids Calculator
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages: " + (a * b));
        Console.WriteLine("Chocolates per kid: " + (a / b));
        Console.WriteLine("Leftover candies: " + (a % b));

        // 2.ii) Player Score Comparison
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A > Player B: " + (playerA > playerB));
        Console.WriteLine("Scores Equal: " + (playerA == playerB));
        Console.WriteLine("Player A failed to beat B: " + (playerA <= playerB));
        Console.WriteLine("Player B failed to beat A: " + (playerB <= playerA));

        // 2.iii) Login system using logical operators
        bool isUsernameValid = true;
        bool isPasswordValid = false;
        Console.WriteLine(isUsernameValid && isPasswordValid ? "Access Granted" : "Access Denied");
        Console.WriteLine(isUsernameValid || isPasswordValid ? "One condition is true" : "Both are false");
        Console.WriteLine("!isUsernameValid: " + !isUsernameValid);

        // 2.iv) Quiz Score Updates
        int score = 50;
        Console.WriteLine("Start Score: " + score);
        score += 10;
        Console.WriteLine("After Correct Answer: " + score);
        score -= 5;
        Console.WriteLine("After Wrong Answer: " + score);
        score *= 2;
        Console.WriteLine("After Bonus Round: " + score);
        score /= 5;
        Console.WriteLine("After Penalty: " + score);

        // 2.v) Voting system for 5 people
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter age of person {i}: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userAge >= 18 ? "Eligible to Vote" : "Not Eligible");
        }

        Console.WriteLine("\n===== Section 3: Real-life Applications =====");

        // 3.i) ATM PIN System
        int correctPIN = 1234, attempts = 0;
        bool access = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());
            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                access = true;
                break;
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
                attempts++;
            }
        }

        if (!access)
            Console.WriteLine("Card Blocked");

        // 3.ii) Multiplication Table with Repeat
        string choice;
        do
        {
            Console.Write("Enter a number for table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");

            Console.Write("Try another number? (Y/N): ");
            choice = Console.ReadLine().ToUpper();
        } while (choice == "Y");

        // 3.ii Bonus) Electricity Bill Calculation
        Console.Write("Enter electricity units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill = 0;

        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = 100 * 2 + (units - 100) * 3;
        else
            bill = 100 * 2 + 100 * 3 + (units - 200) * 5;

        Console.WriteLine("Total Bill: ₹" + bill);

        // 3.iii) Student Average Score
        int[] marks = new int[5];
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        double avg = marks.Average();
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine(avg >= 40 ? "Passed" : "Failed");

        // 3.iv) Name Validation
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        if (IsValidName(name))
            Console.WriteLine("Valid Name");
        else
            Console.WriteLine("Invalid Name");
    }

    static bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
    }
}
