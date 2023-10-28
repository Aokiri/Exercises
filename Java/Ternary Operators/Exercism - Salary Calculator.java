// Link to the exercise: https://exercism.org/tracks/java/exercises/salary-calculator

public class SalaryCalculator {

    private final int DAYS_FOR_PENALTY = 5;
    private final int PRODUCTS_FOR_BONUS = 20;
    private final double MIN_SALARY = 1000;
    private final double MAX_SALARY = 2000;

    public double multiplierPerDaysSkipped(int daysSkipped) {
        return daysSkipped < DAYS_FOR_PENALTY
            ? 1 // Normal multiplier
            : 0.85; // -15% Penalty
    }

    public int multiplierPerProductsSold(int productsSold) {
        return productsSold < PRODUCTS_FOR_BONUS
            ? 10
            : 13;
    }

    public double bonusForProductSold(int productsSold) {
        return productsSold * multiplierPerProductsSold(productsSold);
    }

    public double finalSalary(int daysSkipped, int productsSold) {
        double processedSalary = MIN_SALARY * multiplierPerDaysSkipped(daysSkipped) + bonusForProductSold(productsSold);

        return processedSalary < MAX_SALARY
            ? processedSalary
            : MAX_SALARY;
    }
}