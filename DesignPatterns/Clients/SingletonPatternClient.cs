using DesignPatterns.Clients;
using DesignPatterns.Patterns.Singleton;

public class SingletonPatternClient : IPatternClient
{
	public string PatternName
	{
		get { return "Singleton pattern"; }
	}

	public void Run()
	{
		GameState state = GameState.Instance();
		GameState state2 = GameState.Instance();
	}
}
