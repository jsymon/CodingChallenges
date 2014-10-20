using System;

public static class Year
{
    public static bool IsLeap(int year)
    {
        return
            year % 4 == 0           //Leap Years are any year that can be evenly divided by 4
            && (year % 100 != 0     //...except if it can can be evenly divided by 100, then it *isn't* (such as 2100, 2200, etc)
                || year % 400 == 0);//...*except* if it can then be evenly divided by 400, then it is (such as 2000, 2400)
    }
}