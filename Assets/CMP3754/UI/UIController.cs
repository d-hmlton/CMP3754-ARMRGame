using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public PlaceObjectOnPlaneExtended planeObs;
    public TextMeshProUGUI txtmp;
    public ARMultiImageTracker tracker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtmp.text = "Duck Types Found: 0";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDuckCount();
    }

    public void UpdateDuckCount()
    {
        txtmp.text = "Duck Types Found: " + (tracker.foundDuckTypes.Count).ToString();
    }

    public void Button1Clicked()
    {
        int res = planeObs.QueryHighlighted();
        //Update text
        txtmp.text = "Count: "+res.ToString();
    }

    public void Button2Clicked()
    {
        planeObs.DeleteHighlighted();
    }

}
