using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1;

#region before
//class Cook
//{
//    public string Name { get; set; }
//    public Cook(string name)
//    {
//        this.Name = name;
//    }
//
//    public void MakeDinner()
//    {
//        Console.WriteLine("kartof soyur");
//        Console.WriteLine("Qazani qaz ustunde qoyur");
//        Console.WriteLine("edvuyyat qatir");
//        Console.WriteLine("pure hazirdir");
//
//        //asbaz tek kartof bisirmeyin istemirikse 
//    }
//}
#endregion


#region after
class Cook
{
    public string Name { get; set; }

    public Cook(string name)
    {
        this.Name = name;
    }

    public void MakeDinner(IMeal meal)
    {
        meal.Make();
    }
}

interface IMeal
{
    void Make();
}
class PotatoMeal : IMeal
{
    public void Make()
    {
        Console.WriteLine("kartof soyur");
        Console.WriteLine("Qazani qaz ustunde qoyur");
        Console.WriteLine("edvuyyat qatir");
        Console.WriteLine("pure hazirdir");
    }
}
class SaladMeal : IMeal
{
    public void Make()
    {
        Console.WriteLine("Pomidor ve xiyar kesrk");
        Console.WriteLine("Duz ve edvyat qatrq");
        Console.WriteLine("maynez vuruq");
        Console.WriteLine("salat hazirdir");
    }
}
#endregion