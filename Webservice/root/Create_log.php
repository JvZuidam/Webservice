<html>
<body>

<form action="Create_log.php" method="post">
Author: <input type="text" name="author"><br>
Log: <textarea type="text" name="log"></textarea><br>
<input type="submit" value="Submit">
</form>

</body>
</html>

<?php
if (!isset($_POST['author'], $_POST['log']) || empty($_POST['author']) || empty($_POST['log'])) {
	echo "Fault";
}
else {
	echo "succes";

	$ch = curl_init();

	curl_setopt($ch, CURLOPT_URL,"http://192.168.56.101:8080/Create.php");
	curl_setopt($ch, CURLOPT_POST, 1);
	curl_setopt($ch, CURLOPT_POSTFIELDS, "author=".$_POST['author']."&log=".$_POST['log']);

	curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

	$server_output = curl_exec ($ch);

	curl_close ($ch);
}
?>