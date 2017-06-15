using DesignPatterns.Patterns.Factory;

/// <summary>
/// Example of a "Product" of the "Factory"
/// </summary>
public class Facebook : ISocialNetwork
{
	private SocialNetwork _networkId;

	public Facebook()
	{
		_networkId = SocialNetwork.Facebook;
	}

	public string GetDescription()
	{
		return string.Format("Connect with {0}", _networkId);
	}
}
