using System.Collections;
using Unity.AppUI.UI;
using Unity.VectorGraphics.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Cena02Evento : MonoBehaviour
{
    public GameObject caixaTexto;
    [SerializeField] GameObject fadeSreenIn;
    [SerializeField] GameObject corredorEfeitoMateo;
    [SerializeField] GameObject corredorEfeitoGab;
    [SerializeField] GameObject charMateo;
    [SerializeField] GameObject charMateoFala;
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
        StartCoroutine(Event01());
    }

    void Update()
    {
        textLength = CriadordeTexto.charCount;
    }

    IEnumerator Event01()
    {
        //evento 1
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charMateo.SetActive(true);
        yield return new WaitForSeconds(2);
        charMateoFala.SetActive(true);
        corredorEfeitoMateo.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Encostado na parede) — Você tá falando sério? Onde foi que você ouviu isso? Se for mais uma dessas teorias de fórum da internet, Gabe...";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 2;

    }

    IEnumerator Evento02()
    {
        //evento 2
        yield return new WaitForSeconds(2);
        corredorEfeitoMateo.SetActive(false);
        corredorEfeitoGab.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Olhando para o celular) — Não foi na internet. Foi no atendimento hoje. O Dr. ?pipipi? soltou um comentário... \"por acaso\".";
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

    IEnumerator Evento03()
    {
        //evento 3
        yield return new WaitForSeconds(2);
        charMateoFala.SetActive(true);
        corredorEfeitoGab.SetActive(false);
        corredorEfeitoMateo.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Franze o cenho) — O teu psicólogo? O que ele tem a ver com isso?";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 4;

    }

    IEnumerator Evento04()
    {
        //evento 4
        yield return new WaitForSeconds(2);
        corredorEfeitoMateo.SetActive(false);
        corredorEfeitoGab.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Ele disse que a Elisa estava \"evoluindo\" em um grupo de desenvolvimento aqui da faculdade antes de sumir. Falou que era algo exclusivo, só para alunos com o \"perfil certo\". Ele não disse o nome, mas mencionou um teste de aptidão que acontece...";
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

    IEnumerator Evento05()
    {
        //evento 5
        yield return new WaitForSeconds(2);
        corredorEfeitoMateo.SetActive(false);
        corredorEfeitoGab.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "...amanhã à noite.";
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

    IEnumerator Evento06()
    {
        //evento 6
        yield return new WaitForSeconds(2);
        charMateoFala.SetActive(true);
        corredorEfeitoGab.SetActive(false);
        corredorEfeitoMateo.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "Cara, isso é estranho pra cacete. Grupo de desenvolvimento? Eu nunca ouvi falar de nada secreto que não seja trote de veterano babaca.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 7;

    }

    IEnumerator Evento07()
    {
        //evento 7
        yield return new WaitForSeconds(2);
        corredorEfeitoMateo.SetActive(false);
        corredorEfeitoGab.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Exato. Ninguém ouviu falar. Mas ele deu o endereço e a sala como se fosse um conselho médico. Ele sabe de algo, Mateo. Ele conhecia ela melhor do que a nossa mãe naquela época.";
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

    IEnumerator Evento08()
    {
        //evento 8
        yield return new WaitForSeconds(2);
        charMateoFala.SetActive(true);
        corredorEfeitoGab.SetActive(false);
        corredorEfeitoMateo.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Pausa) — Não sei, não. Um psicólogo te empurrando pra um \"teste\" fora do horário de aula? Se esse grupo é tão secreto, por que ele te contaria?";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 9;

    }

    IEnumerator Evento09()
    {
        //evento 9
        yield return new WaitForSeconds(2);
        corredorEfeitoMateo.SetActive(false);
        corredorEfeitoGab.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Porque ele sabe que eu não vou parar até descobrir o que aconteceu. Talvez ele ache que eu tenho o mesmo \"perfil\" que ela. Eu preciso ir, Mateo. Se a Elisa passou por essa porta, é por ela que eu vou entrar.";
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

    IEnumerator Evento10()
    {
        //evento 10
        yield return new WaitForSeconds(2);
        charMateoFala.SetActive(true);
        corredorEfeitoGab.SetActive(false);
        corredorEfeitoMateo.SetActive(true);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Suspira) — Tá. Mas eu vou junto. Fico na porta do bloco. Se isso for uma armadilha desse doutor, eu não vou deixar você ser o próximo nome numa pasta arquivada.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 11;

    }

    //fazer evento 11 de escolha de fala de gabriel.

    public void ProxEvento()
    {
        if (eventPos == 2)
        {
            StartCoroutine(Evento02());
        }
        if (eventPos == 3)
        {
            StartCoroutine(Evento03());
        }
        if (eventPos == 4)
        {
            StartCoroutine(Evento04());
        }
        if (eventPos == 5)
        {
            StartCoroutine(Evento05());
        }
        if (eventPos == 6)
        {
            StartCoroutine(Evento06());
        }
        if (eventPos == 7)
        {
            StartCoroutine(Evento07());
        }
        if (eventPos == 8)
        {
            StartCoroutine(Evento08());
        }
        if (eventPos == 9)
        {
            StartCoroutine(Evento09());
        }
        if (eventPos == 10)
        {
            StartCoroutine(Evento10());
        }
    }
}
