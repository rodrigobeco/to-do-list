
# TodoList

TodoList is a CRUD API Project, with: Framework .NET 8.0 | EntityFramework | Postgres | Docker



## Installation

Create Postgres Database Container

```bash
docker compose up -d db
docker exec -it db psql -U postgres
COPY AND PAST CONTENT OF SCRIPT.SQL AND RUN IT
```

Finally, build and run docker compose:

```bash
docker compose build
docker compose up todoapp
```
    