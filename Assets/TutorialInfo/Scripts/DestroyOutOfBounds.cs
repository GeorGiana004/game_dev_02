using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float topBound = 10;
   
    private float lowerBound = -30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      


    
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}


