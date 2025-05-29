<?php
include 'conn.php';
header('Content-Type: text/html; charset=utf-8');
$getName = $_GET['name'] ?? null;
$getDate = $_GET['date'] ?? null;

if($getName){
    include 'name.php';
}
elseif($getDate){
    include 'date.php';
}
else{
     echo json_encode(["minta1"=>"/?nap=12-31","minta2"=>"/?nev=Szilveszter"],JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
}

?>