namespace Timer
{
    public class Segundos : ITiempo
    {
        public Segundos()
        {

        }

        string ITiempo.UpdateTime(int sumS)
        {
            var s = sumS.ToString().Length < 2 ? "0" + sumS.ToString() : sumS.ToString();
            return s;
        }
      
    }
}