<?php 
print_r($_POST);

if ($_POST['user']=='') {
    die("<script>alert('Nem adtad meg a felhasználó nevedet!')</script>");
}
if (!filter_var($_POST['email'],FILTER_VALIDATE_EMAIL)) {
    die("<script>alert('Nem megfelelő email-cím!')</script>");

}
if (strlen($_POST['pw'])<4) {
    die("<script>alert('10 karakternél kisebb a jelszó')</script>");
}

if ($_POST['pw']!==$_POST['pw2']) {
    die("<script>alert('Nem egyeznek a jelszavak!')</script>");
}
if (empty($_POST['szul'])) {
    die("<script>alert('Válasz ki egy dátumot!')</script>");
}




include("kapcsolat.php");





$upw=md5($_POST['pw']);

mysqli_query($db,"

INSERT INTO user ( uid,          uemail,          unick,    upw,         ubirth,  udate, uip, usession, ustatus, ucomment) 
VALUES           (NULL, '$_POST[email]', '$_POST[user]', '$upw', '$_POST[szul]', NOW() , '', '', '', '')

");

mysqli_close($db);
print"<script>parent.location.href='./'</script>";

?>