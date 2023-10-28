// Link to the exercise: https://exercism.org/tracks/java/exercises/wizards-and-warriors

abstract class Fighter {
    private final String FIGHTER_TYPE = this.getClass().getName();
    protected boolean vulnerability = true;

    protected boolean isVulnerable() {
        return false;
    }

    public String toString() {
        return String.format("Fighter is a %s", FIGHTER_TYPE);
    }

    abstract int damagePoints(Fighter fighter);

}

class Warrior extends Fighter {
    protected final int MIN_DAMAGE = 6;
    protected final int MAX_DAMAGE = 10;

    @Override
    int damagePoints(Fighter fighter) {
        return fighter.vulnerability 
            ? MAX_DAMAGE
            : MIN_DAMAGE;
    }
}

class Wizard extends Fighter {
    protected final int MIN_DAMAGE = 3;
    protected final int MAX_DAMAGE = 12;

    @Override
    protected boolean isVulnerable() {
        return vulnerability;
    }

    @Override
    int damagePoints(Fighter fighter) {
        return vulnerability
            ? MIN_DAMAGE
            : MAX_DAMAGE;
    }

    void prepareSpell() {
        vulnerability = false;
    }
}
