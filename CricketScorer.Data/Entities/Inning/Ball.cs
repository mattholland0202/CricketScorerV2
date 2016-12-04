namespace CricketScorer.Data.Entities
{
    public class Ball : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int BallID { get; set; }
        public virtual int BallNumber { get; set; }
        public virtual Player FacingBatsman { get; set; }
        public virtual Player Bowler { get; set; }
        public virtual int Runs { get; set; }
        public virtual Wicket Wicket { get; set; }
    }
}
