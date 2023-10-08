using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject finishLine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Debug.Log("Çizgi");
        }
    }
}



