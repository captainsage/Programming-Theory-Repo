using UnityEngine;

public class Column : Shape
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Column");
    }
}
