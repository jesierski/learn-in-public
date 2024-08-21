# Basis-Image
FROM node:latest

# Arbeitsverzeichnis
WORKDIR /app

# Startdatei für Node kopieren
COPY package.json .

# Node installieren
RUN npm install

# Alle Dateien in /app mitnehmen
COPY . .

# Port, an dem Node lauscht
EXPOSE 8080

# Node starten
CMD ["node","index.js"]
