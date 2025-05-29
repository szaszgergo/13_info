<?php
header('Content-Type: application/json; charset=utf-8');
$getJel=$_GET["jel"]??null;
$error = "0";
$birthdate="";
if ($getJel===null || empty($getJel)) {
    echo json_encode(["minta"=>"?jel=8234567969"], JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
    return;
}


if ($getJel[0]!=='8' || strlen($getJel)!==10) {
    $error = "1";

}else{
    for ($i=1; $i <= 5; $i++) { 
        $birthdate .= $getJel[$i];
    }
    $birthdate = date('Y.m.d', strtotime("+" . $birthdate . "days", strtotime('1867-01-01')));
    $error = strtotime($birthdate) > strtotime(date("Y.m.d"))? '1':'0';
}


$array=[
    "jel"=>$getJel,
    "szul_datum"=>$birthdate,
    "error"=>$error ,

];

$json = json_encode($array, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
echo $json;


?>