
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(6f*Time.deltaTime,0,0);
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    
        if(collision.gameObject.CompareTag("Player"))
        {
     
            collision.gameObject.SetActive(false);
        }
    }



}
