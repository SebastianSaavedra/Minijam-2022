using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SebaCode
{
    public class SpawnPopUp : MonoBehaviour
    {
        [SerializeField] GameObject pf_Popup;
        [SerializeField] float _time, _repeatRate;
        [SerializeField] Transform canvas;
        void Start()
        {
            InvokeRepeating("Spawn", _time, _repeatRate);
        }
        void Spawn()
        {
            GameObject popup = Instantiate(pf_Popup, canvas);
            RectTransform rectTransform = popup.GetComponent<RectTransform>();
            popup.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-500, 500), Random.Range(-500, 500));
        }
    }
}
