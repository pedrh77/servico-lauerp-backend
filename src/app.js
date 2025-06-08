const express = require('express');
const app = express();
const server = require('./config/server');


app.use(express.json());

const testeRoutes = require('./routes/routes');
app.use('/teste', testeRoutes);

server(app);