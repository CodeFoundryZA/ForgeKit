#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "$0")/.." && pwd)"
if [ -f "${ROOT_DIR}/.env" ]; then
  set -a
  . "${ROOT_DIR}/.env"
  set +a
fi

PGPASSWORD="${POSTGRES_PASSWORD}" psql \
  -h "${POSTGRES_HOST:-localhost}" \
  -p "${POSTGRES_PORT:-5432}" \
  -U "${POSTGRES_USER}" \
  -d "${POSTGRES_DB}" \
  -v ON_ERROR_STOP=1 <<'SQL'
DO $$
DECLARE
  table_record RECORD;
BEGIN
  FOR table_record IN
    SELECT tablename
    FROM pg_tables
    WHERE schemaname = 'public'
  LOOP
    EXECUTE 'TRUNCATE TABLE public.' || quote_ident(table_record.tablename) || ' CASCADE';
  END LOOP;
END $$;
SQL

echo "All public tables truncated."
