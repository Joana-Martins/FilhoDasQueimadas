using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    // Start is called before the first frame update
   void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static string PlayerName { get; set;}
    public static int PlayerLevel { get; set; }
    public static BaseClass PlayerClass { get; set; }
    public static int Combate { get; set; }
    public static int Habilidades { get; set; }
    public static int Suporte { get; set; }
    public static int Saude { get; set; }
}
