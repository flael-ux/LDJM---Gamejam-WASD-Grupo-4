using System.Collections;
using Unity.AppUI.UI;
using Unity.VectorGraphics.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena01Eventos : MonoBehaviour
{
    public GameObject fadeSreenIn;
    public GameObject caixaTexto;
    public GameObject quadraEfeito;
    public GameObject charMateo;
    public GameObject charMateoFala;
    [SerializeField] AudioSource bolaquicando;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject botaoProx;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject botaoop1;
    [SerializeField] GameObject botaoop2;
    [SerializeField] GameObject botaoop3;
    [SerializeField] GameObject fadeOut;


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
        //evento 0
        yield return new WaitForSeconds(2);
        fadeSreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        charMateo.SetActive(true);
        mainTextObject.SetActive(true);
        caixaTexto.SetActive(true);
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
        eventPos = 1;
    }

    IEnumerator Evento01()
    {
        //evento 1
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "— Puta merda. Acho que eu perdi o jeito mesmo. Ou o ar daqui é mais pesado, sei lá.";
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
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Sentado no banco, encarando o nada) — É o prédio. Ele é... maior do que eu lembrava.";
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
        quadraEfeito.SetActive(false);
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Senta ao lado, jogando a bola de lado) — É. Quatro anos desde que a gente vinha aqui trazer o almoço dela nas quartas, né? Mudou nada. O mesmo cheiro de café forte e gente fingindo que sabe o que tá fazendo.";
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
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Suspira profundo e pesado) — Minha mãe nem olhou na minha cara hoje de manhã.";
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
        quadraEfeito.SetActive(false);
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Pausa) — O gim de novo?";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 6;
    }

    IEnumerator Evento06()
    {
        //evento 6
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "(Assente levemente) — Ela acha que eu tô caçando um fantasma. Me olhou como se eu tivesse indo pro matadouro. Nem \"boa sorte\" ela disse. Só... fechou a porta do quarto.";
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

    IEnumerator Evento07()
    {
        //evento 7
        quadraEfeito.SetActive(false);
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "Ela tá com medo, cara. É foda. Pra ela, se você tá aqui, a história não morreu. E ela só quer que a história morra pra ela conseguir dormir.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 8;
    }

    IEnumerator Evento08()
    {
        //evento 8
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Eu não consigo. Ficar naquela casa vendo ela se apagar enquanto o caso da Elisa vira papel mofado na delegacia... eu sentia que tava desaparecendo junto. Eu precisava entrar por aquela porta.";
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

    IEnumerator Evento09()
    {
        //evento 9
        quadraEfeito.SetActive(false);
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Dá um tapa no ombro de Gabriel, deixando a mão ali por um segundo) — Eu tô contigo, Gabe. Administração é um saco, eu devia tá em qualquer quadra de esporte por aí, mas... eu não ia te deixar vir pra esse hospício sozinho.";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        charMateoFala.SetActive(false);
        botaoProx.SetActive(true);
        eventPos = 10;
    }

    IEnumerator Evento10()
    {
        //evento 10
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charMateoFala.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Mateo";
        textToSpeak = "(Olha para um grupo de veteranos rindo alto perto dali) — Além disso... você viu como eles olham pra gente? Não parece que estão dando boas-vindas.";
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

    IEnumerator Escolha01()
    {
        //evento escolha 1
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoop1.SetActive(true);
        botaoop2.SetActive(true);  
        botaoop3.SetActive(true);

    }

    public void Escolha010p1()
    {
        StartCoroutine(Escolha01Op1());
    }

    public void Escolha010p2()
    {
        StartCoroutine(Escolha01Op2());
    }

    public void Escolha010p3()
    {
        StartCoroutine(Escolha01Op3());
    }

    IEnumerator Escolha01Op1()
    {
        //opção 1 da escolha 1
        botaoProx.SetActive(false);
        botaoop1.SetActive(false);
        botaoop2.SetActive(false);  
        botaoop3.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Deixa olharem. Se eles sabem de algo, eu vou fazer eles falarem.(Você escolheu um caminho mais agressivo e focado em confrontar a faculdade.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 12;

    }

    IEnumerator Escolha01Op2()
    {
        //opção 2 da escolha 1
        botaoProx.SetActive(false);
        botaoop1.SetActive(false);
        botaoop2.SetActive(false);  
        botaoop3.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Eu percebi. Vou manter a cabeça baixa até entender como as coisas funcionam aqui.(Você escolheu um caminho mais mais observador e que prefere agir nas sombras.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 12;

    }

    IEnumerator Escolha01Op3()
    {
        //opção 3 da escolha 1
        botaoProx.SetActive(false);
        botaoop1.SetActive(false);
        botaoop2.SetActive(false);  
        botaoop3.SetActive(false);
        caixaTexto.SetActive(true);
        quadraEfeito.SetActive(true);
        
        charName.GetComponent<TMPro.TMP_Text>().text = "Gabriel";
        textToSpeak = "Já me sinto um fantasma mesmo. Eles não podem quebrar o que já está morto.(Você escolheu um caminho mais mais fatalista e movido puramente pelo luto.)";
        caixaTexto.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        CriadordeTexto.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        botaoProx.SetActive(true);
        eventPos = 12;

    }
    
    IEnumerator Evento12()
    {
        //evento 12
        botaoProx.SetActive(false);
        caixaTexto.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(4);
        eventPos = 13;
        SceneManager.LoadScene("Cena2");
    }


    public void ProxEvento()
    {
        if (eventPos == 1)
        {
            StartCoroutine(Evento01());
        }
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
        if (eventPos == 11)
        {
            StartCoroutine(Escolha01());
        }
        if (eventPos == 12)
        {
            StartCoroutine(Evento12());
        }
    }


}
