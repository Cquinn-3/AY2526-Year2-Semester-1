using UnityEngine;

public class PlayerMager : MonoBehaviour
{

    #region singleton 
    public static PlayerMager Instance;

     void Awake()
    {
    Instance = this;
        
    }
    #endregion

    public GameObject player;




}
