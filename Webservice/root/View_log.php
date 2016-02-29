<?php

if (isset($_GET['id']) && !empty($_GET['id'])) {
	$temp = json_decode(file_get_contents("http://192.168.56.101:8080/View.php/?id=".$_GET['id']), true);
	echo "<h3>Author</h3>";
	echo "<input type='text' name='author' value='".$temp['data']['author']."' readonly>";
	echo "<h3>Story</h3>";
	echo "<textarea type='text' name='log' readonly>".$temp['data']['story']."</textarea>";
} else {
	echo "No Id found please enter ?id=Id after the url";
}


?>