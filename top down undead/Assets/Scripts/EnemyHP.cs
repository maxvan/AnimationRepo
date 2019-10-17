using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    public int health = 2;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health = health - 1;

            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
