using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SoundManagerScript : MonoBehaviour
{

    private static SoundManagerScript musicManagerInstance;

    void Awake()
    {

        DontDestroyOnLoad(this);

        if (musicManagerInstance == null)
        {
            musicManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    }

    
