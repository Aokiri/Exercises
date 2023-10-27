// Link to the exercise: https://exercism.org/tracks/java/exercises/elons-toy-car

public class ElonsToyCar 
{
    private int drivenDistance = 0;
    private int battery = 100;

    public static ElonsToyCar buy() 
    {
        return new ElonsToyCar();
    }

    public String distanceDisplay() 
    {
        return String.format("Driven %d meters", this.drivenDistance);
    }

    public String batteryDisplay() 
    {
        return battery > 0 
            ? String.format("Battery at %d%%", this.battery)
            : "Battery empty";
    }

    public void drive() 
    {
        if (battery > 0)
        {
            this.drivenDistance += 20;
            this.battery -= 1;
        }
    }
}
