using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public float life = 100;
    public TMP_Text lifeText;

    private void Update()
    {
        Check();
        lifeText.text = ("Life :" + life.ToString());
    }

    private void Check()
    {
        if(life <= 0)
        {
            life = 0;
        }
    }

    
}
