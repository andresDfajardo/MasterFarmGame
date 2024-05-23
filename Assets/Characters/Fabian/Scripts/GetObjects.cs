using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetObjects : MonoBehaviour
{
    #region Variables
    public TakeObject take;
    public TextMeshProUGUI textMision1;
    public TextMeshProUGUI textMision11;
    public TextMeshProUGUI textMision2;
    public TextMeshProUGUI textMision21;
    public TextMeshProUGUI textMision3;
    public GameObject mision3;
    public GameObject cow1;
    public GameObject hen1;
    public GameObject pig1;
    public GameObject wheat2;
    public GameObject egg2;
    public GameObject obstacle;
    public GameObject panelInicial;
    public GameObject panelMision1;
    public GameObject panelFinMision1;
    public GameObject panelMision11;
    public GameObject panelMision2;
    public GameObject panelMision21;
    public GameObject panelMision3;
    public GameObject activateHen;
    public GameObject activateCow;
    public GameObject activatePig;
    public GameObject activateWheat;
    public GameObject activateEgg;
    public GameObject activateCorn;
    public GameObject activateCarrot;
    public GameObject activateTomato;
    public GameObject corralPig;
    public GameObject corralCow;
    public GameObject corralHen;
    public GameObject corralPig3;
    public GameObject corralCow3;
    public GameObject corralHen3;
    public GameObject otherWheat;
    public GameObject otherEgg;
    public GameObject corn;
    public GameObject tomato;
    public GameObject carrot;
    public FabianMove player;
    public bool mision1 = false;
    public bool mision2 = false;
    public bool cow = false;
    public bool pig = false;
    public bool hen = false;
    public bool wheat = false;
    public bool egg = false;
    public bool bag = false;
    public bool corn3 = false;
    public bool carrot3 = false;
    public bool tomato3 = false;
    public int animalsCount = 3;
    public int objectsCount = 2;
    public int objectsCount3 = 3;
    #endregion

    void Start()
    {
        take = GameObject.FindGameObjectWithTag("Hand").GetComponent<TakeObject>();
        take.enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        #region Primera Mision
        if (other.CompareTag("Inicio1Mision"))
        {
            Destroy(other.gameObject);
            panelInicial.SetActive(false);
            panelMision1.SetActive(true);
        }
        if (other.CompareTag("Activate1Mision"))
        {
            Destroy(other.gameObject);
            textMision1.text = "Press 'X' to talk with Ana.";
            mision1 = true;
        }
        if (other.CompareTag("ActivateHen"))
        {
            Destroy(other.gameObject);
            hen = true;
        }
        if (other.CompareTag("ActivateCow"))
        {
            Destroy(other.gameObject);
            cow = true;
        }
        if (other.CompareTag("ActivatePig"))
        {
            Destroy(other.gameObject);
            pig = true;
        }
        if (other.CompareTag("CorralHen"))
        {
            Destroy(other.gameObject);
            hen = true;
        }
        if (other.CompareTag("CorralPig"))
        {
            Destroy(other.gameObject);
            pig = true;
        }
        if (other.CompareTag("CorralCow"))
        {
            Destroy(other.gameObject);
            cow = true;
        }
        #endregion
        #region Segunda Mision
        if (other.CompareTag("Activate2Mision"))
        {
            Destroy(other.gameObject);
            Destroy(panelFinMision1.gameObject);
            animalsCount = 3;
            objectsCount = 2;
            panelMision2.SetActive(true);
            mision1 = false;
            mision2 = true;
            Vector3 posicionJugador = new Vector3(transform.position.x, player.gameObject.transform.position.y, transform.position.z);
            player.gameObject.transform.LookAt(posicionJugador);
            player.enabled = false;
        }
        if (other.CompareTag("ActivateWheat"))
        {
            Destroy(other.gameObject);
            wheat = true;
        }
        if (other.CompareTag("ActivateEgg"))
        {
            Destroy(other.gameObject);
            egg = true;
        }
        if (other.CompareTag("Bag2"))
        {
            bag = true;
        }
        #endregion
        #region Tercera Mision
        if (other.CompareTag("Activate3Mision"))
        {
            Destroy(other.gameObject);
            panelMision21.SetActive(false);
            panelMision3.SetActive(true);
            corn.SetActive(true);
            carrot.SetActive(true);
            tomato.SetActive(true);
            hen = false;
            cow = false;
            pig = false;
        }
        if (other.CompareTag("ActivateCorn"))
        {
            Destroy(other.gameObject);
            corn3 = true;
            corralHen3.SetActive(true);
        }
        
        if (other.CompareTag("ActivateCorralHen"))
        {
            Destroy(other.gameObject);
            hen = true;
        }
        if (other.CompareTag("ActivateCorralCow"))
        {
            Destroy(other.gameObject);
            cow = true;
        }
        if (other.CompareTag("ActivateCorralPig"))
        {
            Destroy(other.gameObject);
            pig = true;
        }
        #endregion
    }
    private void OnTriggerExit(Collider other)
    {
        //Segunda Mision
        if (other.CompareTag("Bag2"))
        {
            bag = false;
        }
    }
    void Update()
    {
#region Primera Misión
        if (Input.GetKeyDown(KeyCode.X) && mision1 == true)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, player.gameObject.transform.position.y, transform.position.z);
            player.gameObject.transform.LookAt(posicionJugador);
            player.enabled = false;
            panelMision11.SetActive(true);
            panelMision1.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q)&& player.enabled == false && mision1 == true)
        {
            panelMision11.SetActive(true);
            player.enabled = true;
            cow1.SetActive(true);
            hen1.SetActive(true);
            pig1.SetActive(true);
            activateHen.SetActive(true);
            activateCow.SetActive(true);
            activatePig.SetActive(true);
            textMision11.text = "Press 'E' to pick up an animal." +
                             "\n Press 'R' to release it in its respective stable.";
        }
        if (Input.GetKeyDown(KeyCode.Q)&& player.enabled == false && mision2 == true)
        {
            panelMision2.SetActive(false);
            panelMision21.SetActive(true);
            player.enabled = true;
            wheat2.SetActive(true);
            egg2.SetActive(true);
            activateEgg.SetActive(true);
            activateWheat.SetActive(true);
            textMision21.text = "Press 'E' to pick up an object." +
                             "\n Press 'R' to release it in its respective basket.";
        }
        if (Input.GetKeyDown(KeyCode.E) && hen == true)
        {
            hen = false;
            corralHen.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && cow == true)
        {
            cow = false;
            corralCow.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && pig == true)
        {
            pig = false;
            corralPig.SetActive(true);
        }
        if (animalsCount <= 0)
        {
            panelMision11.SetActive(false);
            panelFinMision1.SetActive(true);
            Destroy(obstacle.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.R) && cow == true || Input.GetKeyDown(KeyCode.R) && pig == true ||Input.GetKeyDown(KeyCode.R) && hen == true)
        {
            cow = false; pig = false; hen = false;
            animalsCount--;
            textMision11.text = "You have " + animalsCount + " animal(s) left to find.";
        }
        #endregion
#region Segunda Misión
        if (Input.GetKeyDown(KeyCode.E) && wheat == true)
        {
            pig = false;
        }
        if (Input.GetKeyDown(KeyCode.R) && wheat == true && bag == true || Input.GetKeyDown(KeyCode.R) && egg == true && bag == true)
        {
            if (wheat == true)
            {
                objectsCount--;
                wheat = false;
                BoxCollider boxWheat = otherWheat.GetComponent<BoxCollider>();
                boxWheat.enabled = false;
            }
            else if (egg == true)
            {
                objectsCount--;
                egg = false;
                BoxCollider boxEgg = otherEgg.GetComponent<BoxCollider>();
                boxEgg.enabled = false;
            }
        }
        if (objectsCount == 1)
        {
            textMision21.text = "You have 1 more object to find.";
        }
        if (objectsCount <= 0)
        {
            textMision21.text = "Thank you very much! I will be able to make the compost and " +
                                "\n congratulations! On your farm you will find the third mission."+
                                "\n If you want, you can drive my car.";
            mision3.SetActive(true);
            objectsCount = 3;
        }
        #endregion
# region Tercera Misión
        if (Input.GetKeyDown(KeyCode.R) && corn3 == true && hen == true || Input.GetKeyDown(KeyCode.R) && carrot3 == true && cow == true || Input.GetKeyDown(KeyCode.R) && tomato3 == true && pig == true)
        {
            if (corn3 == true && hen == true)
            {
                objectsCount3--;
                textMision3.text = "Thank you, you still have" + objectsCount3 + "animals left to feed! ";
            }
            else if (carrot3 == true && cow == true)
            {
                objectsCount3--;
                textMision3.text = "Thank you, you still have" + objectsCount3 + "animals left to feed! ";
            }else if (tomato3 == true && pig == true)
            {
                objectsCount3--;
                textMision3.text = "Congratulations, you finished the game!";
            }
        }
        if (objectsCount3 == 0)
        {
            player.enabled = false;
        }
        #endregion

    }
}
