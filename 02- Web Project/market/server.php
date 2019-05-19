<?php
session_start();
$username = "";
$email = "";
$errors = array();

 //connect to database
  $db = mysqli_connect('localhost', 'root', '', ' market');

 //if register is clicked
 if(isset($_POST['register'])) {
     $username = ($_POST['username']);
     $email = ($_POST['email']);
     $password_1 = ($_POST['password_1']);
     $password_2 = ($_POST['password_2']);

     //ensure that form is filled 
     if(empty($username)){
         array_push($errors, "username is required"); //add error to error array
     }
     
     if(empty($email)){
         array_push($errors, "email is required"); //add error to error array
     }
     
     if(empty($password_1)){
         array_push($errors, "password is required"); //add error to error array
     }
     
     if($password_1 != $password_2){
          array_push($errors, "The two passwords do not match");
     }
     
     //if no errors save to db
     if(count($errors) == 0){
         $password = md5($password_1); //encrpt password before storing in db (security)
         $sql = " INSERT INTO users (username, email, password) VALUES ('$usename', '$email', '$password') ";
         mysqli_query($db,$sql);
         $_SESSION['username'] = $username;
         $_SESSION['success'] = "You are now login";
         header('location: index.php'); //redirct to home page
         
     }
 }

?>