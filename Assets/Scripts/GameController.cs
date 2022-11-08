using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class GameController : MonoBehaviour
{
    private int randomNumber;
    public int clickCounter;


    private void Start()
    {
        randomNumber = Random.Range(1,11);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (HaveIWon())
            {
                Debug.Log("Que bueno eres no? Te sentirás bien por ganar un juegecito");
            }

        }
    }

    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }

    private bool HaveIWon()
    {
        if(clickCounter < randomNumber)
        {
            Debug.Log($"Cagaste, te has quedado corto. Has hecho {clickCounter} clicks pero el numero aleatorio era {randomNumber}");
            return false;
        } else if (clickCounter == randomNumber)
        {
            Debug.Log("Has superado mi juego, Enhorabuena!");
            return true;
        }
        Debug.Log("Te has pasado, que malo eres, no ganas ni a la patata caliente");
        Destroy(gameObject);
        return false;
    }
}
