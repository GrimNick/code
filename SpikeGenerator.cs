
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject toSpawn;
    GameObject newspawn;
    public float maxtime=2f;
    float timer;
    public float speed = 20;
   
    // Start is called before the first frame update
   

    
   
    // Update is called once per frame
    void Update()
    {
        
        Vector2 random = new Vector2(transform.position.x, Random.Range (-2f,-0.82f));
        timer += Time.deltaTime;
        if (timer > maxtime)
        {
            GameObject newspawn = Instantiate(toSpawn, random, transform.rotation);
            timer = 0;
            Destroy(newspawn, 5f);
        }
        Destroy(newspawn, 4f);
    }
  
}
