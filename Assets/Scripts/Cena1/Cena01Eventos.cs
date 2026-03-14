using System.Collections;
using Unity.AppUI.UI;
using Unity.VectorGraphics.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Cena01Eventos : MonoBehaviour
{
    public GameObject fadeSreenIn;
    public GameObject caixaTexto;
    public GameObject charMateoFala;
    public GameObject falaMateo;
    [SerializeField] AudioSource bolaquicando;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject botaoProx;
    [SerializeField] int eventPos = 0;


    void Update()
    {
        textLength = CriadordeTexto.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }
    
    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "(Gira a bola de basquete nos dedos, mas ela escapa. Ele solta um riso soprado, sem graça)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        bolaquicando.Play();
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);

        //caixaTexto.SetActive(true);
        //yield return new WaitForSeconds(3);
        //charMateoFala.SetActive(true);
        //falaMateo.SetActive(true);
    }


}
