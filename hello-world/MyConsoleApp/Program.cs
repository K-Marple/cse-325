using System.Reflection;

Console.WriteLine("Hello, World!");

var date = DateTime.Now;
Console.WriteLine($"The current time is {date}");

// Get today's date and Christmas day
var today = DateTime.Today;
var christmas = new DateTime(today.Year, 12, 25);

// For days after 12/25, calculate for next year
if (today > christmas)
{
    christmas = christmas.AddYears(1);
}

// Calculate days until
var days = (christmas - today).TotalDays;
Console.WriteLine($"It is {days} days until Christmas.");