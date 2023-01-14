using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesCoolDownS : MonoBehaviour
{
    public int coolDownTimerSAT, coolDownTimerP, coolDownTimerM;

    public TMPro.TextMeshProUGUI countdownSarrowType, countdownP, countdownM;

    void Start()
    {
        coolDownTimerSAT = -1;
        countdownSarrowType.text = "";
        coolDownTimerP= -1;
        countdownP.text = "";
        coolDownTimerM = -1;
        countdownM.text = "";
    }

    public void CooldownSarrowType()
    {
        coolDownTimerSAT = 15;
        StartCoroutine(CountDownSAT());

        IEnumerator CountDownSAT()
        {
            while (coolDownTimerSAT > -1)
            {
                countdownSarrowType.text = coolDownTimerSAT.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerSAT--;
            }

            countdownSarrowType.text = "";

            if (coolDownTimerSAT == 0)
            {
                countdownSarrowType.text = "";
            }

        }
    }

    public void CooldownPierce()
    {
        coolDownTimerP = 10;
        StartCoroutine(CountDownP());

        IEnumerator CountDownP()
        {
            while (coolDownTimerP > -1)
            {
                countdownP.text = coolDownTimerP.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerP--;
            }

            countdownP.text = "";

            if (coolDownTimerP == 0)
            {
                countdownP.text = "";
            }

        }
    }

    public void CooldownMultiple()
    {
        coolDownTimerM = 15;
        StartCoroutine(CountDownM());

        IEnumerator CountDownM()
        {
            while (coolDownTimerM > -1)
            {
                countdownM.text = coolDownTimerM.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerM--;
            }

            countdownM.text = "";

            if (coolDownTimerM == 0)
            {
                countdownM.text = "";
            }

        }
    }
}
