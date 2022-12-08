namespace Calculator.Domain.Calculations
{
    /*
     * Calculate a result from operation having two numerical arguments.
     */
    public interface IBinaryOperation
    {
        double Calculate(double a, double b);
    }
}
