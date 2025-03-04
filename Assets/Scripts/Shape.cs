using UnityEngine;

public class Shape : MonoBehaviour
{
    public Color OwnColor { get; protected set; }

    void Start()
    {
        OwnColor = gameObject.GetComponent<Renderer>().material.color;
    }

    public virtual void Action() 
    {
        MainManager.Instance.Camera.backgroundColor = OwnColor;
    }

    protected void WriteSomething(string text)
    {
        //Debug.Log(text);
        MainManager.Instance.InfoText = text;
    }
}
