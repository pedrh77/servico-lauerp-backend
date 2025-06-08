const express = require('express');
const router = express.Router();
const TesteController = require('../controllers/TesteController');

router.get('/', TesteController.getTeste);

module.exports = router;