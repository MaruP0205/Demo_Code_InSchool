<?php

  $dsn="mysql:host=localhost;dbname=game2dnangcao";
  $user ='root';
  $pass = '';
  $db = new PDO($dsn,  $user,$pass );
  
  $sql = "select * from user_full";
  $ket_qua = $db->query($sql);

  while($row = $ket_qua->fetch()){
      printf("%s-%s-%s-%s-%s-",$row[0],$row[1],$row[2],$row[3],$row[4]);
      print(",");
  }



?>