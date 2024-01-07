using UnityEngine;

public class SelectAnswer : MonoBehaviour
{
    private BobSays _bobSays;
    private PhilSays _philSays;
    private void Start()
    {
        _bobSays = GameObject.FindObjectOfType<BobSays>().GetComponent<BobSays>();
        if (_bobSays == null)
        {
            Debug.LogError("SelectAnswer::BobSays is null");
        }
        _philSays = GameObject.FindObjectOfType<PhilSays>().GetComponent<PhilSays>();
        if (_philSays == null)
        {
            Debug.LogError("SelectAnswer::_philSays is null");
        }
    }
    public void AnswerSelection()
    {
        _philSays.MyChoices();
        _bobSays.BobsReplies();
        _philSays.ButtonReset();
    }
       
}
