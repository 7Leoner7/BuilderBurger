namespace BuilderBurger
{
    internal class Builder : IBuilder
    {
        private Burger burger = new Burger();

        public IBuilder AddCucumber()
        {
            burger.Cucumber = true;
            return this;
        }

        public IBuilder AddCutlet()
        {
            burger.Cutlet = true;
            return this;
        }

        public IBuilder AddLeaves()
        {
            burger.Leaves = true;
            return this;
        }

        public IBuilder AddOnion()
        {
            burger.Onion = true;
            return this;
        }

        public IBuilder AddTomato()
        {
            burger.Tomato = true;
            return this;
        }

        public IBuilder AddRolls()
        {
            burger.Rolls = true;
            return this;
        }

        public Burger GetBurger()
        {
            return burger;
        }
    }
}
