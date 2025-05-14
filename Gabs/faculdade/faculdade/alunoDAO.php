<?php
//operador ternário

$acao  = isset($_GET["acao"])  ? $_GET["acao"]  : "" ;
$ra    = isset($_GET["ra"])    ? $_GET["ra"]    : "" ;
$nome  = isset($_GET["nome"])  ? $_GET["nome"]  : "" ;
$curso = isset($_GET["curso"]) ? $_GET["curso"] : "" ;
$cpf   = isset($_GET["cpf"])   ? $_GET["cpf"]   : "" ;
$senha   = isset($_GET["senha"])   ? $_GET["senha"]   : "" ;

$senha = sha1($senha);

$sql = "";
$msg = "";
if ($acao=="insert"){
   $sql = "insert into aluno(nome,curso,cpf,senha) values('{$nome}','{$curso}','{$cpf}', '{$senha}')";
   $msg = "Dados inseridos com sucesso!";
}else if ($acao=="select"){
   $sql = "select * from aluno";
}else if ($acao=="update"){
   $sql = "update aluno set nome='{$nome}', curso='{$curso}', cpf='{$cpf}', senha='{$senha}' where ra={$ra}";
   $msg = "Dados alterados com sucesso!";
}else if ($acao=="delete"){
   $sql = "delete from aluno where ra={$ra}";
   $msg = "Dados excluídos com sucesso!";
}
//echo $sql."<br>";

$minhaConexao = new PDO('sqlite:banco_de_dados.db'); 
$resultado    = $minhaConexao->query($sql);

if ($acao=="select"){
   $meuVetor = array();
   foreach($resultado as $linhaBanco) {      
      $meuVetor[] = $linhaBanco;  //echo "{$linha['ra']} - {$linha['nome']} - {$linha['curso']} - {$linha['cpf']} <br>";      
   }
   echo json_encode($meuVetor);

}else{
   if ($resultado->rowCount()>=1){
      echo $msg;
   }else{
      echo "Não houve nenhuma alteração no banco de dados!!!";
   }
}

$resultado    = null;
$minhaConexao = null;
?>