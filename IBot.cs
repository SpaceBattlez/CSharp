using System.Collections.Generic;

namespace SpaceBattlez
{
	public interface IBot
	{
		List<GameElements.FleetCommand> GameUpdate(GameElements.GameState state);
	}
}