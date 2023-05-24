using UnityEngine;
using UnityEngine.UI;

public class CollectablesUI : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Text countText;

    void Update()
    {
        countText.text = "Collected: " + playerMovement.collectables.Count.ToString();
    }
}