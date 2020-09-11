namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>

    public class Calculator
    {
        //Konstruktoren
        public Calculator(decimal x, decimal y)
        {
           
        }
        public Calculator()
        {

        }
      

        //Variablen
        public decimal x { get; set; }
        public decimal y { get; set; }
        public string GanzeRechnung { get; set; }

        //Methoden
        public decimal Addiere(decimal x, decimal y)
        {
            return x + y;
        }
        public decimal Subtrahiere(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal Multipiziere(decimal x, decimal y)
        {
            return x * y;
        }
        public decimal Dividiere(decimal x, decimal y)
        {
            return x / y;
        }
        public bool addActive = false;
        public bool subActive = false;
        public bool multiActive = false;
        public bool divActive = false;

        public decimal ergebnis = 0;

    }
}
