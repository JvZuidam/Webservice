<?php
	$Database = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'root', 'usbw');
	$stmt = $Database->prepare("insert into captains_log (Log_created, Log_author, Log_story, Log_deleted) values (NOW(), ?, ?, 0)");
	$stmt->bindParam(1, $_POST['author']);
	$stmt->bindParam(2, $_POST['log']);
	
	$Database->beginTransaction();
	$stmt->execute();
	$Database->commit();
?>