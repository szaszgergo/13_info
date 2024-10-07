<?php
session_start();
 ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Menu</title>
</head>
<style>
    div#login{
        text-align:right;
    }
    #gomb{
        width:10%;
    }

    body {
        font-family: Arial, sans-serif;
        background-color: #000;
        color: #fff;
        margin: 0;
    }

    #menu {
        background-color: #222;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 10px;
        position: relative;
    }

    #menu #centered-links {
        display: flex;
        gap: 20px;
    }

    #menu a {
        color: white;
        font-weight: bold;
        text-decoration: none;
        padding: 12px 20px;
        border-radius: 8px;
        background-color: transparent;
        transition: background-color 0.3s ease, color 0.3s ease;
    }

    #menu #centered-links a:hover {
        background-color: #ff0000;
        color: #222;
    }

    #menu #profile-icon {
        position: absolute;
        right: 20px;
    }

    #menu #profile-icon img {
        width: 40px;
        height: 40px;
        border-radius: 50%;
        object-fit: cover;
    }


</style>
<body>


<div id="menu">
        <div id="centered-links">
            <a href="./">Kezdőlap</a>
            <?php
            if(!isset($_SESSION["uid"])) {
                echo '<a href="./?p=login">Bejelentkezés</a>';
            } else {
                echo '<a href="logout.php">Kijelentkezés</a>';
            }
            ?>
            <a href="./?p=regisztracio">Regisztráció</a>
        </div>
        <a href="./?p=profil" id="profile-icon"><img src="pic/profile.png"></a>
    </div>





<?php
    if (isset($_GET['p'])) $p=$_GET['p'];
    else $p="";

    if($p=="login") include("login.php");
    if($p=="reg") include("reg.php");
    

?>


<iframe name="kisablak"></iframe>

</body>
</html>