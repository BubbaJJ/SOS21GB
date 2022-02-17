namespace DesignPatterns.Adapter
{
    internal class AdapterDemo
    {
        public static void Adapter()
        {
            Laptop laptop = new();
            laptop.CheckModel(new DellLaptop());
            laptop.CheckModel(new AcerLaptop());
        }
    }
}
