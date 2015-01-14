using UnityEngine;
using System.Collections;

public class gamerControler : MonoBehaviour {
	public gamerControler controle;
	//estaciando o uncio gamer objeto que existe na sena
	public float health;
	//saudade
	public  float experience;
	//experiencia

	void Awake () {
	//animar, acorda
		if(controle == null)
		{
		DontDestroyOnLoad (gameObject);
			controle = this;
	
	    }
	    else if (controle != this)
		
        {
	   
			Destroy(gameObject);
			//sempre que um novo load for criando o gamerobgjeto 
			//anterior sera destruido isso e entra em um novo load
		}
	   
	    }
	void onGUI()
	   {
		GUI.Label (new Rect (10, 10, 100, 30), "saude" + health);

		GUI.Label (new Rect (10, 40, 150, 30), "Experiencia" + experience);
		}
	    
	 
 }
