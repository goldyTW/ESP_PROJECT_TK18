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
  var sql = "INSERT INTO data (device_id, value) VALUES ('2', '37')";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log("1 record inserted");
  });
});