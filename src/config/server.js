module.exports = (app) => {
    const PORT = 8080;
    app.listen(PORT, () => {
        console.log(`Servidor rodando na porta ${PORT}`);
    });
};