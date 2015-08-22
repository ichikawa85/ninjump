using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraFadeControl : MonoBehaviour 
{
	// Use this for initialization
    [SerializeField] GameObject fadeOutUI;
    private Image blackImg;
    public float fadeSpeed= 0.5F;
    public bool  isFadeIn = true;
    
    private float alpha= 1.0F;
    private float fadeDir= -1;


    void Awake()
    {
        blackImg = fadeOutUI.transform.FindChild("FadeOut").GetComponent<Image>();
    }
    
    void Start ()
    {
            
        if( isFadeIn)
        {
            alpha = 1;
            fadeIn();
        }
        else
        {
            alpha = 1;
            fadeOut();
        }
    }

    void Update()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        Color color = blackImg.color;
        color.a = alpha;
        blackImg.color = color;
    }

    public void fadeIn ()
    {
        fadeDir = -1;
    }
    
    public void fadeOut ()
    {
        fadeDir = 1;
    }
    
    void Disable ()
    {
        this.enabled = false;
    }
}
