using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    

    //Display currency UI
    private void OnGUI()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
    }
}
