# ForgeKit Local Postgres

## Quick start

```bash
docker compose --env-file .env -f docker-compose.yml up -d
```

## Connection vars

- `POSTGRES_HOST`
- `POSTGRES_PORT`
- `POSTGRES_DB`
- `POSTGRES_USER`
- `POSTGRES_PASSWORD`

## Helper scripts

From `forgekit-api/deploy/docker`:

```bash
./scripts/backup.sh
./scripts/restore.sh /path/to/backup.sql
./scripts/wipe.sh
```

## Stop

```bash
docker compose --env-file .env -f docker-compose.yml down
```
