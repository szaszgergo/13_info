<?php
header('Content-Type: application/json; charset=utf-8');
$getDate = explode("-", $_GET['date']);
$day = $getDate[1] ?? null;
$month = $getDate[0] ?? null;



$sql = "SELECT nev1,nev2 FROM nevnap WHERE ho = '$month'  AND nap = '$day'";
$result = mysqli_query($conn, $sql);
$row = mysqli_fetch_assoc($result);


if ($result->num_rows > 0) {
    $key = "datum";
    $value = date("F", mktime(0, 0, 0, $month, $day)) . " " . $day . ".";
    $key2 = "nevnap1";
    $value2 = $row['nev1'];
    $key3 = "nevnap2";
    $value3 = $row['nev2'];
} else {
    $key = "hiba";
    $value = "nincs találat";
}
if ($key != "hiba") {
    $array = [
        $key => $value,
        $key2 => $value2,
        $key3 => $value3
    ];
} else {
    $array = [
        $key => $value
    ];
}



$json = json_encode($array, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
echo $json;
