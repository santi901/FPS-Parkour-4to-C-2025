using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updateMoneyTxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}
