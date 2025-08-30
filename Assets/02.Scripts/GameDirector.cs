using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance;
    //public GameObject panel;

    CarController carScript;
    void Start()
    {
        carScript = car.GetComponent<CarController>();
      //  panel.SetActive(false);
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length <= 0)
        {
            this.distance.GetComponent<Text>().text = "게임 오버";
            carScript.moveSpeed = 0;
        //    panel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
          //      panel.SetActive(false);
                carScript.moveSpeed = 0;
                carScript.transform.position = new Vector3(-7, -3.7f, 0);
            }
        }
        else
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
            if (carScript.moveSpeed == 0)
            {
            //    panel.SetActive(true);
                if (Input.GetKeyDown(KeyCode.R))
                {
              //      panel.SetActive(false);
                    carScript.transform.position = new Vector3(-7, -3.7f, 0);
                }
            }
        }
    }
}
