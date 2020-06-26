using UnityEngine;

public class Observer : MonoBehaviour
{
   [SerializeField] Publisher[] publishers;
    // Start is called before the first frame update
    void Start()
    {
        publishers = Resources.FindObjectsOfTypeAll<Publisher>();
        if (publishers.Length==10) {
            ObserverCall();
        }
    }
    public delegate void MethodContainer();

    public static event MethodContainer ObserverCall;

    private static Observer instance;

    private Observer() { }

    public static Observer getInstance() {
        if (instance == null)
            instance = new Observer();
        return instance;
    }

}
