//Maria Fernanda Lopez Diaz
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //cuando este es presionado se reproduce un canto del pajaro
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start()
    {
        //se obtiene el componente virtual del boton
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}