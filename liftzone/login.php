<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">

    <title>Document</title>
</head>
<body>
    <style>
        input{
            border-radius: 10px;
        }
    </style>


<form action="login_ir.php" method="POST" target="kisablak">
        

</form>


 <div class="card">
    <h1>Belépés</h1>
  
    <form action="login_ir.php" method="post" target="kisablak">
        <div class="row">
            <input type="email" name="email" placeholder="Email cím" maxlength="255"  >
        </div>

        <div class="row">
            <input name="pw" type="password" placeholder="jelszó">
        </div>

        <div class="row">
        <input type="submit"  value="Belépés">
        </div>

        <div class="row">
            <input type="button" value="Regisztáció" onclick='location.href="./?p=reg"'>
        </div>

    </form>
</div>
  



<br><br>


</body>
</html>