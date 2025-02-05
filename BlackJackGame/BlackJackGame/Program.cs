using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");
        TwentyOneRules.StartGame();  // Starts the game by calling StartGame method
    }
}

public static class TwentyOneRules
{
    public static void StartGame()
    {
        // Initialize deck, shuffle it, and deal cards to player and dealer
        Deck deck = new Deck();
        deck.Shuffle();

        Player player = new Player();
        Player dealer = new Player();

        // Deal two cards to player and dealer
        player.Hand.Add(deck.DealCard());
        player.Hand.Add(deck.DealCard());
        dealer.Hand.Add(deck.DealCard());
        dealer.Hand.Add(deck.DealCard());

        // Display initial hands
        Console.WriteLine("Player's Hand: ");
        player.DisplayHand();
        Console.WriteLine($"Player's Total: {player.GetHandValue()}");

        Console.WriteLine("Dealer's Hand: ");
        Console.WriteLine($"{dealer.Hand[0].Face} of {dealer.Hand[0].Suit} (hidden card)");

        // Player's turn
        while (player.GetHandValue() < 21)
        {
            Console.WriteLine("Would you like to (H)it or (S)tand?");
            var input = Console.ReadLine().ToLower();

            if (input == "h")
            {
                player.Hand.Add(deck.DealCard());
                Console.WriteLine("You drew: " + player.Hand.Last().Face);
                Console.WriteLine($"Player's Total: {player.GetHandValue()}");
                
            }
            else if (input == "s")
            {
                break;
            }
        }

        // Dealer's turn (dealer hits until they have 17 or more)
        while (dealer.GetHandValue() < 17)
        {
            dealer.Hand.Add(deck.DealCard());
        }

        // Show the final hands
        Console.WriteLine("\nFinal Results:");
        Console.WriteLine("Player's Hand: ");
        player.DisplayHand();
        Console.WriteLine($"Player's Total: {player.GetHandValue()}");

        Console.WriteLine("Dealer's Hand: ");
        dealer.DisplayHand();
        Console.WriteLine($"Dealer's Total: {dealer.GetHandValue()}");

        // Check for winner
        if (player.GetHandValue() > 21)
        {
            Console.WriteLine("You busted! Dealer wins.");
            
        }
        else if (dealer.GetHandValue() > 21)
        {
            Console.WriteLine("Dealer busted! You win!");
            
        }
        else if (player.GetHandValue() > dealer.GetHandValue())
        {
            Console.WriteLine("You win!");
            
        }
        else if (player.GetHandValue() < dealer.GetHandValue())
        {
            Console.WriteLine("Dealer wins!");
            
        }
        else
        {
            Console.WriteLine("It's a tie!");
            
        }
        Console.ReadLine();
    }
}

public class Player
{
    public List<Card> Hand { get; set; } = new List<Card>();

    public int GetHandValue()
    {
        int value = Hand.Sum(card => card.Value);
        int aceCount = Hand.Count(card => card.Face == "Ace");

        // Adjust for Aces (Ace can be 1 or 11, reduce Ace value if hand > 21)
        while (value > 21 && aceCount > 0)
        {
            value -= 10;  // Adjust Ace from 11 to 1
            aceCount--;
        }

        return value;
    }

    public void DisplayHand()
    {
        foreach (var card in Hand)
        {
            Console.WriteLine($"{card.Face} of {card.Suit}");
            Console.ReadLine();
        }
    }
}

public class Deck
{
    private List<Card> cards = new List<Card>();
    private Random rand = new Random();

    public Deck()
    {
        var suits = new[] { "Hearts", "Diamonds", "Clubs", "Spades" };
        var faces = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var face in faces)
            {
                int value = face == "Ace" ? 11 : (face == "Jack" || face == "Queen" || face == "King" ? 10 : int.Parse(face));
                cards.Add(new Card(suit, face, value));
            }
        }
    }

    public void Shuffle()
    {
        cards = cards.OrderBy(c => rand.Next()).ToList();  // Shuffle the deck
    }

    public Card DealCard()
    {
        var card = cards.First();
        cards.RemoveAt(0);
        return card;
    }
}
public class Card
{
    public string Suit { get; set; }
    public string Face { get; set; }
    public int Value { get; set; }

    public Card(string suit, string face, int value)
    {
        Suit = suit;
        Face = face;
        Value = value;
    }
}