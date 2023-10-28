// Link to the exercise: https://exercism.org/tracks/java/exercises/squeaky-clean

class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder stringBuilder = new StringBuilder();
        boolean WasHypen = false; // If there's a hypen '-' in the current iteration, this will change to true.

        for (char c : identifier.toCharArray()) {
            boolean IsLetter = Character.isLetter(c); // Checks if is a letter.
            boolean IsSpace = Character.isSpaceChar(c); // Check if is a white space.
            boolean IsControl = Character.isISOControl(c); // Check if is control character.
            boolean IsGreek = (c < 0x3B1 || c > 0x3C9); // Check if is a greek letter between 'α' and 'ω'.

            if (IsSpace) {
                stringBuilder.append("_");
                WasHypen = false;
            } else if (c == '-') {
                WasHypen = true;
            } else if (IsControl) {
                stringBuilder.append("CTRL");
            } else if (IsGreek && IsLetter) {
                if (WasHypen)
                    c = Character.toUpperCase(c);
                
                stringBuilder.append(c);
                WasHypen = false;
            }
        }
        return stringBuilder.toString();
    }
}