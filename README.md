Cloud2025 Arbeidskrav - Dockerisert Applikasjon

---

🔵 📌 Beskrivelse

Dette prosjektet setter opp en fullstack-applikasjon ved hjelp av Docker og Docker Compose.

Applikasjonen består av:

✅ Nginx som reverse proxy
✅ REST API utviklet i .NET
✅ MySQL database

Løsningen er containerisert, og alle tjenestene kommuniserer i samme nettverk.

---

🔵 🚀 Komme i gang

1️⃣ Klon prosjektet

git clone <repository-url>
cd Cloud2025-arb.krav

2️⃣ Bygg og start containerne

docker-compose up --build -d

Dette starter Nginx, REST API og MySQL i separate containere.

3️⃣ Test at alt fungerer

🌍Åpne nettleseren og gå til:

http://localhost

🔹 Test API-et direkte:

curl http://localhost/api/test

🗄 Koble til MySQL-databasen:

docker exec -it cloud2025-arbkrav-mysql-1 mysql -u root -pShamilPass123

---

🔵 📂 Filstruktur

Cloud2025-arb.krav/
│── mysql/
├── Dockerfile
│── nginx/  
│ ├── Dockerfile
│ ├── nginx.conf
│── restapi/
│ ├── publish
│ ├── Dockerfile
├── appsettings.json
│── docker-compose.yml
├── Program.cs
│── README.md

🔵 🔧 Teknologier

🚀 Brukte teknologier:

🐳 Docker & Docker Compose

🌐 Nginx

🔧 ASP.NET Core

🗄 MySQL

🔵 📤 Pushe til Docker Hub

For å laste opp bildene til Docker Hub, kjør følgende kommandoer:

docker tag cloud2025-arbkrav-restapi dockerhubbrukernavn/restapi:latest
docker push dockerhubbrukernavn/restapi:latest

docker tag cloud2025-arbkrav-nginx dockerhubbrukernavn/nginx:latest
docker push dockerhubbrukernavn/nginx:latest

docker tag cloud2025-arbkrav-mysql dockerhubbrukernavn/mysql:latest
docker push dockerhubbrukernavn/mysql:latest

🔵 ❌ Feilsøking

📌 Sjekk om containerne kjører:

docker ps

📌 Se logs for en container:

docker logs cloud2025-arbkrav-restapi-1

📌 Prøv å starte alt på nytt:
