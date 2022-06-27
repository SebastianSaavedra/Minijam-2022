using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUPTipe : MonoBehaviour
{
    [SerializeField] string type;
    void Start()
    {
        switch (type) 
        {
            case "Normal":
                if (PopManager.instancia.normal)
                {
                    Debug.Log("Normal stoped via firewall");
                    Destroy(gameObject);
                }
                else 
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;

            case "Scale":
                if (PopManager.instancia.scale)
                {
                    Debug.Log("Scaled stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
            case "FollowUp":
                if (PopManager.instancia.follow)
                {
                    Debug.Log("Follower stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
            case "Stick":
                if (PopManager.instancia.siemprePegado)
                {
                    Debug.Log("StickWithMe stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
            case "Corner":
                if (PopManager.instancia.corner)
                {
                    Debug.Log("Cornered stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
            case "Giratorio":
                if (PopManager.instancia.giratorio)
                {
                    Debug.Log("BreakDancer stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
            case "ManyX":
                if (PopManager.instancia.manyX)
                {
                    Debug.Log("CantCloseMe stoped via firewall");
                    Destroy(gameObject);
                }
                else
                {
                    PopManager.instancia.ram -= 0.1f;
                }
                break;
        }
    }
}
