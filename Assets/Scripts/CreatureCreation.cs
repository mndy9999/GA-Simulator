using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Polarith.AI.Move;

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

    public GameObject tree;
    public GameObject shroom;



    private void Update()
    {
        if(creatures.Count < 20)
        {
            genCreatureRandom();
        }
        Debug.Log(creatures.Count);
        
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

    public void genCreatureAtMousePos()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            foreach (Transform child in parent.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            Instantiate(parent);


            parent.transform.position = hit.point;
            parent.transform.rotation = Quaternion.Euler(Random.Range(0, 360), 0, Random.Range(0, 360));

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
            
            creatures.Add(parent);
        }

        

    }

    public void genCreatureRandom()
    {

        foreach (Transform child in parent.transform)
        {
            Debug.Log("Deleted");
            GameObject.Destroy(child.gameObject);
        }
        Instantiate(parent);
        //parent.GetComponent<AIMSimpleController>().Speed = 100;

        parent.transform.position = new Vector3(Random.Range(0, 255), 0, Random.Range(0, 255));
        parent.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);

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

        creatures.Add(parent);

    }
   
   
    public void genTree()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.transform.tag != "Tree")
            {
                Instantiate(tree, hit.point, Quaternion.Euler(-90, 0, 0));
                tree.transform.tag = "Tree";
                
            }
            
        }
    }

    public void genShroom()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag != "Shroom")
            {
                Instantiate(shroom, hit.point, Quaternion.identity);
                tree.transform.tag = "Shroom";

            }

        }
    }
}


