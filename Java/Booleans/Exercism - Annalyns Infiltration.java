public class AnnalynsInfiltration 
{
    // Takes a boolean value that indicates if the knight is awake
    // Returns true if a fast attack can be made based on the state of the knight.
    public static boolean canFastAttack(boolean knightIsAwake) 
    {
        return !knightIsAwake;
    }

    // Takes three boolean values, indicating if the knight, archer and the prisoner, respectively, are awake.
    // Returns true if the group can be spied upon, based on the state of the three characters.
    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) 
    {
        return 
            knightIsAwake ||
            archerIsAwake ||
            prisonerIsAwake;
    }

    // Takes two boolean values, indicating if the archer and the prisoner, respectively, are awake. 
    // Returns true if the prisoner can be signalled, based on the state of the two characters.
    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake) 
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    // Takes four boolean values.
    // The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake. 
    // The last parameter indicates if Annalyn's pet dog is present. 
    // The method returns true if the prisoner can be freed based on the state of the three characters and Annalyn's pet dog's presence.
    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake, boolean petDogIsPresent) 
    {
        return 
            (petDogIsPresent && !archerIsAwake) ||
            (!petDogIsPresent && !knightIsAwake) &&
            canSignalPrisoner(archerIsAwake, prisonerIsAwake);
    }
}
