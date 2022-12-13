using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBurger
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public Burger Create()
        {
            return builder.AddRolls()
                            .AddCutlet()
                            .AddLeaves()
                            .AddOnion()
                            .AddCucumber()
                            .GetBurger();
        }
    }
}
