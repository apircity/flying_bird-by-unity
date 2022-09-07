using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject pipe;
    public float time;
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>time)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position=new Vector3(6, Random.Range(-1.7f, 5.7f),0);
            timer=0;
            Destroy(newpipe, 8.0f);
        }
    }

    
}
