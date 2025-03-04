using UnityEngine;

public class Column : Shape //INHERITANCE
{
    public override void Action()
    {
        base.Action();
        WriteSomething("Column"); //POLYMORPHISM
    }
}
