using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

        string heroName = "Bader";
        int heroHeight = 177 + 5;
        int heroAge = 16;
        string heroPower = "Lazer eye";


        string villanName = "shereyr";
        int villanHeight = 318;
        int villanAge = 700;
        string villanPower = "none";

        int ageDiffrence = villanAge - heroAge;

        print("The age diffrence is huge " + ageDiffrence + " years to be exact");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
