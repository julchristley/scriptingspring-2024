using System; // this is from the tutorial

public class Program
{
	public GameStates gameStates;
	
	public void Main ()
	{
		gameStates = new GameStates ();
		gameStates.currentState = GameStates.States.Playing; // swap out Playing for any game state
		gameStates.CheckState();
	}
}
public class GameStates {
	
	public enum States { // labeling system, basically. grouping of labels
	Starting,
	Playing,
	Ending
	}
	
	public States currentState = States.Starting;
	
	public void CheckState () {
		switch (currentState) {
			case States.Starting:
				Console.WriteLine("Starting");
				break; // keyword that means stop running the switch
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
		}
	}
}

