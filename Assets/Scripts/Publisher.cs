using UnityEngine;

public class Publisher : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Observer.ObserverCall += Message;
    }

    private void Message() {
        Debug.Log("Я нашел 10 Publishers");
    }
}
