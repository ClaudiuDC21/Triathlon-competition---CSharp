namespace Proiect_csharp.Domain
{
    public class Contest : Entity<int>
    {
        private string sport;
        private string referee;

        public Contest(string sport, string referee)
        {
            this.sport = sport;
            this.referee = referee;
        }

        public string Referee
        {
            get => referee;
            set => referee = value;
        }

        public string Sport
        {
            get => sport;
            set => sport = value;
        }

        public override string ToString()
        {
            return "Contest{" +
                   "sport = " + sport + '\'' +
                   "referee = " + referee +
                   '}';
        }
    }
}