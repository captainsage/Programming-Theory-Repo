using UnityEngine;

public class Circle : Shape
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Circle");
    }
}
