public static class Triangle
{
    public const string SUCCESS = "The triangle is a valid isosceles triangle";
    public const string FAILURE = "The triangle is not a valid isosceles triangle";
    public static string ValidIsoscelesTriangle(int firstAngle, int secondAngle, int thirdAngle)
    {
        if (firstAngle == secondAngle || firstAngle == thirdAngle || secondAngle == thirdAngle)
        {
            return SUCCESS;
        }
        return FAILURE;
    }

    static void Main(string[] args)
    {

    }
}