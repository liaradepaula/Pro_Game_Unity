
using UnityEngine;
using System.Collections;
//depois de colocamos no animator
// do unity agora vamos dizer a ele o que 
// deve fazer com as animaçoes

 

public class cotroleMovimento : MonoBehaviour {

	// maxima velocidade do play
	public float maximaVelocidade = 10f;

	// sentido oposto

	bool fecingRight = true;

	//agora vamos inciar a fase de troca entre corre e fica parado
	//usando o metodo start

	Animator anima;
	//uma variavel que receberar posteriomente um componente
		
	bool grounded = false;
	//programaçao do pulo 
	//começando atraz por isso falso

	public Transform groundCheck;
	// isso cria um outro objeto para representar o solo(chao)

	float groundRadius = 0.2f;
	//receberar uma novo chao na corrida

	public LayerMask whatIsGround;
	//chama uma nova mascara para o fundo


	public float junpForce = 400f;
		// força do pulo



	bool doubleJunp = false;

// isso e um pulo duplo, esta afirmativa esta falsa por se 
	//vc nao pula um vem esta pulando 2 ap preconar espaço


	void Start () 
	{
	// isso ira indicar qual componente sera
		// modificado no caso Animador
		anima = GetComponent<Animator> ();
	}
	

	void FixedUpdate () 
	{
		// isse circulos determina a ia para baixo do personagem 
		//mesmo circulos do que cplliter circulo

		grounded = Physics2D.OverlapCircle
		(groundCheck.position, groundRadius, whatIsGround);
		anima.SetBool ("Ground", grounded);
		//seleciona a parte boleanas do codigo fazendo com que
		//so o ground (chao )seja testado se estive no chao ele confima se nao ele cai
		//cria um variavel velocidade para que possa controlar o mocimetno
		// de decida em y


		if (grounded)
			doubleJunp = false;
		// iniciar com pulo duplo em falso por quer o pulo unico que inicia

		anima.SetFloat("variVelocidade", rigidbody2D.velocity.y);


		// movimento horizontal
		//180
		float move = Input.GetAxis ("Horizontal");

		//chamando o start
		// aqui so se esta controlando a velocidade 
		// o resto o controlado faz so 

		anima.SetFloat("velocidade", Mathf.Abs(move));



		// aqui esta falando que a fisica do jogo responderar a fisica e velcidade no vetor y = horizontal
		rigidbody2D.velocity = new Vector2 (move * maximaVelocidade, rigidbody2D.velocity.y);
	
			if (move > 0 &&!fecingRight)
			// chamando o metodo emplementado embaixo

						Flip ();
			else if (move < 0 && fecingRight)
			// chamando o metodo emplementado embaixo		

		            	Flip ();

	}

	void Update()
	{
		//implementando o pulo usando a tecla de espaço do teclado
		if ((grounded || !doubleJunp)&& Input.GetKeyDown (KeyCode.Space))
		{
			// isso vefica e se a aminaçao nao estive no chao
			// o estado e falso certo, entao e tecla de espaço foi 
			//apertada
			anima.SetBool("Ground", false);

			rigidbody2D.AddForce(new Vector2(0, junpForce)); 
		
			//aqui que o verto gounded (chao e falso) o duplo pulo e verdadeiro
			if(!doubleJunp  && !grounded)
				doubleJunp = true;

		}

    }


	// criando uma funçao /metodo
	void Flip()
	{
		//setindo oposto
		fecingRight = ! fecingRight;

		// esta dizendo que o vetor 3 tem um escala que vai traforma o local(personagem)
		// *( toda vez )= -1 isso ela : o outro lado
		// entao ira pro eixo x vertical
		// - 180
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


}
 