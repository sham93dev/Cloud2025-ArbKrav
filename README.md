# Cloud2025 Arbeidskrav - Dockerisert Applikasjon

## 1. Beskrivelse

Dette prosjektet setter opp et **fullt containerisert API** ved hjelp av **Docker** og **Docker Compose**.
API-et består av følgende tjenester:

- **Nginx** – Reverse proxy for å håndtere forespørsler.
- **REST API** – Backend utviklet i **.NET**.
- **MySQL** – Database for lagring av data.

Alle tjenestene kjører som **separate containere** i samme Docker-nettverk.

GitHub-repo: [Cloud2025-ArbKrav](https://github.com/sham93dev/Cloud2025-ArbKrav)
Docker Hub-repo: [shambackend](https://hub.docker.com/repositories/shambackend)

---

## 2. Komme i gang

### 2.1 Klon prosjektet

```sh
git clone https://github.com/sham93dev/Cloud2025-ArbKrav.git
cd Cloud2025-ArbKrav
```

### 2.2 Bygg og start containerne

```sh
docker-compose up --build -d
```

Dette starter **Nginx**, **REST API** og **MySQL** i bakgrunnen som Docker-containere.

### 2.3 Test at API-et kjører

#### Åpne i nettleser:

```
http://localhost
```

#### Test API-endepunkt med cURL:

```sh
curl http://localhost/api/test
```

#### Koble til MySQL-databasen fra containeren:

```sh
docker exec -it cloud2025-arbkrav-mysql-1 mysql -u root -pShamilPass123
```

---

## 3. Filstruktur

```plaintext
Cloud2025-ArbKrav/
│── mysql/
├── Dockerfile
│── nginx/
│   ├── Dockerfile
│   ├── nginx.conf
│── restapi/
│   ├── publish/
│   ├── Dockerfile
├── appsettings.json
│── docker-compose.yml
├── Program.cs
│── README.md
```

---

## 4. Brukte teknologier

- **Docker & Docker Compose**
- **Nginx**
- **ASP.NET Core**
- **MySQL**

---

## 5. Pushe til Docker Hub

For å laste opp bildene til Docker Hub, kjør følgende kommandoer:

```sh
docker tag cloud2025-arbkrav-restapi dockerhubbrukernavn/restapi:latest
docker push dockerhubbrukernavn/restapi:latest

docker tag cloud2025-arbkrav-nginx dockerhubbrukernavn/nginx:latest
docker push dockerhubbrukernavn/nginx:latest

docker tag cloud2025-arbkrav-mysql dockerhubbrukernavn/mysql:latest
docker push dockerhubbrukernavn/mysql:latest
```

---

## 6. Feilsøking

### Sjekk om containerne kjører:

```sh
docker ps
```

### Se logs for en container:

```sh
docker logs cloud2025-arbkrav-restapi-1
```
