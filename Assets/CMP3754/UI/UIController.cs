using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public PlaceObjectOnPlaneExtended planeObs;
    public TextMeshProUGUI txtmp;
    public ARMultiImageTracker tracker;
    public GameObject trophyPanel;

    private bool _gameWon = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtmp.text = "Swan Types Found: 0";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDuckCount();
        if ((tracker.foundSwanTypes.Count == 3) && (_gameWon == false))
        {
            trophyPanel.SetActive(true);
            _gameWon = true;
        }
    }

    public void UpdateDuckCount()
    {
        if (_gameWon == false)
        {
            txtmp.text = "Swan Types Found: " + (tracker.foundSwanTypes.Count).ToString();
        }
        else
        {
            txtmp.text = "Well Done!";
        }
    }

    public void Button1Clicked()
    {
        // Add functionality
    }

    public void Button2Clicked()
    {
        planeObs.DeleteHighlighted();
    }

}
