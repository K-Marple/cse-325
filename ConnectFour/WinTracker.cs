namespace ConnectFour;

public class WinTracker
{
    public int Player1Streak { get; set; }
    public int Player2Streak { get; set; }

    public void RecordWins(int player)
    {
        if (player == 1)
        {
            Player1Streak++;
            Player2Streak = 0;
        }
        else
        {
            Player2Streak++;
            Player1Streak = 0;
        }
    }
}