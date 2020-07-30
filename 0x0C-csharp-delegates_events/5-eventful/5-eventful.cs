using System;

/// <summary> Enum that handles the modifier </summary>
public enum Modifier
{
    /// <summary> Weak Modifier </summary>
    Weak,
    /// <summary> Base Modifier </summary>
    Base,
    /// <summary> Strong Modifier </summary>
    Strong
}

/// <summary> Delegate that handles the modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> Player Class which handles the Player attributes and actions </summary>
class Player
{
    string name;
    float maxHp;
    float hp;
    EventHandler<CurrentHPArgs> HPCheck;
    string status;

    /// <summary> Player's Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0) this.maxHp = maxHp;
        else
        {
            this.maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
        this.status = String.Format("{0} is ready to go!", this.name);
        HPCheck += CheckStatus;
    }

    /// <summary> Prints the Player's current health </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary> Delegate which handles the Health </summary>
    delegate void CalculateHealth(float damage);

    /// <summary> Handles Damage Health and apllies it to the hp </summary>
    public void TakeDamage(float damage)
	{
        float currentHp = this.hp;
		if (damage < 0f)
        {
            System.Console.WriteLine("{0} takes 0 damage!", this.name);
			damage = 0f;
        }
        else
        {
            System.Console.WriteLine("{0} takes {1} damage!", this.name, damage);
		    currentHp -= damage;
        }
        ValidateHP(currentHp);
	}

    /// <summary> Handles Healing and applies it to the hp </summary>
    public void HealDamage(float heal)
	{
        float currentHp = this.hp;
		if (heal < 0f)
        {   
            System.Console.WriteLine("{0} heals 0 HP!", this.name);
			heal = 0f;
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		    currentHp += heal;
        }
        ValidateHP(currentHp);
	}
    
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f) this.hp = 0f;
        else if (newHp > this.maxHp) this.hp = this.maxHp;
        else this.hp = newHp;
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    /// <summary> Applies the proper modifier </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue / 2f);
        else if (modifier == Modifier.Base)
            return (baseValue);
        else
            return (baseValue  * 1.5f);
    }
    
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = String.Format("{0} is in perfect health!", this.name);
        else if (e.currentHp >= (this.maxHp / 2) && e.currentHp < this.maxHp)
            this.status = String.Format("{0} is doing well!", this.name);
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp / 2))
            this.status = String.Format("{0} isn't doing too great...", this.name);
        else if (e.currentHp > 0 && e.currentHp <= (this.maxHp / 2))
            this.status = String.Format("{0} needs help!", this.name);
        else
            this.status = String.Format("{0} is knocked out!", this.name);     

        System.Console.WriteLine(this.status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        Console.ForegroundColor = ConsoleColor.White;
        if (e.currentHp == 0)
        {
            System.Console.WriteLine("Health has reached zero!", Console.ForegroundColor);
        }
        else
        {
            System.Console.WriteLine("Health is low!");
        }
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp * 0.25f)) HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

/// <summary> Handles Events </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> Variable cannot be modified, handles hp in real-time </summary>
    public readonly float currentHp = 0;

    /// <summary> CurrentHPArgs constructor's </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}