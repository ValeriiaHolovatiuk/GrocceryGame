using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.AudioSource;

public class orderCloudActions : MonoBehaviour
{
    private GameObject cloudImage;
    private GameObject productImage;
    public AudioClip cloudAppear, cloudDisappear;
    string[] products = { "avocado", "bacon", "bananas", "beans", "beer", "beet", "blueberry", "bone", "borscht", "bread", "broccoli", "butter", "cake", "candy", "carrot", "chicken", "chocolade", "doubleCandies", "garbage", "orange" };
    float waitingTime = 5f;

    void orderCloudDisable()
    {
        cloudImage = GameObject.Find("cloudWithOrders/orderCloud");

        cloudImage.SetActive(false);
    }

    void orderCloudAppear()
    {
        GetComponent<AudioSource>().PlayOneShot(cloudAppear);
        cloudImage.SetActive(true);

        System.Random rnd1 = new System.Random();
        System.Random rnd2 = new System.Random();

        int numOfProducts, productsName;

        string[] productsChoosen = new string[3];

        numOfProducts = rnd1.Next(1, 3);

        for(int i = 0; i < numOfProducts; i++)
        {
            productsName = rnd2.Next(1, 20);

            productsChoosen[i] = products[productsName];
        }

        for(int i = 0; i < productsChoosen.Length; i++)
        {
            productImage = GameObject.Find(productsChoosen[i]);

            
        }

    }

    void orderCloudDisappear()
    {
        waitingTime -= Time.deltaTime;
        if (waitingTime == 0)
        {
            cloudImage.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(cloudDisappear);
        }
    }
}
