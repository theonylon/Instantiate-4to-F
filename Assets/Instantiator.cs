using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiator : MonoBehaviour
{
    
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtCloneAmount;


    public void CloneObject()
    {
        CloneAmount = int.Parse (txtCloneAmount.text);
        int i = 0;
        while (i<3)
        {
            Instantiate(objectToClone);
        }
        Instantiate(objectToClone);

    }
}
