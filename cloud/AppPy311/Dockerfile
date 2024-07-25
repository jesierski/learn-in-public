# Nutze das Image python 3.11-slim als Basis
FROM python:3.11-slim

# Kopiere das gesamte Arbeitsverzeichnis von Host in den Container
COPY . .

# Die Abhängigkeiten installieren
RUN pip3 install --no-cache-dir -r requirements.txt

# Befehl python3 main.py ausführen
ENTRYPOINT [ "python3", "main.py" ]