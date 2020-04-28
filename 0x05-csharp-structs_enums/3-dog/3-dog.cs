using System;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string Name, float Age, string Owner, Rating Rat)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rat;
        
    }

    public override string ToString()
    {
        return("Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating);
    }
    
}