using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; } //ENCAPSULATION
    public Camera Camera;
    public TextMeshProUGUI info;

    private string _infoText = "";
    public string InfoText //ENCAPSULATION
    {
        get { return _infoText; }
        set 
        {
            if(value != null) _infoText = value;
        }
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var clickedShape = IsClicked();
            if (clickedShape != null)
            {
                clickedShape.Action();
                info.text = InfoText;
            }
        }
    }

    public Shape IsClicked()
    {
        var ray = Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            return hit.collider.GetComponentInParent<Shape>();
        }
        return null;
    }
}
