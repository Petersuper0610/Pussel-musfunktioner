using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenPicture : MonoBehaviour
{
    public static ChosenPicture Instance;
    public Texture[] textures;
    public Texture picture;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject); // Behålla bilden 
    }

    public void ChoosePicture(int index) //val av bilder stanna 
    {
        picture = textures[index];
    }
}
