using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject congra;
    public GameObject gameover;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "light")
        {
            print("觸及傳送門");
            congra.SetActive(true);
        }
        
        if (collision.tag == "trap")
        {
            print("南瓜泥");
            gameover.SetActive(true);

        }
    }
}
