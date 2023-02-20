

using CardClass;

namespace CardClass
{
    //enums for the face and suit of the card
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}

public enum Suit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public class Card
{
    private Face face;
    private Suit suit;

    //default constructor
    public Card()
    {
        face = Face.Ace;
        suit = Suit.Spades;
    }
    //copy constuctor
    public Card(Card existingCard)
    {
        face = existingCard.face;
        suit = existingCard.suit;
    }
    //parameterized constructor
    public Card(int n)
    {
        face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
        suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
    }
    //getters and setters 
    public Face GetFace()
    {
        return face;
    }

    public void SetFace(Face face)
    {
        this.face = face;
    }

    public Suit GetSuit()
    {
        return suit;
    }

    public void SetSuit(Suit suit)
    {
        this.suit = suit;
    }

    //to string method 
    public override string ToString()
    {
        return $"The {face} of {suit}";
    }
}
