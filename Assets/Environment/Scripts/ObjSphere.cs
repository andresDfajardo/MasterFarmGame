using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjSphereScript : MonoBehaviour
{
    public int numDeObjetivos;
    public int numDeObjetivos2;
    public TextMeshProUGUI textMision;
    public TextMeshProUGUI textMision2;
    public GameObject panel;
    public LogicNPC NPCGirl;
    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = GameObject.FindGameObjectsWithTag("Point").Length;
        numDeObjetivos2 = GameObject.FindGameObjectsWithTag("Point2").Length;
        textMision.text = "Atrapa las esferas rojas para llegar a la primera misi�n." +
                            "\n Restantes: " + numDeObjetivos;
        NPCGirl = GameObject.FindGameObjectWithTag("NPCGirl").GetComponent<LogicNPC>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Point")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textMision.text = "Atrapa las esferas rojas para llegar a la primera misi�n." +
                            "\n Restantes: " + numDeObjetivos;
            if (numDeObjetivos <= 0)
            {
                NPCGirl.jugadorCerca = true;
                textMision.text = "Llegaste, habla con Ana, presiona 'X'.";
            }
        }
        if (col.gameObject.tag == "Point2")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos2--;
            textMision2.text = "�Sab�as que el ma�z no solo es un alimento b�sico para las gallinas, sino que tambi�n puede influir en el color de sus yemas de huevo, haciendo que sean m�s intensas cuando consumen una dieta rica en este cereal?" +
                            "\n Atrapa las esferas rojas para llegar a la segunda granja." +
                            "\n Restantes: " + numDeObjetivos2;
            if (numDeObjetivos2 <= 0)
            {
                textMision2.text = "Llegaste, esta es la granja de Juan.";
            }
        }
    }
}
