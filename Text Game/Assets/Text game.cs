using UnityEngine;
using UnityEngine.UI;


public class textController : MonoBehaviour
{

    public Text text;
    private enum States { window1, room1, door1, stairs, }
    int keysilver = 0;
    // A = opcja jeden , B = opcja dwa , S = powrot//

    States myState;
    private readonly int lamp;

    void state_room1()
    {
        States myState = States.room1;

        text.text = "Budzisz sie w ciemnym pomieszczeniu oswietlnonym przez malutkie okienko  /A podejdz do okna";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.window1;

        }

    }


    // Start is called before the first frame update
    void Start()
    {
        States myState = States.room1;
        text.horizontalOverflow = HorizontalWrapMode.Wrap;
        text.fontSize = 12;
        text.fontStyle = FontStyle.Bold;


    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.room1) { state_room1(); }
        else if (myState == States.window1)  {state_bed(); } 
        else if (myState == States.door1) { state_door1(); }
        else if (myState == States.stairs) { state_room1(); }







    }

    private void state_lamproom()
    {

    }

    private void state_underbed()
    {

    }

    private void state_bed()
    {

    }

    private void state_cross1()
    {

    }
    private void state_door1()
    {
        text.text = "Znajdujesz sie przy oknie .. Widzisz swojerodzinne miasteczko z wiezy czarodzieja /S Wroc ";
        if (Input.GetKeyDown(KeyCode.A)) { state_mainhall(); }
        if (Input.GetKeyDown(KeyCode.S)) { state_mainhall(); }
    }

    private void state_mainhall()
    {
        if (lamp == 0) { text.text = "Jest tu za ciemno potrzebujesz lampy"; }
        if (lamp == 1)
        {
            text.text = "Jestes w hallu /A Podejdz dalej /S powróć";
            if (Input.GetKeyDown(KeyCode.A)) { state_cross2(); }
            if (Input.GetKeyDown(KeyCode.S)) { state_door1(); }
        }

    }

    private void state_cross2()
    {

    }
}
