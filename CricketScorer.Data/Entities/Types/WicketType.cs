namespace CricketScorer.Data.Entities
{
    public class WicketType : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int WicketTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Abbreviation { get; set; }
    }
}
