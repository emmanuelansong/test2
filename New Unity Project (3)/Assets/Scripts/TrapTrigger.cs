using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public Animator anim;
    private Shooting shooting;
    public GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        shooting = firePoint.GetComponent<Shooting>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(gameObject.tag == "Spikes")
            anim.SetBool("playertouch", true);

        if (gameObject.tag == "Arrows")
        {
            

            shooting.Shoot();
            anim.SetBool("playertouch", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == "Spikes")
            anim.SetBool("playertouch", false);

        if (gameObject.tag == "Arrows")
        {
            
            anim.SetBool("playertouch", false);
        }
    }
    // Update is called once per frame

}
