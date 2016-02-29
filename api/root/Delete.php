<?php
	//Getting the information
	$db = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'root', 'usbw');
	$stmt = $db->prepare("SELECT Log_author, Log_story, Log_deleted FROM captains_log WHERE Id=?");
	$stmt->execute(array($_GET['id']));
	$stmt->bindColumn(1, $author);
	$stmt->bindColumn(2, $story);
	$stmt->bindColumn(3, $deleted);
	$stmt->fetch(PDO::FETCH_BOUND);
	
	$result = ["result" => 1, "data" => []];
	$result["data"] = ["author" =>$author, "story" =>$story, "deleted" =>$deleted];

	echo json_encode($result);
	
	//deleting the post
	$Database = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'root', 'usbw');
	$Database->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	$Database->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
	$Database->setAttribute( PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING );
	$stmt = $Database->prepare("UPDATE captains_log SET Log_deleted = 1 WHERE Id = ?");

	$stmt->bindParam(1, $_GET['id']);
	
	$Database->beginTransaction();
	$stmt->execute();
	$Database->commit();
?>
