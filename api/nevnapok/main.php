<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="stlye.css">
    <title>Form</title>
</head>

<body>
    <?php

    $getDate = $_POST['date'] ?? null;
    $getName = $_POST['name'] ?? null;
    $url = null;

    if ($getDate !== null) {
        $url = "http://localhost/api/nevnapok/?date=$getDate";
    } elseif ($getName !== null) {
        $url = "http://localhost/api/nevnapok/?name=$getName";
    }
    if ($url !== null) {
        $json = file_get_contents($url);
        $data = json_decode($json);
    }



    ?>
    <div class="container">
        <h2 id="title">Névnap kereső</h2>
        <div class="date">
            <form method="post">
                <label for="date">Dátum megadása</label><br>
                <input type="text" name="date" id="date"><br>
                <p id="eredmeny_date">
                    <?php echo $data->nevnap1 ?? null ?>
                    <?php echo $data->nevnap2 ?? null ?>
                    <?php echo $data->hiba??null  ?>
                    <?php if ($_SERVER["REQUEST_METHOD"]=="POST" && $getDate==null) {
                        echo $data->minta1 ??null;
                    } ?>
                </p>

                <input type="submit" class="btn" value="Küldés">

            </form>
        </div>
        <div class="name">
            <form method="post">
                <label for="name">Név megadása</label><br>
                <input type="text" name="name" id="name"><br>
                   <p id="eredmeny_date">
                    <?php echo $data->datum ?? null ?>
                    <?php echo $data->hiba??null  ?>
                    <?php if ($_SERVER["REQUEST_METHOD"]=="POST" && $getName==null) {
                        echo $data->minta2 ??null;
                    } ?>
                </p>
                <input type="submit" class="btn" value="Küldés">

            </form>
        </div>
    </div>



</body>

</html>