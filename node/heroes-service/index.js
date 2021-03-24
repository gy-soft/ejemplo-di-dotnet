const express = require('express');
const { heroes } = require('./heroes');

const app = express();

app.get('/heroes/:id', (req, res) => {
    const id = req.params.id;
    if (heroes.has(id)) {
        return res.json(heroes.get(id));
    } else {
        return res.status(404).send('Not Found');
    }
});

const PORT = 3000;
app.listen(PORT, () => {
    console.log(`Listening at http://localhost:${PORT}`)
});