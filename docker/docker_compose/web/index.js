// Beispiel für eine Node.js-Anwendung
const mysql = require('mysql');
const connection = mysql.createConnection({
  host: process.env.DB_HOST,
  //port: process.env.DB_PORT,
  //user: process.env.DB_USER,
  password: process.env.DB_PASSWORD,
  //database: process.env.DB_NAME
});

connection.connect((err) => {
  if (err) {
    console.error('Fehler bei der Verbindung zur Datenbank:', err);
    return;
  }
  console.log('Erfolgreich mit der Datenbank verbunden');
});