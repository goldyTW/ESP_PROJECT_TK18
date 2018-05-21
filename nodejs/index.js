//
var http = require('http');
var fs = require('fs');
var express = require('express');
var db = require('./db');
var net = require('net');

netserver= net.createServer();
let counter = 0;
let sockets = {}

netserver.on('connection', (socket) => {
  //socket.write("A client has connected\n")
  console.log('A client has connected');
  socket.on('data', data => {
        console.log(data.toString('utf8'));
		var value  = data.toString();
		value=[[value.replace(/[\n\r]+/g, '')]];
		
        db('INSERT INTO data (`value`) VALUES ?', value, function(err, rows)   {
   			console.log(rows);
		});
  })
});
// netserver.on('connection', (socket) => {
//   socket.id = counter++
//   sockets[socket.id] = socket;
//   socket.write("A client has connected\n")

//   socket.on('data', data => {
//     Object.entries(sockets).forEach(([key, cs]) => {
//       if(sockets.id != key) {
//         cs.write(data);
//       }
//     });
//   })
// });
netserver.listen(5556);
console.log('Server running at http://127.0.0.1:5556/');
