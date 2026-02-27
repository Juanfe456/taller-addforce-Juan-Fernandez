using UnityEngine;
using TMPro;

public class PlinkController : MonoBehaviour

{



    [SerializeField] private TMP_Text label;
    [SerializeField] private string Nombre;
    [SerializeField] private int Edad;
    [SerializeField] private int Año_actual;
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private float Fuerza; 



    private void Start()
    {
        label.text = "hola mundo";

        int Año_nacimiento = Año_actual - Edad;

        label.text = "Mi nombre es " + Nombre + " y naci en el año " + Año_nacimiento;


        Player.AddForce(Vector2.right * Fuerza, ForceMode2D.Impulse);


    }
}
