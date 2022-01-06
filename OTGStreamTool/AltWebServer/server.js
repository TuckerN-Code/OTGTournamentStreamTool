'use strict';
var http = require('http');
var port = process.env.PORT || 1337;
var express = require('express');
var app = express();

var jsonVar = ["null"];

app.use(express.json());

app.listen(5549, () => {
    console.log("Server running on port 5549");
})

app.get("/players", (req, res, next) => {
    res.json(jsonVar);
})

app.post("/players", (req, res) => {
    jsonVar = req.body;
    res.end();
})

http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end('Hello World\n');
}).listen(port);
