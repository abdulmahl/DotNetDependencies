// See https://aka.ms/new-console-template for more information
using static System.Console;
using Humanizer;

static void HumanizeQuantities()
{
    WriteLine("case".ToQuantity(0));
    WriteLine("case".ToQuantity(1));
    WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    WriteLine(TimeSpan.FromDays(1).Humanize());
    WriteLine(TimeSpan.FromDays(16).Humanize());
}

WriteLine("Quantities:");
HumanizeQuantities();

WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

