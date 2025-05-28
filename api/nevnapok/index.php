<?php
include("conn.php");
header('Content-Type: application/json; charset=utf-8');

$getDate=$_GET['date'] ?? null;
$getName=$_GET['name'] ?? null;

if ($getDate) {
    include("date.php");
}
elseif ($getName) {
    include("name.php");
}
else{
    echo json_encode(["minta1"=>"/?nap=12-31","minta2"=>"/?nev=Szilveszter"],JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
}


?>