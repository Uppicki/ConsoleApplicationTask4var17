namespace ConsoleApplicationTask4var17
{
    public class improvedInstitution : institutionOfHigherEducation
    {
        private string name;
        private int enrollee;
        private int graduate;
        private double proc;
        private double Q;
        
        public improvedInstitution(string name, int enrollee, int graduate, double proc) 
                                                            : base(name, enrollee, graduate)
        {
            this.name = name;
            this.enrollee = enrollee;
            this.graduate = graduate;
            this.proc = proc;
            this.Q = quality();
        }
        
        public double quality()
        {
            return (double) proc * base.quality() / 100;
        }
        
        public override string ToString()
        {
            return $"name: \t{name}, quality: \t{Q}";
        }
        
    }
}