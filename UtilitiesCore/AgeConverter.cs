namespace UtilitiesCore
{
    public static class AgeConverter
    {
        public static double ConvertYearsToSeconds(int years)
        {
            return years * 365d * 24 * 60 * 60;
        }
    }
}
