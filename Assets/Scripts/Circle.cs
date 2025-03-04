using UnityEngine;

public class Circle : Shape //INHERITANCE
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Circle"); //POLYMORPHISM
    }
}
