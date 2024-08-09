# Nutze ein offizieles Python-Image als Basis. Hier python 3.11-slim
FROM python:3.7-slim

# Setze Arbeitsverzeichnis auf /app
WORKDIR /app

# Kopiere die Anwendungsdatei vom Host in den Container
#FEHLER
#COPY requirements.txt requirements.txt
#COPY app.py app.py
#KORREKT
ADD . /app

# Die Abhängigkeiten installieren, d.h. erforderliche Python-Pakete
# RUN pip3 install --no-cache-dir -r requirements.txt
RUN pip install --no-cache-dir -r requirements.txt

# Port 80 verfügbar machen
EXPOSE 80

# Befehl python app.py ausführen
CMD [ "python", "app.py" ]