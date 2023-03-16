namespace Timer
{
    public class Horas : ITiempo
    {
        public Horas()
        {

        }

        string ITiempo.UpdateTime(int sumH)
        {
            var h = sumH.ToString().Length < 2 ? "0" + sumH.ToString() : sumH.ToString();
            return h;
        }
      
    }
}