'use strict';

const net = require('net');

var client3 = new net.Socket();
client3.connect(3002, "127.0.0.1", function () { console.log("client3 Connected"); }) //Connect
client3.on('close', function () { client3.connect(3002, "127.0.0.1", function () { console.log("client3 Connected"); }) }) //Reconnect if connection is closed
client3.on('error', function (ex) { if (ex.message.includes("client3 ECONNREFUSED")) { } }); //error
client3.on('data', function (data) { console.log(data.toString()); }); //receive strings

