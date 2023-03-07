using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpParticles : MonoBehaviour
{
    public GameObject dust;
    public bool jmpPrss = false;

    private void Start()
    {
        //dust.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            dust.SetActive(true);
            //Instantiate(dust, transform.position, transform.rotation);
            Debug.Log("W is gettig read");
        }
        else
        {
            Debug.Log("W isnt being read");
            dust.SetActive(false);
        }
    }
}
