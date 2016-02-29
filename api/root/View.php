<?php
	$db = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'root', 'usbw');
	$stmt = $db->prepare("SELECT Log_author, Log_story FROM captains_log WHERE Id=?");
	$stmt->execute(array($_GET['id']));
	$stmt->bindColumn(1, $author);
	$stmt->bindColumn(2, $story);
	$stmt->fetch(PDO::FETCH_BOUND);
	
	$result = ["result" => 1, "data" => []];
	$result["data"] = ["author" =>$author, "story" =>$story];

	echo json_encode($result);
?>