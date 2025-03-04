using UnityEngine;

public class Square : Shape //INHERTANCE
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Square"); //POLYMORPHISM
    }
}
