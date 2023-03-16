namespace Timer
{
    public class Minutos : ITiempo
    {
        public Minutos()
        {

        }

        string ITiempo.UpdateTime(int sumM)
        {
            var m = sumM.ToString().Length < 2 ? "0" + sumM.ToString() : sumM.ToString();
            return m;
        }
      
    }
}