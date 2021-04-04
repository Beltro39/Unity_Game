using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CardContainer;
    void Start()
    {
        StartCoroutine(InitialDraw());
    }

    // Update is called once per frame


    IEnumerator InitialDraw()
    {
        for(int i=0;i<4;i++) {
            yield return new WaitForSeconds(1);
            Instantiate(CardContainer,transform.position,transform.rotation);


        }
        

    }
}
