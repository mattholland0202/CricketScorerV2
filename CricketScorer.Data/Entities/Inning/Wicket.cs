namespace CricketScorer.Data.Entities
{
    public class Wicket : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int WicketID { get; set; }
        public virtual WicketType Type { get; set; }
        public virtual Player Fielder { get; set; }
        public virtual Player SecondaryFielder { get; set; }
        public virtual string Notes { get; set; }
    }
}
