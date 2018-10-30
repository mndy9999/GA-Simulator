using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureCreation : MonoBehaviour
{
    public GameObject parent;

    public List<GameObject> creatures;
    Vector3 v;
    GameObject go;

    bool wolfActive;

    public GameObject body;
    public GameObject[] ears;
    public GameObject[] horns;
    public GameObject[] snoot;
    public GameObject[] tail;
    public GameObject[] feet;

    public GameObject tree;

    private void Start()
    {
        wolfActive = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            


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

    public void genCreature()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            parent = new GameObject("Parent" + creatures.Count);
            parent.transform.position = hit.point;
            parent.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, Random.Range(0, 360), gameObject.transform.rotation.z);
            parent.AddComponent<NavMeshAgent>();
            //parent.AddComponent<RandomWalk>();
            
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
   
   
    public void genTree()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Instantiate(tree, hit.point, Quaternion.Euler(-90, 0, 0));
            //tree.transform.position = hit.point;
        }
    }
}


