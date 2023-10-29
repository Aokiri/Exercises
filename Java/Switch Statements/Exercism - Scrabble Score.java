// Link to the exercise: https://exercism.org/tracks/java/exercises/scrabble-score

public class Scrabble {
    private int score;

    public Scrabble(String word) {
        char[] wordCrums = word.toUpperCase().toCharArray();

        for (char ch: wordCrums) {
            score += switch (ch) {
                case 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' -> 1;
                case 'D', 'G' -> 2;
                case 'B', 'C', 'M', 'P' -> 3;
                case 'F', 'H', 'V', 'W', 'Y' -> 4;
                case 'K' -> 5;
                case 'J', 'X' -> 8;
                case 'Q', 'Z' -> 10;
                default -> 0;
            };
        }
    }

    public int getScore() {
        return score;
    }
}
