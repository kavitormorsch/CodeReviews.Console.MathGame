using System.Linq;

namespace MathGame
{
    public class GameRecord
    {
        public string Time { get; set; }
        public string TypeOfGame { get; set; }
        public int Score { get; set; }

        public GameRecord(string time, string typeOfGame, int score)
        {
            this.Time = time;
            this.TypeOfGame = typeOfGame;
            this.Score = score;
        }
    }
}
