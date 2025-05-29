<?php
header('Content-Type: application/json; charset=utf-8');
$getName = $_GET['name'] ?? null;


    $sql = "SELECT ho,nap FROM nevnap WHERE nev1 = '$getName' OR nev2 = '$getName'";
    $result = mysqli_query($conn, $sql);
    $row = mysqli_fetch_assoc($result);

if ($result->num_rows > 0) {
    $key = "datum";
    $value = date("F", mktime(0, 0, 0, $row['ho'], $row['nap'])) . " " . $row['nap'] . ".";
}    
else{
        $key = "hiba";
        $value = "nincs találat";
}

$array = [
    $key =>$value,
    
];

   
$json = json_encode($array, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
echo $json;
    
?>