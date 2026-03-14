using System.Collections;
using UnityEngine;

public class Cena01Eventos : MonoBehaviour
{
    public GameObject fadeSreenIn;
    public GameObject charMateo;
    public GameObject basketball;
    void Start()
    {
        StartCoroutine(EventStarter());
    }
    
    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(4);
        basketball.SetActive(true);
        //narração o erro da bola de Mateo
        yield return new WaitForSeconds(2);
        charMateo.SetActive(true);

    }

}
