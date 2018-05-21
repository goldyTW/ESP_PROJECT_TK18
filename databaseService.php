<?php



	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbname = "iot";

	$conn = new mysqli($servername, $username, $password, $dbname);

	if($conn->connect_error){
		die("Connection failed: " . $conn->connect_error);
	}

	$sql = "SELECT * FROM data";
	$result = $conn->query($sql);

	echo'<h3>'. "data" .'</h3>';

	if($result->num_rows>0){
		echo '<table cellpadding="0" cellspacing="0" class="db-table">';
		echo '<tr><th>id</th><th>device_id</th><th>waktu</th><th>value</th></tr>';
		while($row=$result->fetch_assoc()){
			echo '<tr> 
					<td scope="row">' . $row["id"]. '</td> 
					<td> '. $row["device_id"] .'</td>
					<td> '. $row["waktu"] .'</td>
					<td> '. $row["value"] .'</td>
				  </tr>	'; 

		}
		echo '</table><br>';

	} else {
		echo "0 results";
}
$conn->close();
?>