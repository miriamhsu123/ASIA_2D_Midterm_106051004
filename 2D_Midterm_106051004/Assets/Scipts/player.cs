using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject congra;
    public GameObject gameover;
    public Text textCount;
    public int count;


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
        if (collision.tag == "ingredient")
        {
            print("get");
            Destroy(collision.gameObject);
            count++;
            textCount.text = "Ingredients : " + count;
        }
    }
}
