<?php

$date = explode("-", $getDate);
$month = $date[0];
$day = $date[1] ?? null;

if(str_contains("-", $getDate)) {
    $error = true;
} else {
    $error = false;
}

if(!is_numeric($month) && !is_numeric($day)) {
    $error = false;
} else {
    $error = true;
}

$result = $conn->query("SELECT * FROM nevnap WHERE ho = '$month' AND nap = '$day'");
$row = mysqli_fetch_assoc($result);

if ($result->num_rows == 0) {
    $key = "hiba";

    $value = "nincs találat";
    $value2 = null;
    $value3 = null;
} else if($result->num_rows > 0) {
    $key = "datum";
    $key2 = "nevnap1";
    $key3 = "nevnap2";

    $value = date('F', mktime(0, 0, 0, $month, $day)) . " " . $day . ".";
    $value2 = $row["nev1"];
    $value3 = $row["nev2"] ?? null;
}

if ($value2) {
    $array = [
        $key => $value,
        $key2 => $value2,
        $key3 => $value3,
    ];
} else {
    $array = [
        $key => $value
    ];
}

$json = json_encode($array, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE);
echo $json;

?>