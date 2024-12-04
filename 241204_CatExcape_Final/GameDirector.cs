using UnityEngine;
using UnityEngine.UI; //잊지말고 추가!
public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
