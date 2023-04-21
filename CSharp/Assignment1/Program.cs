using System;

Console.WriteLine("Enter the month from 1-12");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Year ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Day of week 1-7");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "       CALENDAR      ");
Console.WriteLine(" S  M  Tu  W  Th  F  S ");

int daysInMonth = DateTime.DaysInMonth(year, month);


for (int i = 1; i < day; i++)
{
    Console.Write("   ");
}

// Print the days of the month
for (int d = 1; day <= daysInMonth; day++)
{
    Console.Write("{0,2} ", day);

    // If the last day of the week has been printed, move to the next line
    if ((day + d - 1) % 7 == 0)
    {
        Console.WriteLine();
    }
}

// Print the remaining blank spaces after the last day of the month
if ((day + daysInMonth - 1) % 7 != 0)
{
    Console.WriteLine();
}
    
