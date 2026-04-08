using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheng : MonoBehaviour
{
    [SerializeField] private GameObject firstconvas;
    [SerializeField] private GameObject secondconvas;
    private GameObject convas;
    private void Start()
    {
        firstconvas.SetActive(true);
        convas = firstconvas;
    }
    public void ChangeState(GameObject state)

    {   
        if(convas != null) 
        {
            convas.SetActive(false);
            state.SetActive(true);
            convas = state; 
        }
    }
}
 