using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class LogicNPC : MonoBehaviour
{
    //public GameObject simboloMision;
    public FabianMove player;
    public GameObject panelNPC;
    public GameObject panelNPC2;
    public GameObject panelNPCMision;
    public GameObject tomato;
    public bool jugadorCerca;
    public GameObject[] objetivo;
    public int scene;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<FabianMove>();
        //simboloMision.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && jugadorCerca == true)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, player.gameObject.transform.position.y, transform.position.z);
            player.gameObject.transform.LookAt(posicionJugador);
            player.enabled = false;
            panelNPC.SetActive(false);
            panelNPC2.SetActive(true);
            scene = 1;
        }
        if (Input.GetKeyDown(KeyCode.Q) && scene == 1)
        {
            player.enabled = true;
            panelNPC2.SetActive(false);
            panelNPCMision.SetActive(true);
            //simboloMision.SetActive(false);
            tomato.SetActive(true);
            jugadorCerca = false;
            scene = 2;
        }
    }
}
