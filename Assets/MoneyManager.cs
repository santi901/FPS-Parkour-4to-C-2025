using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
<<<<<<< HEAD
    public float money;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateMoneyTxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
=======

    public float money;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void updatemoney(float moneyToAdd)
>>>>>>> 33af1b07c85a03898855aeb09da046e48cbe4825
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }
        money += moneyToAdd;
<<<<<<< HEAD
        uiManager.UpdateMoneyTxt(money.ToString());
=======
        uiManager.updateMoneyTxt(money.ToString());
>>>>>>> 33af1b07c85a03898855aeb09da046e48cbe4825
    }
}
