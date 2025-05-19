using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void awake()
  
    {
        if(instance == null)
    
        {
            instance = this;
        }   
        else    
        {
            Destroy(gameObject);
        }

    }    
}
