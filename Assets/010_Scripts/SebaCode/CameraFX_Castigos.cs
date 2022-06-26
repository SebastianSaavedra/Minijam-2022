using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraFX_Castigos : MonoBehaviour
{
    [SerializeField] GameObject glitchedScreen, screenInvertedColor, screenShake;
    [SerializeField] float _timer = 1;

    public void CameraFX(string tipo)
    {
        switch (tipo)
        {
            case "Glitch":
                DeactiveAll();
                StartCoroutine(FX(glitchedScreen, _timer));
                break;
            case "Inverted":
                DeactiveAll();
                StartCoroutine(FX(screenInvertedColor, _timer));
                break;
            case "Shake":
                DeactiveAll();
                StartCoroutine(FX(screenShake, _timer));
                break;
        }
    }

    void DeactiveAll()
    {
        glitchedScreen.SetActive(false);
        screenInvertedColor.SetActive(false);
        screenShake.SetActive(false);
    }

    IEnumerator FX(GameObject _screenFX, float timer)
    {
        yield return new WaitForSeconds(.1f);
        _screenFX.SetActive(true);
        yield return new WaitForSeconds(timer);
        gameObject.SetActive(false);
        yield break;
    }
}
