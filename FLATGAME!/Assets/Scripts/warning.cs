using UnityEngine;

public class warning : MonoBehaviour
{
    AudioSource warn;
    public AudioSource gong;
    //public Animator flash;
    public GameObject player;
    public GameObject txt;

    void Start()
    {
       // flash.enabled = false;
        warn = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !txt.activeSelf) // warn player if entering the area
        {
            gong.Play();
            warn.Play();
            txt.SetActive(true);
            // flash.enabled = true;
            collision.gameObject.transform.position = new Vector3(0, -8, 0);
        }
        else if (collision.gameObject.CompareTag("Player") && txt.activeSelf) // if player enters again, reset position
        {
            collision.gameObject.transform.position = new Vector3(0, -8, 0);
        }
    }
}
