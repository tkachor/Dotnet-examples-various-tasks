
//(6 kyu - https://www.codewars.com/) 
//Function which returns the number of days from today till the given date.
//The function will take a Date object as parameter. You have to round the amount of days.

string countDays(DateTime d)
{
    DateTime today = DateTime.Now;

    if ((d - today).Days == 0)
    {
        return "Today is the day!";
    }
    else if ((d - today).Days < 0)
    {
        return "The day is in the past!";
    }
    else
    {
        return $"{(d - today).Days} days";
    }
}