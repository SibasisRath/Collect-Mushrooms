using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            other.gameObject.SetActive(false);
            GameObject.Find("GameManager").GetComponent<GameManager>().Score++;
        }
        if (other.gameObject.CompareTag("DeadZone"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("restart");
        }
    }
}
