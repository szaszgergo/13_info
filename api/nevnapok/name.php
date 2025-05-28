<?php
$sql = "SELECT ho,nap from nevnap where nev1='$getName' or nev2='$getName' limit 1 ";
$result=$conn ->query($sql); 
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