using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlesspawners : MonoBehaviour
{
    public GameObject spawner;
    public float spawnerRate = 4;
    private float timer = 0;
    public float heightOffSet =11;
    // Start is called before the first frame update
    void Start()
    {
        spawnerice();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnerRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnerice();
            timer = 0;
        }
        
    }
    void spawnerice()
        {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;

        Instantiate(spawner, new Vector3(transform.position.x, Random.Range(highestPoint , lowestPoint) , 0) , transform.rotation);
        }
        
}
