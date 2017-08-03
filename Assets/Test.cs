using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic( int spend )
    {

        if (mp >= 5) 
        {
            this.mp -= 5;

            Debug.Log("魔法攻撃をした。残りMPは" + this.mp );
        }
        else
        {
                Debug.Log("MPが足りないため魔法が使えない");  
        }
       
    }

}

public class Test : MonoBehaviour {



    // Use this for initialization
    void Start() {

        Boss lastboss = new Boss();

        lastboss.Magic(5);

        

            for (int spend = 0; spend <= 10; spend++)
            {
            lastboss.Magic(5);
            }

        

       


        Boss midboss = new Boss();

        midboss.Magic(5);

       





        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int n = 4; n >= 0; n--)
        {
            Debug.Log(array[n]);
        }

       


    }






    // Update is called once per frame
    void Update () {
		
	}



        




}
