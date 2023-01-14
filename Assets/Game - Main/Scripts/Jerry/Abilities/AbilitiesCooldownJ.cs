using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesCooldownJ : MonoBehaviour
{

    public int coolDownTimerJH, coolDownTimerJI;

    public TMPro.TextMeshProUGUI countdownJHeal, countdownJInvis;

    void Start()
    {
        coolDownTimerJH = -1;
        countdownJHeal.text = "";
        coolDownTimerJI = -1;
        countdownJInvis.text = "";
    }


    public void CooldownJHeal()
    {
        coolDownTimerJH = 10;
        StartCoroutine(CountDownJH());

        IEnumerator CountDownJH()
        {
            while (coolDownTimerJH > -1)
            {
                countdownJHeal.text = coolDownTimerJH.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerJH--;
            }

            countdownJHeal.text = "";

            if (coolDownTimerJH == 0)
            {
                countdownJHeal.text = "";
            }

        }
    }

    public void CooldownJInvis()
    {
        coolDownTimerJI = 15;
        StartCoroutine(CountDownJH());

        IEnumerator CountDownJH()
        {
            while (coolDownTimerJI > -1)
            {
                countdownJInvis.text = coolDownTimerJI.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerJI--;
            }

            countdownJInvis.text = "";

            if (coolDownTimerJI == 0)
            {
                countdownJInvis.text = "";
            }

        }
    }
}
