namespace BuilderBurger
{
    public class Burger
    {
        public bool Cutlet { get; set; } = false;
        public bool Cucumber { get; set; } = false;
        public bool Onion { get; set; } = false;
        public bool Tomato { get; set; } = false;
        public bool Leaves { get; set; } = false;
        public bool Rolls { get; set; } = false;
        public Burger() { }
        public override string ToString()
        {
            return "Котлеты: " + Cutlet + "\nОгурцы: " + Cucumber + "\nЛук: " + Onion + "\nСалатные листья: " + Leaves + "\nПомидоры: " + Tomato + "\nБулки: " + Rolls;
        }
    }
}
