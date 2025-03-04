using UnityEngine;

public class Square : Shape
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Square");
    }
}
