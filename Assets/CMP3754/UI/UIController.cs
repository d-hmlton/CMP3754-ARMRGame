using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public PlaceObjectOnPlaneExtended planeObs;
    public TextMeshProUGUI txtmp;
    public ARMultiImageTracker tracker;
    public GameObject trophyPanel;
    public GameObject achievementPop;

    private int _lastCount = 0;
    public float _time = 0.0f;
    private bool _popActive = false;
    private bool _gameWon = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtmp.text = "Swan Types Found: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker.foundSwanTypes.Count > _lastCount)
        {
            _lastCount += 1;
            UpdateDuckCount();

            if ((_lastCount == 3) && (_gameWon == false))
            {
                if (_popActive == true) { DeactivatePop(); }
                _gameWon = true;
                trophyPanel.SetActive(true);
            }
            else
            {
                ActivatePop();
            }
        }

        if (_popActive == true) { _time += Time.deltaTime; }
        if (_time > 3) { DeactivatePop(); }
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

    public void ActivatePop()
    {
        _popActive = true;
        achievementPop.SetActive(true);
        return;
    }

    public void DeactivatePop()
    {
        _time = 0;
        _popActive = false;
        achievementPop.SetActive(false);
        return;
    }
}
