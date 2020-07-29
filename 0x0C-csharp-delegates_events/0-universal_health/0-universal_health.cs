using System;

/// <summary> Player Class which handles the Player attributes and actions </summary>
class Player
{
    string name;
    float maxHp;
    float hp;

    /// <summary> Player's Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0) this.maxHp = maxHp;
        else
        {
            this.maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default");
        }
        this.hp = maxHp;
    }

    /// <summary> Prints the Player's current health </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}