#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "$0")/.." && pwd)"
if [ -f "${ROOT_DIR}/.env" ]; then
  set -a
  . "${ROOT_DIR}/.env"
  set +a
fi

BACKUP_DIR="${ROOT_DIR}/backups"
mkdir -p "${BACKUP_DIR}"

timestamp="$(date +"%Y%m%d_%H%M%S")"
backup_file="${BACKUP_DIR}/forgekit_db_${timestamp}.sql"

PGPASSWORD="${POSTGRES_PASSWORD}" pg_dump \
  -h "${POSTGRES_HOST:-localhost}" \
  -p "${POSTGRES_PORT:-5432}" \
  -U "${POSTGRES_USER}" \
  -d "${POSTGRES_DB}" \
  -f "${backup_file}"

echo "Backup saved to ${backup_file}"
