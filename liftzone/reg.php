<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

  
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js"></script>
    <link rel="stylesheet" href="style.css">
<style>
    
</style>
    
   
</head>
<style>
</style>
<body>


<div class="card">
    <h1>Regisztráció</h1>
  
    <form action="reg_ir.php" method="post" target="kisablak">
        <div class="row">
            <input type="text" name="user" placeholder="Felhasználónév" maxlength="100" >
            <i class="fa fa-question-circle" title="Felhasználónév hossza maximum 100 karakter hosszu lehet" style="font-size:24px"></i>
        </div>

        <div class="row">
            <input type="email" name="email" placeholder="Email cím" maxlength="255"  >
            <i class="fa fa-question-circle" title="Email cím hossza maximum 255 karakter hosszu lehet" style="font-size:24px"></i>
        </div>

        <div class="row">
            <input placeholder="Jelszó" name="pw" type="password" maxlength="15" >
            <i class="fa fa-question-circle" title="Jelszó hossza maximum 15 karakter hosszu lehet" style="font-size:24px"></i>
        </div>
        

        <div class="row">
            <input placeholder="Jelszó ismétlése" name="pw2" type="password" maxlength="15" >
            <i class="fa fa-question-circle" title="Jelszó hossza maximum 15 karakter hosszu lehet" style="font-size:24px"></i>
        </div>
        
        <div class="row">
            <input type="date" name="szul" id="szul" >
            <i class="fa fa-question-circle" title="Válassza ki a születése dátumját!" style="font-size:24px"></i>
        </div>


        <div class="row">
            <button type="submit" id="btn">Küldés</button>
            
        </div>
    </form>
</div>
  


</body>
</html>