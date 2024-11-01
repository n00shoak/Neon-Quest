using UnityEngine;

public class Stats
{
    // Movement Data
    public float
        maxSpeed,
        friction,
        acceleration,
        rotationSpeed;


    // Health Data
    public float
        maxHealth,
        healthRegen,
        healthRegenCD,
        healthConsumption,

        maxSHield,
        shieldRegen,
        shieldRegenCD,
        shieldConsumption,

        damageNegation,
        DamageReduction;


    // attack Data
    public float
        damage,
        attSpeed,
        multishot,
        duration,
        critChance,
        critDamage,
        projectileSpeed,
        areaOfEffect;


    // Ressources Data
    public float
        xpBonus,
        xpMultiplier,
        coinBonus,
        coinMultiplier;


    // Difficulty Data
    public float
        spawnSpeed,
        spawnStrenght;


}
