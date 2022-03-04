namespace ConsoleApplicationTask4var17
{
    public class institutionOfHigherEducation
    {
        private string name;
        private int enrollee;
        private int graduate;
        private double Q;

        public institutionOfHigherEducation(string name, int enrollee, int graduate)
        {
            this.name = name;
            this.enrollee = enrollee;
            this.graduate = graduate;
            this.Q = quality();
        }
        
        public double quality()
        {
            return (double) graduate / enrollee;
        }
        
        public override string ToString()
        {
            return $"name: \t{name}, quality: \t{Q}";
        }
    }
}