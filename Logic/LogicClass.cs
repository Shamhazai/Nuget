namespace Logic
{
    public class LogicClass<T> where T : class
    {
        private List<T> Airs = new List<T>();

        public List<T> All()
        {
            return Airs;
        }

        public void AddAir(T air)
        {
            Airs.Add(air);
        }

        public void RemoveAir(T air)
        {
            Airs.Remove(air);
        }

        public void UpDateAir(int index, T air)
        {
            Airs[index] = air;
        }
    }
}