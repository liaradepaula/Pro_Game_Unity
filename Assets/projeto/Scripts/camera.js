#pragma strict
var Personagem: Transform;
//pq vai setar apenas o personagem
var ValorSuavizacao = 0.3;
//suavizar a camera
var Velocidade: Vector2;
//velocidade da camera no verto 2 pq e 2D x,y

function Update () {
transform.position.x = Mathf.SmoothDamp(transform.position.x, Personagem.position.x, Velocidade.x, ValorSuavizacao);

//altera um valor alongo de tempo pra suavizar
//o codigo em x e (horizontamente)
transform.position.y = Mathf.SmoothDamp(transform.position.y, Personagem.position.y, Velocidade.y, ValorSuavizacao);
//mesma acompanhamento de camera suavizada no eixo y (verticamente)
}