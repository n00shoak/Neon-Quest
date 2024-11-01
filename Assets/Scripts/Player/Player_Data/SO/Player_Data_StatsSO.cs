using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "Player_Data_StatsSO", menuName = "Scriptable SO/Player_Data_StatsSO")]
public class Player_Data_StatsSO : ScriptableObject
{
    // SO Specific Data 
    public int priority;
    public bool isMultiplier;

    [Foldout("Movement stats")]
    public float
        newMaxSpeed,
        newFriction,
        newAcceleration,
        newRotationSpeed;

    [Foldout("Health stats")]
    public float
        newMaxHealth,
        newHealthRegen,
        newHealthRegenCD,
        newHealthConsumption,
        newMaxSHield,
        newShieldRegen,
        newShieldRegenCD,
        newShieldConsumption,
        newDamageNegation,
        newDamageReduction;

    [Foldout("attack stats")]
    public float
        newDamage,
        newAttSpeed,
        newMultishot,
        newDuration,
        newCritChance,
        newCritDamage,
        newProjectileSpeed,
        newAreaOfEffect;

    [Foldout("Ressources stats")]
    public float
        NewXpBonus,
        NewXpMultiplier,
        NewCoinBonus,
        NewCoinMultiplier;

    [Foldout("Difficulty stats")]
    public float
        newSpawnSpeed,
        newSpawnStrenght;

    public Stats SetStats(Stats stats)
    {
        stats.maxSpeed = newMaxSpeed;
        stats.friction = newFriction;
        stats.acceleration = newAcceleration;
        stats.rotationSpeed = newRotationSpeed;

        stats.maxHealth = newMaxHealth;
        stats.healthRegen = newHealthRegen;
        stats.healthRegenCD = newHealthRegenCD;
        stats.healthConsumption = newHealthConsumption;
        stats.maxSHield = newMaxSHield;
        stats.shieldRegen = newShieldRegen;
        stats.shieldRegenCD = newShieldRegenCD;
        stats.shieldConsumption = newShieldConsumption;
        stats.damageNegation = newDamageNegation;
        stats.DamageReduction = newDamageReduction;

        stats.damage = newDamage;
        stats.attSpeed = newAttSpeed;
        stats.multishot = newMultishot;
        stats.duration = newDuration;
        stats.critChance = newCritChance;
        stats.critDamage = newCritDamage;
        stats.projectileSpeed = newProjectileSpeed;
        stats.areaOfEffect = newAreaOfEffect;

        stats.xpBonus = NewXpBonus;
        stats.xpMultiplier = NewXpMultiplier;
        stats.coinBonus = NewCoinBonus;
        stats.coinMultiplier = NewCoinMultiplier;

        stats.spawnSpeed = newSpawnSpeed;
        stats.spawnStrenght = newSpawnStrenght;

        return stats;
    }

    public Stats AddStats(Stats stats)
    {
        stats.maxSpeed += newMaxSpeed;
        stats.friction += newFriction;
        stats.acceleration += newAcceleration;
        stats.rotationSpeed += newRotationSpeed;

        stats.maxHealth += newMaxHealth;
        stats.healthRegen += newHealthRegen;
        stats.healthRegenCD += newHealthRegenCD;
        stats.healthConsumption += newHealthConsumption;
        stats.maxSHield += newMaxSHield;
        stats.shieldRegen += newShieldRegen;
        stats.shieldRegenCD += newShieldRegenCD;
        stats.shieldConsumption += newShieldConsumption;
        stats.damageNegation += newDamageNegation;
        stats.DamageReduction += newDamageReduction;

        stats.damage += newDamage;
        stats.attSpeed += newAttSpeed;
        stats.multishot += newMultishot;
        stats.duration += newDuration;
        stats.critChance += newCritChance;
        stats.critDamage += newCritDamage;
        stats.projectileSpeed += newProjectileSpeed;
        stats.areaOfEffect += newAreaOfEffect;

        stats.xpBonus += NewXpBonus;
        stats.xpMultiplier += NewXpMultiplier;
        stats.coinBonus += NewCoinBonus;
        stats.coinMultiplier += NewCoinMultiplier;

        stats.spawnSpeed += newSpawnSpeed;
        stats.spawnStrenght += newSpawnStrenght;

        return stats;
    }

    public Stats multiplyStats(Stats stats)
    {
        stats.maxSpeed *= newMaxSpeed;
        stats.friction *= newFriction;
        stats.acceleration *= newAcceleration;
        stats.rotationSpeed *= newRotationSpeed;

        stats.maxHealth *= newMaxHealth;
        stats.healthRegen *= newHealthRegen;
        stats.healthRegenCD *= newHealthRegenCD;
        stats.healthConsumption *= newHealthConsumption;
        stats.maxSHield *= newMaxSHield;
        stats.shieldRegen *= newShieldRegen;
        stats.shieldRegenCD *= newShieldRegenCD;
        stats.shieldConsumption *= newShieldConsumption;
        stats.damageNegation *= newDamageNegation;
        stats.DamageReduction *= newDamageReduction;

        stats.damage *= newDamage;
        stats.attSpeed *= newAttSpeed;
        stats.multishot *= newMultishot;
        stats.duration *= newDuration;
        stats.critChance *= newCritChance;
        stats.critDamage *= newCritDamage;
        stats.projectileSpeed *= newProjectileSpeed;
        stats.areaOfEffect *= newAreaOfEffect;

        stats.xpBonus *= NewXpBonus;
        stats.xpMultiplier *= NewXpMultiplier;
        stats.coinBonus *= NewCoinBonus;
        stats.coinMultiplier *= NewCoinMultiplier;

        stats.spawnSpeed *= newSpawnSpeed;
        stats.spawnStrenght *= newSpawnStrenght;

        return stats;
    }
}
