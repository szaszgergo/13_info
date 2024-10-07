<?php 
session_start();
include("kapcsolat.php");

$email = $_POST["email"];
$upw = md5($_POST["pw"]);

$userek=mysqli_query($db,"SELECT * FROM user WHERE (uemail='$email' OR unick='$email') AND upw='$upw' ");

if(mysqli_num_rows($userek)==0)
{
    print"<script>alert('Hibás belépési adatok!')</script>";
}
else
{
    $user=mysqli_fetch_array($userek);
    $_SESSION['uid'] = $user['uid'];
}


mysqli_close($db);

print"<script>parent.location.href='./'</script>";
?>