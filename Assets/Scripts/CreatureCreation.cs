﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCreation : MonoBehaviour
{
    public GameObject parent;

    public List<GameObject> creatures;
    Vector3 v;
    GameObject go;

    public GameObject body;
    public GameObject[] ears;
    public GameObject[] horns;
    public GameObject[] snoot;
    public GameObject[] tail;
    public GameObject[] feet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                parent = new GameObject("Parent" + creatures.Count);
                parent.transform.position = hit.point;
                genCreature();
                creatures.Add(parent);
            }
            

        }
    }

    public void Randomize()
    {     
        int num;
        Instantiate(body, parent.transform);
        num = Random.Range(0, ears.Length);
        Instantiate(ears[num], parent.transform);
        num = Random.Range(0, feet.Length);
        Instantiate(feet[num], parent.transform);
        num = Random.Range(0, snoot.Length);
        Instantiate(snoot[num], parent.transform);
        num = Random.Range(0, tail.Length);
        Instantiate(tail[num], parent.transform);


        num = Random.Range(0, 2);
        if (num == 0)
        {
            Instantiate(horns[num], parent.transform);
        }

       
    }

    private void genCreature()
    {
        int num;
        Instantiate(body, parent.transform);
        num = Random.Range(0, ears.Length);
        Instantiate(ears[num], parent.transform);
        num = Random.Range(0, feet.Length);
        Instantiate(feet[num], parent.transform);
        num = Random.Range(0, snoot.Length);
        Instantiate(snoot[num], parent.transform);
        num = Random.Range(0, tail.Length);
        Instantiate(tail[num], parent.transform);


        num = Random.Range(0, 2);
        if (num == 0)
        {
            Instantiate(horns[num], parent.transform);
        }

    }
   
}


