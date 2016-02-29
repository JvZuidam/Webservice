<?php
	$db = new PDO('mysql:host=localhost;dbname=test;charset=utf8', 'root', 'usbw');
	$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	$db->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
	$db->setAttribute( PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING );
	$stmt = $db->prepare("UPDATE captains_log SET Log_created = NOW(), Log_author = ?, Log_story = ? WHERE Id = ?");
	
	$stmt->bindParam(1, $_POST['author']);
	$stmt->bindParam(2, $_POST['log']);
	$stmt->bindParam(3, $_GET['id']);
	
	$db->beginTransaction();
	$stmt->execute();
	$db->commit();
?>