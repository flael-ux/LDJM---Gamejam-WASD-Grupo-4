using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena4Evento1 : MonoBehaviour
{
    public GameObject caixaTexto;
    [SerializeField] GameObject fadeSreenIn;
    [SerializeField] GameObject salaEfeitoGab;
    [SerializeField] AudioSource musicaTensa;
    [SerializeField] GameObject charGab;
    [SerializeField] GameObject charGabFace;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject botaoProx;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;

    void Start()
    {
        StartCoroutine(Event00());
    }

    void Update()
    {
        textLength = CriadordeTexto.charCount;
    }

    IEnumerator Event00()
    {
        //evento 00
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) — 22:45. O último sinal tocou faz quase uma hora. O silêncio aqui é diferente do silêncio de casa. Em casa, o silêncio cheira a gim e mofo. Aqui... cheira a dor e expectativa.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 1;
    }

    IEnumerator Event01()
    {
        //evento 01
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Gabriel tira o celular do bolso. O brilho da tela ilumina seu rosto. Ele abre a galeria de fotos. Rola até uma foto antiga, tremida. É a Elisa, rindo, com um jaleco branco amassado.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 2;

    }

    IEnumerator Event02()
    {
        //evento 02
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) Você estava tão orgulhosa desse jaleco. \"Psicologia não é só ouvir, Gabe, é entender\", você disse. Eu não entendi nada na época. Eu só queria saber se você ia me levar pra ver o jogo do Mateo no sábado.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 3;
    }

    IEnumerator Event03()
    {
        //evento 03
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Ele desliga a tela. O escuro volta.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 4;
    }

    IEnumerator Event04()
    {
        //evento 04
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) Se eu tivesse prestado atenção... se eu não fosse o garoto que \"nunca se esforçava pra nada\"... será que eu teria visto algo falhando em você?";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 5;
    
    }

    IEnumerator Event05()
    {
        //evento 05
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        musicaTensa.Play();
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Um estalo alto vem do corredor. Gabriel encosta a cabeça na parede, fechando os olhos.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 6;
    }

    IEnumerator Event06()
    {
        //evento 06
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) O Dr. disse que você estava \"evoluindo\". Que palavra maldita. A gente evolui pra virar outra coisa. Pra deixar o que era pra trás. Foi isso que você fez, Elisa? Você evoluiu tanto que a gente não cabia mais na sua vida?";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 7;
    }

    IEnumerator Event07()
    {
        //evento 07
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Ele aperta a alça da mochila.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 8;
    }

    IEnumerator Event08()
    {
        //evento 08
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) Não. Você não nos deixaria com esse vazio. Alguém te ajudou a sumir. E esse \"alguém\" está esperando na sala interditada. O Mateo acha que é um jogo de veteranos. Mas eu sinto... que é o matadouro que a mãe teme.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 9;
    }

    IEnumerator Event09()
    {
        //evento 09
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Ele se levanta devagar.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 10;
    }

    IEnumerator Event10()
    {
        //evento 10
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charGab.SetActive(true);
        yield return new WaitForSeconds(2);
        salaEfeitoGab.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Pensamento) Chega de esperar. Se eu morrer tentando te achar, pelo menos eu morro fazendo algum esforço. Pela primeira vez na vida.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 11;
    }
    public void ProxEvento()
    {
        if (eventPos == 1)
        {
            StartCoroutine(Event01());
        }
        if (eventPos == 2)
        {
            StartCoroutine(Event02());
        }
        if (eventPos == 3)
        {
            StartCoroutine(Event03());
        }
        if (eventPos == 4)
        {
            StartCoroutine(Event04());
        }
        if (eventPos == 5)
        {
            StartCoroutine(Event05());
        }
        if (eventPos == 6)
        {
            StartCoroutine(Event06());
        }
        if (eventPos == 7)
        {
            StartCoroutine(Event07());
        }
        if (eventPos == 8)
        {
            StartCoroutine(Event08());
        }
        if (eventPos == 9)
        {
            StartCoroutine(Event09());
        }
        if (eventPos == 10)
        {
            StartCoroutine(Event10());
        }
    }
}
