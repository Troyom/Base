using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentManager : MonoBehaviour
{
    GameObject[] agents;

    void Start() { 
        //Procura o GameObject
        agents = GameObject.FindGameObjectsWithTag("ai"); 
    }

    void Update()
    {   
        //Ativa ao apertar o botao
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        { 
                //Adiciona o destino
                foreach (GameObject a in agents) a.GetComponent<AIControl>().agent.SetDestination(hit.point); }
        
        }
    }
}
