using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector2(10 * x, 10 * y);
    }

    // Update is called once per frame
    
    void OnCollisionEnter(Collision batida)
    {
        audioSource.Play();
        if(batida.gameObject.name == "barreiraEsquerda" || batida.gameObject.name == "barreiraDireita")
        {
            transform.position = new Vector3(0, 0,12);
            Start();
        }
    }
    void Update()
    {

    }
}
