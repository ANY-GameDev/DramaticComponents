using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        // changed from unscaledDeltaTime to deltaTime and
        // multiplied the position and rotation changes by timescale
        // so the object will stop all motion when game is paused 
        transform.position += new Vector3(0, 9f * Time.deltaTime, 0);
        if (direction == 1)
            transform.Rotate(Vector3.forward * Time.timeScale * 0.5f);
        else
            transform.Rotate(Vector3.back * Time.timeScale * 0.7f);

        if (transform.position.y > 8.0f)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
