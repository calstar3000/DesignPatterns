using DesignPatterns.Clients;
using DesignPatterns.Patterns.Factory;
using System;

/// <summary>
/// This class represents the client of the factory, eg. some sort of login process
/// Using an ID provided by the user the factory creates and calls the matching product (a social network).
/// </summary>
public class FactoryPatternClient : IPatternClient
{
    public string PatternName
    {
        get { return "Factory pattern"; }
    }

    public void Run()
    {
        Console.WriteLine("Choose a Social Network to Connect with: 1 = Google, 2 = Facebook, 3 = Instagram");
        string input = Console.ReadLine();

        SocialNetwork networkId;
        if (Enum.TryParse(input, out networkId))
        {
            ISocialNetwork socialNetwork = SocialNetworkFactory.CreateSocialNetwork(networkId);
            string description = socialNetwork.GetDescription();
            Console.WriteLine(description);
        }
    }
}
