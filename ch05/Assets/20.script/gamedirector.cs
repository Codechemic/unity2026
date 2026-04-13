using UnityEngine;
using UnityEngine.UI;

public class gamedirector : MonoBehaviour
{
    public Image hpgauge;
    public void DecreaseHP()
    {
        hpgauge.fillAmount += 0.1f;
    }
}
