// Link to the exercise: https://exercism.org/tracks/java/exercises/raindrops

public class RaindropConverter {

    String convert(int number) {
        StringBuilder result = new StringBuilder();
        boolean factor3 = number % 3 == 0;
        boolean factor5 = number % 5 == 0;
        boolean factor7 = number % 7 == 0;


        if (factor3) {
            result.append("Pling");
        } 
        if (factor5) {
            result.append("Plang");
        } 
        if (factor7) {
            result.append("Plong");
        }
        if (!factor3 && !factor5 && !factor7) {
            result.append(String.format("%d", number));
        }
        return result.toString();
    }
}
