<?php

if (isset($_GET['id']) && !empty($_GET['id'])) {
	$temp = json_decode(file_get_contents("http://192.168.56.101:8080/View.php/?id=".$_GET['id']), true);

	echo "<form method='post'>";
	echo "Author: <input type='text' name='author' value='".$temp['data']['author']."'><br>";
	echo "Log: <textarea type='text' name='log'>".$temp['data']['story']."</textarea><br>";
	echo "<input type='submit' value='Submit'><br>";
	echo "</form>";

	if (!isset($_POST['author'], $_POST['log']) || empty($_POST['author']) || empty($_POST['log'])) {
		echo "Fault";

	}
	else {
		echo "succes";

	$ch = curl_init();

	curl_setopt($ch, CURLOPT_URL,"http://192.168.56.101:8080/Edit.php?id=".$_GET['id']);
	curl_setopt($ch, CURLOPT_POST, 1);
	curl_setopt($ch, CURLOPT_POSTFIELDS, "author=".$_POST['author']."&log=".$_POST['log']);

	curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

	$server_output = curl_exec ($ch);
	curl_close ($ch);

	}

} 
else 
{
	echo "No Id found please enter ?id=Id after the url";
}
?>