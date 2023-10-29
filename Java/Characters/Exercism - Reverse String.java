public class ReverseString {

    /**
     * Takes a String and reverses it from back to start.
     * @param inputString - The actual input string.
     * @return - A reversed string from the input string.
     */
    String reverse(String inputString) {
        int inputLength = inputString.length() - 1;
        char[] deconstructedString = inputString.toCharArray();
        StringBuilder result = new StringBuilder();

        for (int i = inputLength; i >= 0; i--) {
            result.append(deconstructedString[i]);
        }
        return result.toString();
    }
}