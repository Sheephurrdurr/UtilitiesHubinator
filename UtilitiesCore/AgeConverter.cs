namespace UtilitiesCore
{
    public static class AgeConverter
    {
        public static double ConvertYearsToSeconds(int years)
        {
            return years * 31536000; // Seconds in a year
        }
    }
}
