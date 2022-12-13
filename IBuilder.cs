using System;
using System.Collections.Generic;
using System.Text;
using BuilderBurger;

namespace BuilderBurger
{
    public interface IBuilder
    {
        IBuilder AddCutlet();
        IBuilder AddCucumber();
        IBuilder AddOnion();
        IBuilder AddTomato();
        IBuilder AddLeaves();
        IBuilder AddRolls();
        Burger GetBurger();
    }
}
