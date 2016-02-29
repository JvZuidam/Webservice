<?php
	//echo's the current state of the log to seeif it is deleted or not
	//echo $temp['data']['deleted'];

if (isset($_GET['id']) && !empty($_GET['id'])) {
	$temp = json_decode(file_get_contents("http://192.168.56.101:8080/Delete.php/?id=".$_GET['id']), true);

	if ($temp['data']['deleted'] == 0) {

		echo "<h3>Author</h3>";
		echo "<input type='text' name='author' value='".$temp['data']['author']."' readonly>";
		echo "<h3>Story</h3>";
		echo "<textarea type='text' name='log' readonly>".$temp['data']['story']."</textarea>";
		echo "<form method='post'>";
		echo "<input type='submit' onclick='return confirm(\"Are you sure you want to delete this post?\")' name='Delete' value='Delete Post'>";
		echo "</form>";

		if (isset($_POST['Delete'])) {
			$ch = curl_init();

			curl_setopt($ch, CURLOPT_URL,"http://192.168.56.101:8080/Delete.php?id=".$_GET['id']);
			curl_setopt($ch, CURLOPT_POST, 1);
			curl_setopt($ch, CURLOPT_POSTFIELDS, "delete=".$_GET['deleted']);

			curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

			$server_output = curl_exec ($ch);
			curl_close ($ch);
		}

	} 
	else {
		echo "This post has been deleted and therefore no longer showable";
	}
}
else
{
	echo "No Id found please enter ?id=Id after the url";
}
?>