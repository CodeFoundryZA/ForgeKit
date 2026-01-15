#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "$0")/.." && pwd)"
if [ -f "${ROOT_DIR}/.env" ]; then
  set -a
  . "${ROOT_DIR}/.env"
  set +a
fi

if [ "$#" -ne 1 ]; then
  echo "Usage: $0 /path/to/backup.sql"
  exit 1
fi

backup_file="$1"

if [ ! -f "${backup_file}" ]; then
  echo "Backup file not found: ${backup_file}"
  exit 1
fi

PGPASSWORD="${POSTGRES_PASSWORD}" psql \
  -h "${POSTGRES_HOST:-localhost}" \
  -p "${POSTGRES_PORT:-5432}" \
  -U "${POSTGRES_USER}" \
  -d "${POSTGRES_DB}" \
  -f "${backup_file}"

echo "Restore completed from ${backup_file}"
