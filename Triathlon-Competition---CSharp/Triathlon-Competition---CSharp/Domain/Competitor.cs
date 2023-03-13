namespace Proiect_csharp.Domain
{
    public class Competitor : Entity<int>
    {
        private string firstName;
        private string lastName;
        private int numberOfPoints;
        private string sport;

        public Competitor(string firstName, string lastName, int numberOfPoints, string sport)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.numberOfPoints = numberOfPoints;
            this.sport = sport;
        }

        public string Sport
        {
            get => sport;
            set => sport = value;
        }

        public int NumberOfPoints
        {
            get => numberOfPoints;
            set => numberOfPoints = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public override string ToString()
        {
            return "Competitor{" +
                   "firstName = " + firstName + '\'' + 
                   "lastName = " + lastName + '\'' +
                   "numberOfPoints = " + numberOfPoints + '\'' +
                   "sport = " + sport +
                   '}'
                ;
        }
        
    }
}