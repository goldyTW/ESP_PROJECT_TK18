var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "irfan",
  password: "",
  database: "mydb"
});

con.connect(function(err) {
  if (err) throw err;
  console.log("Connected!");
  var sql = "CREATE TABLE data (id INT AUTO_INCREMENT PRIMARY KEY, device_id INT, waktu TIMESTAMP, value VARCHAR(255))";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log("Table created");
  });
}); 